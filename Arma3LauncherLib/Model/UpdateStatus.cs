using System;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Update status returned by mission and mod file updater StatusChangedEvent. 
    /// </summary>
    public class UpdateStatus {
        /// <summary>
        /// Initialzes a new update status.
        /// </summary>
        /// <param name="state">New <see cref="UpdateState"/>.</param>
        /// <param name="percentage">New percentage as float.</param>
        public UpdateStatus(UpdateState state, float percentage) {
            State = state;
            Percentage = percentage;
        }

        /// <summary>
        /// Initialzes a new update status.
        /// </summary>
        /// <param name="state">New <see cref="UpdateState"/>.</param>
        public UpdateStatus(UpdateState state) {
            State = state;
            Percentage = 0;
        }

        /// <summary>
        /// Initialzes a new update status.
        /// </summary>
        /// <param name="percentage">New percentage as float.</param>
        public UpdateStatus(int percentage) {
            State = UpdateState.None;
            Percentage = percentage;
        }

        /// <summary>
        /// Initialzes a new update status with default values.
        /// </summary>
        public UpdateStatus() {
            State = UpdateState.None;
            Percentage = 0;
        }

        /// <summary>
        /// Occurs when a new status is set.
        /// </summary>
        public EventHandler<UpdateStatus> UpdateStatusChanged;

        /// <summary>
        /// Sets new status.
        /// </summary>
        /// <param name="state">State of status.</param>
        /// <param name="percentage">Percentage of status.</param>
        public void SetStatus(UpdateState state, float percentage) {
            State = state;
            Percentage = percentage;

            UpdateStatusChanged?.Invoke(this, this);
            
        }

        /// <summary>
        /// Sets new status.
        /// </summary>
        /// <param name="state">State of status.</param>
        public void SetStatus(UpdateState state) {
            State = state;

            UpdateStatusChanged?.Invoke(this, this);
        }

        /// <summary>
        /// Sets new status.
        /// </summary>
        /// <param name="percentage">Percentage of status.</param>
        public void SetStatus(float percentage) {
            Percentage = percentage;

            UpdateStatusChanged?.Invoke(this, this);
        }

        /// <summary>
        /// Returns the current status text.
        /// </summary>
        public UpdateState State { get; private set; }

        /// <summary>
        /// Returns the current percentage of the operation.
        /// </summary>
        public float Percentage { get; private set; }

        /// <summary>
        /// Enum containing all update states.
        /// </summary>
        public enum UpdateState {
            /// <summary>
            /// Update state, when checking for update.
            /// </summary>
            Checking,
            /// <summary>
            /// Update state, when downloading update.
            /// </summary>
            Downloading,
            /// <summary>
            /// Update state, when extracting update.
            /// </summary>
            Extracting,
            /// <summary>
            /// Update state, when copying update to destination directory.
            /// </summary>
            Copying,
            /// <summary>
            /// Update state, when cleaing up old files.
            /// </summary>
            Cleaning,
            /// <summary>
            /// Update state, when generating file hash of downloaded file.
            /// </summary>
            Hashing,
            /// <summary>
            /// Update state, when completed the Update.
            /// </summary>
            Completed,
            /// <summary>
            /// Update state, when not defined.
            /// </summary>
            None
        }
    }
}