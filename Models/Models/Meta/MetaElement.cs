//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the MetaElement class
    /// </summary>
    [XmlIdentifierAttribute("Name")]
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//MetaElement/")]
    [DebuggerDisplayAttribute("MetaElement {Name}")]
    public abstract class MetaElement : ModelElement, IMetaElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Name property
        /// </summary>
        private string _name;
        
        /// <summary>
        /// The backing field for the Summary property
        /// </summary>
        private string _summary;
        
        /// <summary>
        /// The backing field for the Remarks property
        /// </summary>
        private string _remarks;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Name property
        /// </summary>
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        public virtual string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    string old = this._name;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNameChanging(e);
                    this.OnPropertyChanging("Name", e);
                    this._name = value;
                    this.OnNameChanged(e);
                    this.OnPropertyChanged("Name", e);
                }
            }
        }
        
        /// <summary>
        /// The Summary property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string Summary
        {
            get
            {
                return this._summary;
            }
            set
            {
                if ((this._summary != value))
                {
                    string old = this._summary;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSummaryChanging(e);
                    this.OnPropertyChanging("Summary", e);
                    this._summary = value;
                    this.OnSummaryChanged(e);
                    this.OnPropertyChanged("Summary", e);
                }
            }
        }
        
        /// <summary>
        /// The Remarks property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string Remarks
        {
            get
            {
                return this._remarks;
            }
            set
            {
                if ((this._remarks != value))
                {
                    string old = this._remarks;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRemarksChanging(e);
                    this.OnPropertyChanging("Remarks", e);
                    this._remarks = value;
                    this.OnRemarksChanged(e);
                    this.OnPropertyChanged("Remarks", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//MetaElement/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the current model element can be identified by an attribute value
        /// </summary>
        public override bool IsIdentified
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Summary property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SummaryChanging;
        
        /// <summary>
        /// Gets fired when the Summary property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SummaryChanged;
        
        /// <summary>
        /// Gets fired before the Remarks property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RemarksChanging;
        
        /// <summary>
        /// Gets fired when the Remarks property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RemarksChanged;
        
        /// <summary>
        /// Raises the NameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SummaryChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSummaryChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SummaryChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SummaryChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSummaryChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SummaryChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RemarksChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemarksChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RemarksChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RemarksChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemarksChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RemarksChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "NAME"))
            {
                return this.Name;
            }
            if ((attribute == "SUMMARY"))
            {
                return this.Summary;
            }
            if ((attribute == "REMARKS"))
            {
                return this.Remarks;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NAME"))
            {
                this.Name = ((string)(value));
                return;
            }
            if ((feature == "SUMMARY"))
            {
                this.Summary = ((string)(value));
                return;
            }
            if ((feature == "REMARKS"))
            {
                this.Remarks = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//MetaElement/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Gets the identifier string for this model element
        /// </summary>
        /// <returns>The identifier string</returns>
        public override string ToIdentifierString()
        {
            if ((this.Name == null))
            {
                return null;
            }
            return this.Name.ToString();
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Name property
        /// </summary>
        private sealed class NameProxy : ModelPropertyChange<IMetaElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NameProxy(IMetaElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Name;
                }
                set
                {
                    this.ModelElement.Name = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.NameChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.NameChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Summary property
        /// </summary>
        private sealed class SummaryProxy : ModelPropertyChange<IMetaElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SummaryProxy(IMetaElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Summary;
                }
                set
                {
                    this.ModelElement.Summary = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SummaryChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SummaryChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Remarks property
        /// </summary>
        private sealed class RemarksProxy : ModelPropertyChange<IMetaElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RemarksProxy(IMetaElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Remarks;
                }
                set
                {
                    this.ModelElement.Remarks = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RemarksChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RemarksChanged -= handler;
            }
        }
    }
}

