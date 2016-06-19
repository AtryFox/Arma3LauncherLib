using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.Utilities;


namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides methods for updating and managing different mission files.
    /// </summary>
    public class ArmaMission {
        private readonly string _missionFileName;
        private readonly string _missionFolder;
        private readonly string _tempFolder;
        private readonly string _hashFileUrl;
        private readonly string _missionUrl;

        /// <summary>
        /// Current update status, uses by <see cref="UpdateMission"/> and <see cref="UpdateMissionAsync"/>.
        /// </summary>
        public UpdateStatus Status = new UpdateStatus();

        /// <summary>
        /// Initialzes a new Arma mission object.
        /// </summary>
        /// <param name="missionFileName">File name of mission file with file extension.</param>
        /// <param name="missionFolder">Destination folder of mission file.</param>
        /// <param name="tempFolder">Working directory for downloading and extracting.</param>
        /// <param name="hashFileUrl">Url of text file containing the latest hash.</param>
        /// <param name="missionUrl">Download url of the mission file.</param>
        public ArmaMission(string missionFileName, string missionFolder, string tempFolder, string hashFileUrl, string missionUrl) {
            _missionFileName = missionFileName;
            _missionFolder = missionFolder;
            _tempFolder = tempFolder;
            _hashFileUrl = hashFileUrl;
            _missionUrl = missionUrl;
        }
        
        /// <summary>
        /// Checks mission file for updates.
        /// </summary>
        /// <param name="currentHash">Hash of currently used mission file.</param>
        /// <returns>Returns if the mission file is up to date.</returns>
        public bool CheckUpdate(string currentHash) {

            string remoteHash;
            using (var web = new WebClient()) {
                try {
                    remoteHash = web.DownloadString(_hashFileUrl);
                } catch {
                    throw new NotImplementedException();
                }
            }

            return currentHash != remoteHash;
        }

        /// <summary>
        /// Checks mission file for updates.
        /// </summary>
        /// <param name="currentHash">Hash of currently used mission file.</param>
        /// <returns>Returns if the mission file is up to date.</returns>
        public async Task<bool> CheckUpdateAsync(string currentHash) {
            return await Task.Run(() => CheckUpdate(currentHash));
        }

        private void CleanMissionFolder() {
            try {
                if (Directory.Exists(_missionFolder)) {
                    if (File.Exists(Path.Combine(_missionFolder, _missionFileName))) {
                        File.Delete(Path.Combine(_missionFolder, _missionFileName));
                    }
                } else {
                    Directory.CreateDirectory(_tempFolder);
                }

            } catch {
                throw new NotImplementedException();
            }

        }

        private void CleanTempFolder() {
            try {
                if (Directory.Exists(_tempFolder)) {
                    if (File.Exists(Path.Combine(_tempFolder, _missionFileName))) {
                        File.Delete(Path.Combine(_tempFolder, _missionFileName));
                    }

                    if (File.Exists(Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)))) {
                        File.Delete(Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)));
                    }
                } else {
                    Directory.CreateDirectory(_tempFolder);
                }
            } catch {
                throw new NotImplementedException();
            }
        }

        private void UnpackMoveMission() {
            string extension = new FileInfo(Path.Combine(_tempFolder, Path.GetFileName(_missionUrl))).Extension.ToLower();

            switch (extension) {
                case ".pdo":
                    break;
                case ".zip":
                    try {
                        ZipFile.ExtractToDirectory(Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)), _tempFolder);
                    } catch {
                        throw new NotImplementedException();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }

            CleanMissionFolder();
            try {
                if (File.Exists(Path.Combine(_tempFolder, _missionFileName))) {
                    File.Move(Path.Combine(_tempFolder, _missionFileName),
                        Path.Combine(_missionFolder, _missionFileName));
                } else {
                    throw new NotImplementedException();
                }
            } catch {
                throw new NotImplementedException();
            }
        }

        private string HashMission(string path) {
            try {
                if (File.Exists(path)) {
                    return GenericUtils.GetMd5FileHash(path);
                }
                throw new NotImplementedException();
            }
            catch {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Downloads and if necessary extracts and hashs the mission file.
        /// </summary>
        /// <param name="disableHashing">Disables generating a new hash.</param>
        /// <param name="hashCompressedFile">Hashs the downloaded archive instead of the extracted mission file.</param>
        /// <returns>New hash of mission or "downloaded" if disableHasing is set to true.</returns>
        public string UpdateMission(bool disableHashing = false, bool hashCompressedFile = false) {
            Status.SetStatus(UpdateStatus.UpdateState.Cleaning);
            CleanTempFolder();

            Status.SetStatus(UpdateStatus.UpdateState.Downloading);
            using (var web = new WebClient()) {
                try {
                    //web.DownloadProgressChanged += (sender, args) => Status.SetStatus(args.ProgressPercentage);
                    web.DownloadFile(new Uri(_missionUrl), Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)));
                } catch {
                    throw new NotImplementedException();
                }
            }

            Status.SetStatus(UpdateStatus.UpdateState.Extracting);
            UnpackMoveMission();

            string hash = "downloaded";

            if (!disableHashing) {
                Status.SetStatus(UpdateStatus.UpdateState.Hashing);
                hash =  HashMission(hashCompressedFile ? Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)) : Path.Combine(_missionFolder, _missionFileName));
            }

            Status.SetStatus(UpdateStatus.UpdateState.Cleaning);
            CleanTempFolder();
            CleanMissionFolder();

            return hash;


        }

        /// <summary>
        /// Downloads and if necessary extracts and hashs the mission file.
        /// </summary>
        /// <param name="disableHashing">Disables generating a new hash.</param>
        /// <param name="hashCompressedFile">Hashs the downloaded archive instead of the extracted mission file.</param>
        /// <returns>New hash of mission or "downloaded" if disableHasing is set to true.</returns>
        public async Task<string> UpdateMissionAsync(bool disableHashing = false, bool hashCompressedFile = false) {
            Status.SetStatus(UpdateStatus.UpdateState.Cleaning);
            await Task.Run(() => CleanTempFolder());

            Status.SetStatus(UpdateStatus.UpdateState.Downloading);
            using (var web = new WebClient()) {
                try {
                    web.DownloadProgressChanged += (sender, args) => Status.SetStatus(args.ProgressPercentage);
                    await web.DownloadFileTaskAsync(_missionUrl, Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)));
                } catch {
                    return "";
                }
            }
            
            Status.SetStatus(UpdateStatus.UpdateState.Extracting);
            await Task.Run(() => UnpackMoveMission());

            string hash = "downloaded";

            if (!disableHashing) {
                Status.SetStatus(UpdateStatus.UpdateState.Hashing);
                hash = await Task.Run(() => HashMission(hashCompressedFile ? Path.Combine(_tempFolder, Path.GetFileName(_missionUrl)) : Path.Combine(_missionFolder, _missionFileName)));
            }

            Status.SetStatus(UpdateStatus.UpdateState.Cleaning);
            await Task.Run(() => CleanTempFolder());
            await Task.Run(() => CleanMissionFolder());

            return hash;
        }
    }
}
