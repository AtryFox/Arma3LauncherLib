using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DerAtrox.Arma3LauncherLib.Utilities {
    /// <summary>
    /// Generic utilites.
    /// </summary>
    public class GenericUtils {
        /// <summary>
        /// Generates a MD5 hash of the given file.
        /// </summary>
        /// <param name="fileName">File to hash.</param>
        /// <returns>Hash value of file.</returns>
        public static string GetMd5FileHash(string fileName) {
            using (Stream file = File.OpenRead(fileName)) {
                using (HashAlgorithm hasher = MD5.Create()) {
                    int bytesRead;
                    byte[] buffer;
                    do {
                        buffer = new byte[32768];
                        bytesRead = file.Read(buffer, 0, buffer.Length);
                        hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                    } while (bytesRead != 0);

                    hasher.TransformFinalBlock(buffer, 0, 0);

                    var hash = new StringBuilder(32);

                    foreach (byte b in hasher.Hash) {
                        hash.Append(b.ToString("X2").ToLower());
                    }

                    return hash.ToString();
                }
            }
        }

        /// <summary>
        /// Generates a MD5 hash of the text.
        /// </summary>
        /// <param name="textToHash">Text to hash.</param>
        /// <returns>Hash value of text.</returns>
        public static string GetMd5StringHash(string textToHash) {
            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(textToHash);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++) {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString().ToLower();
        }
    }
}
