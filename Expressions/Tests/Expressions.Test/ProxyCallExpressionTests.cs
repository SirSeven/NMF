﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NMF.Expressions.Test
{
    [TestClass]
    public class ProxyCallExpressionTests
    {
        [TestMethod]
        public void ProxyCall_GenericNoObservable_UpdateIfValueChanges()
        {
            var update = false;
            var dummy = new Dummy<string>("42");
            
            var test = Observable.Expression(() => ProxyTest(dummy.Item));

            test.ValueChanged += (o, e) => update = true;

            Assert.AreEqual("42", test.Value);
            Assert.IsFalse(update);

            dummy.Item = "23";

            Assert.IsFalse(update);

            TestProxy<string>.SetValue("FooBar");

            Assert.IsTrue(update);
            Assert.AreEqual("FooBar", test.Value);
        }

        [TestMethod]
        public void ProxyCall_GenericObservable_Update()
        {
            var update = false;
            var dummy = new ObservableDummy<string>("42");

            var test = Observable.Expression(() => ProxyTest(dummy.Item));

            test.ValueChanged += (o, e) =>
            {
                Assert.AreEqual("42", e.OldValue);
                Assert.AreEqual("23", e.NewValue);
                update = true;
            };

            Assert.AreEqual("42", test.Value);
            Assert.IsFalse(update);

            dummy.Item = "23";

            Assert.IsTrue(update);
            Assert.AreEqual("23", test.Value);
        }

        [TestMethod]
        public void ProxyCall_NonGenericNoObservable_UpdateIfValueChanges()
        {
            var update = false;
            var dummy = new Dummy<int>(1);

            var test = Observable.Expression(() => ProxyTest(42, dummy.Item));

            test.ValueChanged += (o, e) => update = true;

            Assert.AreEqual(1, test.Value);
            Assert.IsFalse(update);

            dummy.Item = 2;

            Assert.IsFalse(update);

            TestProxy<int>.SetValue(3);

            Assert.IsTrue(update);
            Assert.AreEqual(3, test.Value);
        }

        [TestMethod]
        public void ProxyCall_NonGenericObservable_Update()
        {
            var update = false;
            var dummy = new ObservableDummy<int>(1);

            var test = Observable.Expression(() => ProxyTest(42, dummy.Item));

            test.ValueChanged += (o, e) =>
            {
                Assert.AreEqual(1, e.OldValue);
                Assert.AreEqual(2, e.NewValue);
                update = true;
            };

            Assert.AreEqual(1, test.Value);
            Assert.IsFalse(update);

            dummy.Item = 2;

            Assert.IsTrue(update);
            Assert.AreEqual(2, test.Value);
        }

        [TestMethod]
        public void ProxyCall_NonGenericObservable_DisposesOldProxy()
        {
            var update = false;
            var dummy = new ObservableDummy<int>(1);

            var test = Observable.Expression(() => ProxyTest(42, dummy.Item));

            test.ValueChanged += (o, e) =>
            {
                Assert.AreEqual(1, e.OldValue);
                Assert.AreEqual(2, e.NewValue);
                update = true;
            };

            Assert.AreEqual(1, test.Value);
            Assert.IsFalse(update);
            TestProxy.Disposed = false;

            dummy.Item = 2;

            Assert.IsTrue(update);
            Assert.IsTrue(TestProxy.Disposed);
            Assert.AreEqual(2, test.Value);
        }

        [ObservableProxy(typeof(TestProxy), "StaticProxy")]
        private static int ProxyTest(int argument, int result)
        {
            return result;
        }

        [ObservableProxy(typeof(TestProxy<>), "GenericProxy")]
        private static T ProxyTest<T>(T item)
        {
            return item;
        }

        private class TestProxy<T> : INotifyValue<T>
        {
            public static INotifyValue<T> GenericProxy(T item)
            {
                return new TestProxy<T>(item);
            }

            public TestProxy(T item)
            {
                value = item;
                instancies.Add(this);
            }

            private static T value;
            private static List<TestProxy<T>> instancies = new List<TestProxy<T>>();

            public static void SetValue(T newValue)
            {
                var oldValue = value;
                value = newValue;
                foreach (var instance in instancies)
                {
                    if (instance.ValueChanged != null)
                    {
                        instance.ValueChanged(instance, new ValueChangedEventArgs(oldValue, newValue));
                    }
                }
            }

            public event EventHandler<ValueChangedEventArgs> ValueChanged;

            public void Detach() { }

            public void Attach() { }

            public T Value
            {
                get { return value; }
            }

            public bool IsAttached
            {
                get { return true; }
            }
        }

        private class TestProxy : TestProxy<int>, IDisposable
        {
            public static bool Disposed { get; set; }

            public static INotifyValue<int> StaticProxy(int argument, int value)
            {
                return new TestProxy(argument, value);
            }

            public TestProxy(int argument, int value)
                : base(value)
            {
                Assert.AreEqual(42, argument);
            }

            public void Dispose()
            {
                Disposed = true;
            }
        }
    }
}
