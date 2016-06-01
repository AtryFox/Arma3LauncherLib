using System;
using System.Net;

namespace DerAtrox.Arma3LauncherLib.SSQLib.Utilities {
    /// <summary>
    /// Utilities for working with <see cref="IPEndPoint">IPEndPoints</see>.
    /// </summary>
    public class EndPointUtils {
        /// <summary>
        /// Returns an <see cref="IPEndPoint">IPEndPoint</see> from a specific hostname and port.
        /// </summary>
        /// <param name="hostName">Hostname to trace.</param>
        /// <param name="port">Port to add to the <see cref="IPEndPoint">IPEndPoints</see>.</param>
        /// <param name="throwIfMoreThanOneIp">Throw exception, if hostname returns more then one IP adress.</param>
        /// <returns>IPEndPoint.</returns>
        public static IPEndPoint GetIpEndPointFromHostName(string hostName, int port, bool throwIfMoreThanOneIp) {
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);
            if (addresses.Length == 0) {
                throw new ArgumentException(
                    "Unable to retrieve address from specified host name.",
                    nameof(hostName)
                    );
            }
            if (throwIfMoreThanOneIp && addresses.Length > 1) {
                throw new ArgumentException(
                    "There is more that one IP address to the specified host.",
                    nameof(hostName)
                    );
            }
            return new IPEndPoint(addresses[0], port); // Port gets validated here.
        }
    }
}