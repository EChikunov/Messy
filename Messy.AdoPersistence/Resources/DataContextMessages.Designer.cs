﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Messy.AdoPersistence.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DataContextMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DataContextMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Messy.AdoPersistence.Resources.DataContextMessages", typeof(DataContextMessages).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка при миграции базы данных.
        /// </summary>
        internal static string MigrateDatabaseError {
            get {
                return ResourceManager.GetString("MigrateDatabaseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to База данных успешно обновлена до последней версии.
        /// </summary>
        internal static string MigrateDatabaseFinished {
            get {
                return ResourceManager.GetString("MigrateDatabaseFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Запуск миграции базы данных.
        /// </summary>
        internal static string MigrateDatabaseStart {
            get {
                return ResourceManager.GetString("MigrateDatabaseStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Следующие скрипты не были применены: &apos;{0}&apos;.
        /// </summary>
        internal static string NotCommitedScripts {
            get {
                return ResourceManager.GetString("NotCommitedScripts", resourceCulture);
            }
        }
    }
}
