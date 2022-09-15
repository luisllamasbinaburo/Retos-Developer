using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reto2_Tests.Validator_On_Tests
{
    [TestClass]
    public class RandomTests
    {
        [TestMethod]
        public void Single_0_Test()
        {
            var input = new int[] { 0 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(1, rst);
        }

        [TestMethod]
        public void Single_1_Test()
        {
            var input = new int[] { 1 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(1, rst);
        }

        [TestMethod]
        public void Sequence_01_Test()
        {
            var input = new int[] { 0, 1 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(3, rst);
        }

        [TestMethod]
        public void Sequence_10_Test()
        {
            var input = new int[] { 1, 0 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(3, rst);
        }

        [TestMethod]
        public void Sequence_00_Test()
        {
            var input = new int[] { 0, 0 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(2, rst);
        }


        [TestMethod]
        public void Sequence_100_Test()
        {
            var input = new int[] { 1, 0, 0 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(4, rst);
        }

        [TestMethod]
        public void Sequence_1001_Test()
        {
            var input = new int[] { 1, 0, 0, 1 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(8, rst);
        }

        [TestMethod]
        public void Sequence_11111_Test()
        {
            var input = new int[] { 1, 1, 1, 1, 1 };
            var validator = new Reto2.Validator_On();

            var rst = validator.CountCollapsableSubarrays(input);
            Assert.AreEqual(5, rst);
        }
    }
}
