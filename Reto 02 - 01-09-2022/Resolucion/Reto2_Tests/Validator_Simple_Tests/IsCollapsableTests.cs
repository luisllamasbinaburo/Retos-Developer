using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reto2_Tests.Validator_Simple_Tests
{
    [TestClass]
    public class IsCollapsableTests
    {
        [TestMethod]
        public void Single_0_Should_Be_True()
        {
            var input = new int[] { 0 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsTrue(rst);
        }

        [TestMethod]
        public void Single_1_Should_Be_True()
        {
            var input = new int[] { 1 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsTrue(rst);
        }

        [TestMethod]
        public void Sequence_01_Should_Be_True()
        {
            var input = new int[] { 0, 1 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsTrue(rst);
        }

        [TestMethod]
        public void Sequence_10_Should_Be_True()
        {
            var input = new int[] { 1, 0 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsTrue(rst);
        }

        [TestMethod]
        public void Sequence_00_Should_Be_False()
        {
            var input = new int[] { 0, 0 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsFalse(rst);
        }


        [TestMethod]
        public void Sequence_001_Should_Be_True()
        {
            var input = new int[] { 0, 0, 1 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsTrue(rst);
        }

        [TestMethod]
        public void Sequence_011_Should_Be_False()
        {
            var input = new int[] { 0, 1, 1 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsFalse(rst);
        }

        [TestMethod]
        public void Sequence_1001_Should_Be_True()
        {
            var input = new int[] { 1, 0, 0, 1 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsTrue(rst);
        }

        [TestMethod]
        public void Sequence_1011_Should_Be_False()
        {
            var input = new int[] { 1, 0, 1, 1 };
            var validator = new Reto2.Validator_Simple();

            var rst = validator.IsCollapsable(input);
            Assert.IsFalse(rst);
        }
    }
}
