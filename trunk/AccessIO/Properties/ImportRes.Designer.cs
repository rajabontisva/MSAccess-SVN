﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessIO.Properties {
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
    internal class ImportRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ImportRes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AccessIO.Properties.ImportRes", typeof(ImportRes).Assembly);
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
        ///   Looks up a localized string similar to Error at line {0}: {1}.
        /// </summary>
        internal static string ErrorAtLineNum {
            get {
                return ResourceManager.GetString("ErrorAtLineNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected file must be Access 2007 or upper file format..
        /// </summary>
        internal static string Invalid2007FileFormat {
            get {
                return ResourceManager.GetString("Invalid2007FileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You need to update to &apos;Access 2002-2003&apos; file format from &apos;Tools -&gt;Database utilities -&gt; Convert project&apos; before load/save file to/from the database..
        /// </summary>
        internal static string InvalidFileFormat {
            get {
                return ResourceManager.GetString("InvalidFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected object name at line {0}.
        /// </summary>
        internal static string ObjectNameNotFound {
            get {
                return ResourceManager.GetString("ObjectNameNotFound", resourceCulture);
            }
        }
    }
}
