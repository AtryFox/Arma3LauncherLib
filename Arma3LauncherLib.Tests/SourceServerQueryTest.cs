using System.Net;
using DerAtrox.Arma3LauncherLib.SSQLib;
using DerAtrox.Arma3LauncherLib.SSQLib.Exceptions;
using NUnit.Framework;

namespace DerAtrox.Arma3LauncherLib.Tests {
    [TestFixture]
    public class SourceServerQueryTest {
        [Test]
        public void TestFakePlayerServerThrowsExceptionWithIpEndpoint() {
            Assert.Throws(typeof(SourceServerException), () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                query.Players(new IPEndPoint(IPAddress.Parse("127.0.0.2"), 2303));
            });
        }

        [Test]
        public void TestFakePlayerServerThrowsExceptionWithStringIp() {
            Assert.Throws(typeof(SourceServerException), () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                query.Players("127.0.0.2", 2303);
            });
        }

        [Test]
        public void TestFakeServerThrowsExceptionWithIpEndpoint() {
            Assert.Throws(typeof(SourceServerException), () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                query.Server(new IPEndPoint(IPAddress.Parse("127.0.0.2"), 2303));
            });
        }

        [Test]
        public void TestFakeServerThrowsExceptionWithStringIp() {
            Assert.Throws(typeof(SourceServerException), () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                query.Server("127.0.0.2", 2303);
            });
        }

    }
}
