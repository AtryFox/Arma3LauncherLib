using System;

namespace DerAtrox.Arma3LauncherLib.SSQLib.Exceptions {
    /// <summary>
    /// The exception that is thrown when no network connection in available.
    /// </summary>
    public class NetworkNotAvailableException : Exception {
        /// <summary>
        /// Initializes a new instance of the NetworkNotAvailableException class.
        /// </summary>
        public NetworkNotAvailableException() {
        }

        /// <summary>
        /// Initializes a new instance of the NetworkNotAvailableException class with a specific error message.
        /// </summary>
        /// <param name="message">Error message.</param>
        public NetworkNotAvailableException(string message) : base(message) {
        }
    }
}
