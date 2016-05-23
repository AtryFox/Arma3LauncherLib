using System;
using System.Net;

namespace DerAtrox.Arma3LauncherLib.SSQLib.Utilities {
    public class EndPointUtils {
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