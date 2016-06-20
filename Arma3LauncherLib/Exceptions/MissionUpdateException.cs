using System;

namespace DerAtrox.Arma3LauncherLib.Exceptions {
    /// <summary>
    /// The exception that is thrown when a mission update fails.
    /// </summary>
    public class MissionUpdateException : Exception {
        /// <summary>
        /// Initializes a new instance of the MissionUpdateException class.
        /// </summary>
        public MissionUpdateException() {
        }

        /// <summary>
        /// Initializes a new instance of the MissionUpdateException class with a specific error message.
        /// </summary>
        /// <param name="message">Error message.</param>
        public MissionUpdateException(string message) : base(message) {
        }
    }
}
