﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ched.Localization {
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
    internal class ErrorStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ched.Localization.ErrorStrings", typeof(ErrorStrings).Assembly);
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
        ///   Looks up a localized string similar to エクスポートに失敗しました。.
        /// </summary>
        internal static string ExportFailed {
            get {
                return ResourceManager.GetString("ExportFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 編集中のデータは破棄されますがよろしいですか？.
        /// </summary>
        internal static string FileDiscardConfirmation {
            get {
                return ResourceManager.GetString("FileDiscardConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ファイルの読み込み中にエラーが発生しました。.
        /// </summary>
        internal static string FileLoadError {
            get {
                return ResourceManager.GetString("FileLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 現在のバージョンでは開けないファイルです。.
        /// </summary>
        internal static string FileNotCompatible {
            get {
                return ResourceManager.GetString("FileNotCompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 古いバージョンで作成されたファイルです。\nバージョンアップしてよろしいですか？\n(以前のバージョンでは開けなくなります。).
        /// </summary>
        internal static string FileUpgradeNeeded {
            get {
                return ResourceManager.GetString("FileUpgradeNeeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 譜面プロパティから音源ファイルを指定してください。.
        /// </summary>
        internal static string MusicSourceNull {
            get {
                return ResourceManager.GetString("MusicSourceNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 出力先を指定してください。.
        /// </summary>
        internal static string OutputPathRequired {
            get {
                return ResourceManager.GetString("OutputPathRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to プラグインの実行中にエラーが発生しました。.
        /// </summary>
        internal static string PluginException {
            get {
                return ResourceManager.GetString("PluginException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 簡易プレビューが利用できない環境です。.
        /// </summary>
        internal static string PreviewNotSupported {
            get {
                return ResourceManager.GetString("PreviewNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 再エクスポートが完了しました。.
        /// </summary>
        internal static string ReExportComplete {
            get {
                return ResourceManager.GetString("ReExportComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 音源ファイルが見つかりません。.
        /// </summary>
        internal static string SourceFileNotFound {
            get {
                return ResourceManager.GetString("SourceFileNotFound", resourceCulture);
            }
        }
    }
}
