﻿using NMF.Collections.ObjectModel;
using NMF.Expressions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace NMF.Models.Collections
{
    public class CompositionList<T> : Collection<T> where T : class, IModelElement
    {
        public IModelElement Parent { get; private set; }
        private bool silent;

        public CompositionList(IModelElement parent)
        {
            if (parent == null) throw new ArgumentNullException("parent");

            Parent = parent;
        }

        protected override void ClearItems()
        {
            if (!silent)
            {
                silent = true;
                foreach (var item in this)
                {
                    if (item != null)
                    {
                        item.ParentChanged -= RemoveItem;
                        if (item.Parent == Parent)
                        {
                            item.Delete();
                        }
                    }
                }
                base.ClearItems();
                silent = false;
            }
        }

        protected override void InsertItem(int index, T item)
        {
            if (!silent && item != null)
            {
                item.ParentChanged += RemoveItem;
                silent = true;
                item.Parent = Parent;
                base.InsertItem(index, item);
                silent = false;
            }
        }

        protected override void RemoveItem(int index)
        {
            if (!silent)
            {
                silent = true;
                var item = this[index];
                base.RemoveItem(index);
                if (item != null)
                {
                    item.ParentChanged -= RemoveItem;
                    if (item.Parent == Parent)
                    {
                        item.Delete();
                    }
                }
                silent = false;
            }
        }

        protected override void SetItem(int index, T item)
        {
            if (!silent)
            {
                silent = true;
                var oldItem = this[index];
                if (oldItem != item)
                {
                    if (item != null)
                    {
                        item.ParentChanged += RemoveItem;
                    }
                    if (oldItem != null)
                    {
                        oldItem.ParentChanged -= RemoveItem;
                    }
                    base.SetItem(index, item);
                    if (oldItem != null && oldItem.Parent == Parent)
                    {
                        oldItem.Delete();
                    }
                    if (item != null)
                    {
                        item.Parent = Parent;
                    }
                }
                silent = false;
            }
        }

        private void RemoveItem(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue != Parent)
            {
                var item = sender as T;
                Remove(item);
            }
        }
    }

    public class ObservableCompositionList<T> : ObservableList<T> where T : class, IModelElement
    {
        public IModelElement Parent { get; private set; }
        private bool silent;

        public ObservableCompositionList(IModelElement parent)
        {
            if (parent == null) throw new ArgumentNullException("parent");

            Parent = parent;
        }

        protected override void ClearItems()
        {
            if (!silent)
            {
                var elements = this.ToArray();
                beforeCollectionChangedAction = () =>
                {
                    silent = true;
                    foreach (var item in elements)
                    {
                        if (item != null)
                        {
                            item.ParentChanged -= RemoveItem;
                            if (item.Parent == Parent)
                            {
                                item.Delete();
                            }
                        }
                    }
                };
                base.ClearItems();
                silent = false;
            }
        }

        protected override void InsertItem(int index, T item)
        {
            if (!silent && item != null)
            {
                beforeCollectionChangedAction = () =>
                {
                    silent = true;
                    item.ParentChanged += RemoveItem;
                    item.Parent = Parent;
                    silent = false;
                };
                base.InsertItem(index, item);
            }
        }

        protected override void RemoveItem(int index)
        {
            if (!silent)
            {
                var item = this[index];
                beforeCollectionChangedAction = () =>
                {
                    silent = true;
                    if (item != null)
                    {
                        item.ParentChanged -= RemoveItem;
                        if (item.Parent == Parent)
                        {
                            item.Delete();
                        }
                    }
                    silent = false;
                };
                base.RemoveItem(index);
            }
        }

        protected override void SetItem(int index, T item)
        {
            if (!silent)
            {
                var oldItem = this[index];
                silent = true;
                if (oldItem != item)
                {
                    beforeCollectionChangedAction = () =>
                    {
                        if (item != null)
                        {
                            item.ParentChanged += RemoveItem;
                        }
                        if (oldItem != null)
                        {
                            oldItem.ParentChanged -= RemoveItem;
                        }

                        if (oldItem != null && oldItem.Parent == Parent)
                        {
                            oldItem.Delete();
                        }
                        if (item != null)
                        {
                            item.Parent = Parent;
                        }
                    };
                    base.SetItem(index, item);
                }
                silent = false;
            }
        }

        private void RemoveItem(object sender, ValueChangedEventArgs e)
        {
            var item = sender as T;
            Remove(item);
        }
    }
}
