using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reto2_Tests.Validator_Simple_Tests
{
    [TestClass]
    public class CollapseTests
    {
        [TestMethod]
        public void SingleCollapse()
        {
            var input = new int[] { 0, 1, 0, 0 };
            var output = new int[] { 0, 0, 0 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.TryCollapse(1, input);
            CollectionAssert.AreEqual(output, rst);
        }

        [TestMethod]
        public void OnLevel_Collapse()
        {
            var input = new int[] { 0, 1, 0, 0 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.Collapse(input);
            Assert.AreEqual(2, rst.Count);
            CollectionAssert.AreEqual(new int[] { 1, 0, 0 }, rst[0]);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0 }, rst[1]);
        }
    }
}
