using System;

namespace DerAtrox.Arma3LauncherLib.Exceptions {
    /// <summary>
    /// The exception that is thrown when Arma 3 could not be found.
    /// </summary>
    class ArmaNotFoundException : Exception{
        /// <summary>
        /// Initializes a new instance of the ArmaNotFoundException class.
        /// </summary>
        public ArmaNotFoundException() {
        }

        /// <summary>
        /// Initializes a new instance of the ArmaNotFoundException class with a specific error message.
        /// </summary>
        /// <param name="message">Error message.</param>
        public ArmaNotFoundException(string message) : base(message) {
        }
    }
}
