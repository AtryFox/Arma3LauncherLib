using System.Net;
using DerAtrox.Arma3LauncherLib.SSQLib;
using DerAtrox.Arma3LauncherLib.SSQLib.Exceptions;
using NUnit.Framework;

namespace DerAtrox.Arma3LauncherLib.Tests {
    [TestFixture]
    public class SourceServerQueryTest {
        [Test]
        public void TestFakePlayerServerThrowsExceptionWithIpEndpoint() {
            Assert.ThrowsAsync(typeof(SourceServerException), async () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                await query.Players(new IPEndPoint(IPAddress.Parse("127.0.0.2"), 2303));
            });
        }

        [Test]
        public void TestFakePlayerServerThrowsExceptionWithStringIp() {
            Assert.ThrowsAsync(typeof(SourceServerException), async () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                await query.Players("127.0.0.2", 2303);
            });
        }

        [Test]
        public void TestFakeServerThrowsExceptionWithIpEndpoint() {
            Assert.ThrowsAsync(typeof(SourceServerException), async () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                await query.Server(new IPEndPoint(IPAddress.Parse("127.0.0.2"), 2303));
            });
        }

        [Test]
        public void TestFakeServerThrowsExceptionWithStringIp() {
            Assert.ThrowsAsync(typeof(SourceServerException), async () => {
                SourceServerQuery query = new SourceServerQuery();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                await query.Server("127.0.0.2", 2303);
            });
        }

    }
}
