﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XG.BucketSum.Con {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class SettingsBucketSum : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsBucketSum defaultInstance = ((SettingsBucketSum)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsBucketSum())));
        
        public static SettingsBucketSum Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Usuario\\Desktop\\entrada.txt")]
        public string pathLines {
            get {
                return ((string)(this["pathLines"]));
            }
            set {
                this["pathLines"] = value;
            }
        }
    }
}