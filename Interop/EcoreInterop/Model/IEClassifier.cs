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
using NMF.Models.Meta;
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

namespace NMF.Interop.Ecore
{
    
    
    /// <summary>
    /// The public interface for EClassifier
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EClassifier))]
    [XmlDefaultImplementationTypeAttribute(typeof(EClassifier))]
    public interface IEClassifier : IModelElement, IENamedElement
    {
        
        /// <summary>
        /// The instanceClassName property
        /// </summary>
        string InstanceClassName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The instanceTypeName property
        /// </summary>
        string InstanceTypeName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ePackage property
        /// </summary>
        IEPackage EPackage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eTypeParameters property
        /// </summary>
        IOrderedSetExpression<IETypeParameter> ETypeParameters
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the InstanceClassName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstanceClassNameChanging;
        
        /// <summary>
        /// Gets fired when the InstanceClassName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstanceClassNameChanged;
        
        /// <summary>
        /// Gets fired before the InstanceTypeName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstanceTypeNameChanging;
        
        /// <summary>
        /// Gets fired when the InstanceTypeName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstanceTypeNameChanged;
        
        /// <summary>
        /// Gets fired before the EPackage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EPackageChanging;
        
        /// <summary>
        /// Gets fired when the EPackage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EPackageChanged;
    }
}

