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
    ///     Stores information about a player in the server
    /// </summary>
    public class PlayerInfo {
        /// <summary>
        ///     The name of the player
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        ///     The amount of kills the player has (default: -9999)
        /// </summary>
        public int Kills { get; set; } = -9999;

        /// <summary>
        ///     The amount of deaths the player has (default: -9999)
        /// </summary>
        public int Deaths { get; set; } = -9999;

        /// <summary>
        ///     The score of the player (default: -9999)
        /// </summary>
        public int Score { get; set; } = -9999;

        /// <summary>
        ///     The ping of the player (default: -9999)
        /// </summary>
        public int Ping { get; set; } = -9999;

        /// <summary>
        ///     The rate(?) of the player (default: -9999)
        /// </summary>
        public int Rate { get; set; } = -9999;

        /// <summary>
        ///     The index of the player in the server
        /// </summary>
        public int Index { get; set; } = -9999;

        /// <summary>
        ///     The time the player has been in the server
        /// </summary>
        public float Time { get; set; } = 0.0f;
    }
}