using DerAtrox.Arma3LauncherLib.Utilities;
using NUnit.Framework;

namespace DerAtrox.Arma3LauncherLib.Tests {
    [TestFixture]
    public class UtilsTest {

        [Test]
        public void TestSerializeProfilename() {
            string serialized = ProfileUtils.SerializeProfilename("qweÖÜÄöüä");

            Assert.AreEqual(serialized, "qweÃÃÃÃ¶Ã¼Ã¤");
        }
    }
}
