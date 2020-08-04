using Is_True;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TrueCheck()
        {
            Assert.IsTrue(TruthDetector.IsTrue(true));
        }

        [TestMethod]
        public void FalseCheck()
        {
            Assert.IsFalse(TruthDetector.IsTrue(false));
        }
    }
}
