using System;

namespace DerAtrox.Arma3LauncherLib.Exceptions {
    /// <summary>
    /// The exception that is thrown when Arma 3 is already runnning.
    /// </summary>
    public class ArmaRunningException : Exception {
        /// <summary>
        /// Initializes a new instance of the ArmaRunningException class.
        /// </summary>
        public ArmaRunningException() {
        }

        /// <summary>
        /// Initializes a new instance of the ArmaRunningException class with a specific error message.
        /// </summary>
        /// <param name="message">Error message.</param>
        public ArmaRunningException(string message) : base(message) {
        }
    }
}
