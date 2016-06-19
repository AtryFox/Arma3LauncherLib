using DerAtrox.Arma3LauncherLib.Utilities;
using NUnit.Framework;

namespace DerAtrox.Arma3LauncherLib.Tests {
    [TestFixture]
    public class UtilsTest {
        [Test]
        public void TestGetMd5StringHash() {
            Assert.AreEqual(GenericUtils.GetMd5StringHash("Hello, this is a simple test."), "d5e72c479d8b18ef8258cece54c459a3");
        }
    }
}
