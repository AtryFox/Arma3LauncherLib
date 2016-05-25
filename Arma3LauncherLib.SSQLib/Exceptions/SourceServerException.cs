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

using System;

namespace DerAtrox.Arma3LauncherLib.SSQLib.Exceptions {
    /// <summary>
    /// The exception that is thrown when source server can not be reached.
    /// </summary>
    public class SourceServerException : Exception {
        /// <summary>
        /// Initializes a new instance of the SourceServerException class.
        /// </summary>
        public SourceServerException() : base() {
        }

        /// <summary>
        /// Initializes a new instance of the SourceServerException class with a specific error message.
        /// </summary>
        /// <param name="message">Error message.</param>
        public SourceServerException(string message) : base(message) {
        }
    }
}