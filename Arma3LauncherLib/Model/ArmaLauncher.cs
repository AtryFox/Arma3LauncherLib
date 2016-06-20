using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DerAtrox.Arma3LauncherLib.Exceptions;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides a collection of methods to use with a Arma launcher.
    /// </summary>
    public class ArmaLauncher {
        /// <summary>
        /// Starts Arma 3 with specific settings.
        /// </summary>
        /// <param name="arma3StartPath">Path of Arma 3 runable (e.g. path to arma3battleeye.exe)</param>
        /// <param name="startSettings">Start parameters to use.</param>
        /// <param name="checkForRunningTask">Throw <see cref="ArmaRunningException">exception</see>, if Arma 3 is already running.</param>
        /// <param name="arma3TaskName">Custom arma 3 task name.</param>
        /// <exception cref="ArmaRunningException">Is thrown, if checkForRunningTask is true and Arma 3 is running.</exception>
        /// <exception cref="ArmaNotFoundException">Is thrown, if arma3StartPath doesn't exists.</exception>
        public void Connect(string arma3StartPath, ArmaStartSettings startSettings = null, bool checkForRunningTask = false, string arma3TaskName = "arma3") {
            Connect(arma3StartPath, null, startSettings, checkForRunningTask, arma3TaskName);
        }


        /// <summary>
        /// Starts Arma 3 with specific settings.
        /// </summary>
        /// <param name="server">Arma 3 server to connect to.</param>
        /// <param name="arma3StartPath">Path of Arma 3 runable (e.g. path to arma3battleeye.exe)</param>
        /// <param name="startSettings">Start parameters to use.</param>
        /// <param name="checkForRunningTask">Throw <see cref="ArmaRunningException">exception</see>, if Arma 3 is already running.</param>
        /// <param name="arma3TaskName">Custom arma 3 task name.</param>
        /// <exception cref="ArmaRunningException">Is thrown, if checkForRunningTask is true and Arma 3 is running.</exception>
        /// <exception cref="ArmaNotFoundException">Is thrown, if arma3StartPath doesn't exists.</exception>
        public void Connect(string arma3StartPath, ArmaServer server, ArmaStartSettings startSettings = null, bool checkForRunningTask = false, string arma3TaskName = "arma3") {
            if (startSettings == null) startSettings = new ArmaStartSettings();

            if (checkForRunningTask) {
                var runningGame = Process.GetProcessesByName(arma3TaskName);
                if (runningGame.Length > 0) {
                    throw new ArmaRunningException("Arma 3 is already running.");
                }
            }

            if (!File.Exists(arma3StartPath)) {
                throw new ArmaNotFoundException("Specified Arma 3 path could not be found.");
            }

            var args = new List<string>();
            args.Add("2");
            args.Add("1");

            if (server != null) {
                args.Add("-connect=" + server.ServerAdress);
                args.Add("-port=" + server.GamePort);
                if (server.Password != "") {
                    args.Add("-password=" + server.Password);
                }
            }

            if (startSettings.NoSplash) {
                args.Add("-nosplash");
            }

            if (startSettings.NoPause) {
                args.Add("-nopause");
            }

            if (startSettings.ShowScriptErrors) {
                args.Add("-showScriptErrors");
            }

            if (startSettings.Windowed) {
                args.Add("-window");
            }

            if (startSettings.MaxMemory >= 0) {
                args.Add("-maxMem=" + startSettings.MaxMemory);
            }

            if (startSettings.MaxVideoMemory >= 0) {
                args.Add("-maxVRAM=" + startSettings.MaxVideoMemory);
            }

            if (startSettings.Mods.Count > 0) {
                string mods = "-mods=\"";
                mods += string.Join(";", startSettings.Mods);
                mods += "\"";
                args.Add(mods);
            } else {
                args.Add("-mods=\"\"");
            }

            args.AddRange(startSettings.OtherArgs);

            if (startSettings.Profile != "") {
                args.Add("\"-name=" + startSettings.Profile + "\"");
            }

            var proc = new Process {
                StartInfo = {
                            FileName = Path.Combine(arma3StartPath),
                            Arguments = string.Join(" ", args.ToArray()),
                            WorkingDirectory = Path.GetDirectoryName(arma3StartPath)
                        }
            };

            proc.Start();
            proc.Dispose();
        }
    }
}
