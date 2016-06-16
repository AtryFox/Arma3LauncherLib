using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace DerAtrox.Arma3LauncherLib.Utilities {
    /// <summary>
    /// Utilities for Arma 3 profiles.
    /// </summary>
    public class ProfileUtils {
        /// <summary>
        /// Returns a list of all Arma 3 profiles including the current windows username.
        /// </summary>
        /// <returns>List of all Arma 3 profiles.</returns>
        public static List<string> GetProfiles() {
            var l = new List<string> { HttpUtility.UrlDecode(Environment.UserName) };

            string dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Arma 3 - Other Profiles\");
            if (!Directory.Exists(dirPath)) return l;

            var dirs = new List<string>(Directory.EnumerateDirectories(dirPath));

            l.AddRange(dirs.Select(s => HttpUtility.UrlDecode(Path.GetFileName(s))));
            return l;
        }
    }
}
