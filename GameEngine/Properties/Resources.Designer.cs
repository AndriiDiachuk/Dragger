﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drager.GameEngine.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Drager.GameEngine.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;ISO-8859-1&quot;?&gt;
        ///&lt;!DOCTYPE SokobanLevels SYSTEM &quot;DragerLev.dtd&quot;&gt;
        ///&lt;SokobanLevels&gt;
        ///  &lt;Title&gt;Levels 1-5  - Easy&lt;/Title&gt;
        ///  &lt;Description&gt;The levels from the Drager game&lt;/Description&gt;
        ///  &lt;LevelCollection MaxWidth=&quot;13&quot; MaxHeight=&quot;11&quot;&gt;
        ///    &lt;Level Id=&quot;BW1&quot; Width=&quot;10&quot; Height=&quot;7&quot;&gt;
        ///      &lt;L&gt; #######&lt;/L&gt;
        ///      &lt;L&gt; #     ###&lt;/L&gt;
        ///      &lt;L&gt;##$###   #&lt;/L&gt;
        ///      &lt;L&gt;# @ $  $ #&lt;/L&gt;
        ///      &lt;L&gt;# ..# $ ##&lt;/L&gt;
        ///      &lt;L&gt;##..#   #&lt;/L&gt;
        ///      &lt;L&gt; ########&lt;/L&gt;
        ///    &lt;/Level&gt;
        ///&lt;Level Id=&quot;BW2&quot; Width=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string boxworld {
            get {
                return ResourceManager.GetString("boxworld", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;ISO-8859-1&quot;?&gt;
        ///&lt;!DOCTYPE SokobanLevels SYSTEM &quot;DragerLev.dtd&quot;&gt;
        ///&lt;SokobanLevels&gt;
        ///  &lt;Title&gt;Levels 5-10 - Hard &lt;/Title&gt;
        ///  &lt;Description&gt;The levels from the BoxWorld game&lt;/Description&gt;
        ///  &lt;Email&gt;&lt;/Email&gt;
        ///  &lt;Url&gt;&lt;/Url&gt;
        ///  &lt;LevelCollection Copyright=&quot;Jabbah&quot; MaxWidth=&quot;13&quot; MaxHeight=&quot;11&quot;&gt;
        ///    &lt;Level Id=&quot;BW6&quot; Width=&quot;8&quot; Height=&quot;7&quot;&gt;
        ///      &lt;L&gt;########&lt;/L&gt;
        ///      &lt;L&gt;#  #   #&lt;/L&gt;
        ///      &lt;L&gt;# $..$ #&lt;/L&gt;
        ///      &lt;L&gt;#@$.* ##&lt;/L&gt;
        ///      &lt;L&gt;# $..$ #&lt;/L&gt;
        ///      &lt;L&gt;#  #   #&lt;/L&gt;
        ///      &lt;L&gt;###### [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string boxworld1 {
            get {
                return ResourceManager.GetString("boxworld1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!-- ================== SokobanLevels ====================================== --&gt;
        ///&lt;!ELEMENT SokobanLevels (Title, LevelCollection)&gt;
        ///
        ///&lt;!ELEMENT Title (#PCDATA)&gt;
        ///
        ///
        ///&lt;!ELEMENT LevelCollection (Level+)&gt;
        ///&lt;!ATTLIST LevelCollection
        ///                Copyright CDATA &quot;&quot;
        ///                MaxWidth     CDATA #IMPLIED
        ///                MaxHeight    CDATA #IMPLIED&gt;
        ///
        ///&lt;!ELEMENT Level (L+)&gt;
        ///&lt;!ATTLIST Level Id        CDATA #REQUIRED
        ///                Width     CDATA #IMPLIED
        ///                Height    CDATA #IMPLIED
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DragerLev {
            get {
                return ResourceManager.GetString("DragerLev", resourceCulture);
            }
        }
    }
}
