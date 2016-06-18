using System.Collections.Generic;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Collection of Arma 3 start settings.
    /// </summary>
    public class ArmaStartSettings {
        /// <summary>
        /// Use -nosplash start parameter to skip something.
        /// </summary>
        public bool NoSplash { get; set; } = false;
        /// <summary>
        /// Use -nopause start parameter to skip something.
        /// </summary>
        public bool NoPause { get; set; } = false;
        /// <summary>
        /// Use -showscripterrors start parameter to display script errors.
        /// </summary>
        public bool ShowScriptErrors { get; set; } = false;
        /// <summary>
        /// Use -windowed start parameter to start Arma in windowed mode.
        /// </summary>
        public bool Windowed { get; set; } = false;
        /// <summary>
        /// Use -maxMem=x start parameter to specify max ram. To disable set it lesser 0.
        /// </summary>
        public int MaxMemory { get; set; } = -1;
        /// <summary>
        /// Use -maxVRam=x start parameter to specify max video memory. To disable set it lesser 0.
        /// </summary>
        public int MaxVideoMemory { get; set; } = -1;
        /// <summary>
        /// Use additional start parameters.
        /// </summary>
        public List<string> OtherArgs { get; set; } = new List<string>();
        /// <summary>
        /// Use additional mods. Supports @-notation or full path.
        /// </summary>
        public List<string> Mods { get; set; } = new List<string>();
        /// <summary>
        /// Use -profile=x start parameter to specify a Arma profile.
        /// </summary>
        public string Profile { get; set; } = "";
    }
}
