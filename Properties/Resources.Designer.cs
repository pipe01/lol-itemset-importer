﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoL_Item_Set_Manager.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
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
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LoL_Item_Set_Manager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a [{&quot;ID&quot;:24,&quot;Name&quot;:&quot;Jax&quot;},{&quot;ID&quot;:37,&quot;Name&quot;:&quot;Sona&quot;},{&quot;ID&quot;:18,&quot;Name&quot;:&quot;Tristana&quot;},{&quot;ID&quot;:110,&quot;Name&quot;:&quot;Varus&quot;},{&quot;ID&quot;:114,&quot;Name&quot;:&quot;Fiora&quot;},{&quot;ID&quot;:27,&quot;Name&quot;:&quot;Singed&quot;},{&quot;ID&quot;:223,&quot;Name&quot;:&quot;Tahm Kench&quot;},{&quot;ID&quot;:7,&quot;Name&quot;:&quot;LeBlanc&quot;},{&quot;ID&quot;:412,&quot;Name&quot;:&quot;Thresh&quot;},{&quot;ID&quot;:43,&quot;Name&quot;:&quot;Karma&quot;},{&quot;ID&quot;:202,&quot;Name&quot;:&quot;Jhin&quot;},{&quot;ID&quot;:68,&quot;Name&quot;:&quot;Rumble&quot;},{&quot;ID&quot;:77,&quot;Name&quot;:&quot;Udyr&quot;},{&quot;ID&quot;:64,&quot;Name&quot;:&quot;Lee Sin&quot;},{&quot;ID&quot;:83,&quot;Name&quot;:&quot;Yorick&quot;},{&quot;ID&quot;:141,&quot;Name&quot;:&quot;Kayn&quot;},{&quot;ID&quot;:38,&quot;Name&quot;:&quot;Kassadin&quot;},{&quot;ID&quot;:15,&quot;Name&quot;:&quot;Sivir&quot;},{&quot;ID&qu....
        /// </summary>
        internal static string champcache {
            get {
                return ResourceManager.GetString("champcache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a .
        /// </summary>
        internal static string riot_api_key {
            get {
                return ResourceManager.GetString("riot-api-key", resourceCulture);
            }
        }
    }
}