/*
 * This file is part of SSQLib.
 *
 *   SSQLib is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   SSQLib is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Lesser General Public License for more details.
 *
 *   You should have received a copy of the GNU Lesser General Public License
 *   along with SSQLib.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace DerAtrox.Arma3LauncherLib.SSQLib.Model {
    /// <summary>
    ///     Stores information about the Source server
    /// </summary>
    public class ServerInfo {
        /// <summary>
        ///     Used to describe the type of server running
        /// </summary>
        public enum DedicatedType {
            /// <summary>
            ///     Default value
            /// </summary>
            None,

            /// <summary>
            ///     Listen server (locally hosted)
            /// </summary>
            Listen,

            /// <summary>
            ///     Dedicated server
            /// </summary>
            Dedicated,

            /// <summary>
            ///     SourceTV server
            /// </summary>
            Sourcetv
        }

        /// <summary>
        ///     Used to describe the operating system running on the server
        /// </summary>
        public enum OsType {
            /// <summary>
            ///     Default value
            /// </summary>
            None,

            /// <summary>
            ///     Windows server
            /// </summary>
            Windows,

            /// <summary>
            ///     Linux server
            /// </summary>
            Linux
        }

        /// <summary>
        ///     The name of the server
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        ///     The IP address of the server
        /// </summary>
        public string Ip { get; set; } = "";

        /// <summary>
        ///     The port the server uses
        /// </summary>
        public string Port { get; set; } = "";

        /// <summary>
        ///     The game being played on the server (i.e. Team Fortress (tf))
        /// </summary>
        public string Game { get; set; } = "";

        /// <summary>
        ///     The game version running on the server
        /// </summary>
        public string Version { get; set; } = "";

        /// <summary>
        ///     The map currently being played on the server
        /// </summary>
        public string Map { get; set; } = "";

        /// <summary>
        ///     The current player count on the server
        /// </summary>
        public string PlayerCount { get; set; } = "";

        /// <summary>
        ///     The current bot count on the server
        /// </summary>
        public string BotCount { get; set; } = "";

        /// <summary>
        ///     The max amount of players allowed on the server
        /// </summary>
        public string MaxPlayers { get; set; } = "";

        /// <summary>
        ///     Stores whether the server is passworded or not
        /// </summary>
        public bool Password { get; set; } = false;

        /// <summary>
        ///     Stores whether the server is VAC protected or not
        /// </summary>
        public bool Vac { get; set; } = false;

        /// <summary>
        ///     Stores whether the server is locked or not
        /// </summary>
        public bool Locked { get; set; } = false;

        /// <summary>
        ///     Stores the app ID of the game used by the server
        /// </summary>
        public string AppId { get; set; } = "";

        /// <summary>
        ///     Stores the type of server running (Listen, Dedicated, SourceTV)
        /// </summary>
        public DedicatedType Dedicated { get; set; } = DedicatedType.None;

        /// <summary>
        ///     Stores the operating system of the server (Windows, Linux)
        /// </summary>
        public OsType Os { get; set; } = OsType.None;

        /// <summary>
        ///     Stores the ping to the server
        /// </summary>
        public float Ping { get; set; } = -1;
    }
}