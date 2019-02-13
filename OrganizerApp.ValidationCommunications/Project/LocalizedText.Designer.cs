﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrganizerApp.ValidationCommunications.Project {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class LocalizedText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OrganizerApp.ValidationCommunications.Project.LocalizedText", typeof(LocalizedText).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nieprawidłowa wartość typu czasu. Typ czasu wykonania musi być równy jednej z następujących wartości: next, scheduled, someday..
        /// </summary>
        public static string ExecutionTimeAcceptedValues {
            get {
                return ResourceManager.GetString("ExecutionTimeAcceptedValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj typ czasu wykonania projektu..
        /// </summary>
        public static string ExecutionTimeRequired {
            get {
                return ResourceManager.GetString("ExecutionTimeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nieprawidłowa wartość ID. ID musi równać się 0 (dla nowego rekordu) lub być większe od 0 dla rekordu aktualizowanego..
        /// </summary>
        public static string IdRange {
            get {
                return ResourceManager.GetString("IdRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj wartość id..
        /// </summary>
        public static string IdRequired {
            get {
                return ResourceManager.GetString("IdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj nazwę projektu..
        /// </summary>
        public static string NameRequired {
            get {
                return ResourceManager.GetString("NameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nieprawidłowa wartość typu priorytetu. Priorytet musi być równy jednej z następujących wartości: low, medium, high..
        /// </summary>
        public static string PriorityAcceptedValues {
            get {
                return ResourceManager.GetString("PriorityAcceptedValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj priorytet projektu..
        /// </summary>
        public static string PriorityRequired {
            get {
                return ResourceManager.GetString("PriorityRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Projekt o typie czasu \&quot;scheduled\&quot; musi mieć podaną konkretną datę rozpoczęcia..
        /// </summary>
        public static string StartTimeRequired {
            get {
                return ResourceManager.GetString("StartTimeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nieprawidłowa wartość stanu projektu. Stan projektu musi być równy jednej z następujących wartości: todo, done, deleted..
        /// </summary>
        public static string StateAcceptedValues {
            get {
                return ResourceManager.GetString("StateAcceptedValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj stan projektu..
        /// </summary>
        public static string StateRequired {
            get {
                return ResourceManager.GetString("StateRequired", resourceCulture);
            }
        }
    }
}
