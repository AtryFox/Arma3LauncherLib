using System;
using DerAtrox.Arma3LauncherLib.Exceptions;
using Microsoft.Win32;
using DerAtrox.Arma3LauncherLib.Model;

namespace DerAtrox.Arma3LauncherLib.Utilities {
    /// <summary>
    /// Utilities for working with <see cref="ArmaLauncher">ArmaLauncher</see>.
    /// </summary>
    public class ArmaUtils {
        /// <summary>
        /// Tries to find the Arma 3 directory in the registry.
        /// </summary>
        /// <returns>Arma 3 directory.</returns>
        /// <exception cref="ArmaNotFoundException">Is thrown, when Arma 3 could not be found.</exception>
        public static string GetArma3Path() {
            string regPath;

            int size = IntPtr.Size;
            if (size == 4 || size != 8) {
                regPath = "SOFTWARE\\Bohemia Interactive\\ArmA 3";
            } else {
                regPath = "SOFTWARE\\Wow6432Node\\Bohemia Interactive\\arma 3";
            }


            try {
                var localMachine = Registry.LocalMachine;
                var registryKey = localMachine.OpenSubKey(regPath);
                if (registryKey != null) {
                    return registryKey.GetValue("MAIN").ToString();
                }
                throw new ArmaNotFoundException("Arma 3 installation directory could not be found!");
            } catch {
                throw new ArmaNotFoundException("Arma 3 installation directory could not be found!");
            }
        }
    }
}
