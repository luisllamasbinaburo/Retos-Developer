using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Linq;

namespace Reto2_Tests.Validator_Random_Tests
{
    [TestClass]
    public class RandomTests
    {
        [TestMethod]
        public void First_100k_Integers_Test()
        {
            var isValid = true;
            var validator_Simple = new Reto2.Validator_Simple();
            var valiadator_On = new Reto2.Validator_On();

            for (int i = 0; i < 100000; i++)
            {
                int[] input = IntegerToBitArray(i);

                var groundTruth = validator_Simple.CountCollapsableSubarrays(input);
                var rst = valiadator_On.CountCollapsableSubarrays(input);
                if (groundTruth != rst) isValid = false;

            }
            Assert.AreEqual(true, isValid);
        }

        private int[] IntegerToBitArray(int i)
        {
            var bitArray = new BitArray(new int[] { i });
            bool[] bits = new bool[bitArray.Length];
            bitArray.CopyTo(bits, 0);

            var size = (int)Math.Ceiling(Math.Log2(i));
            int[] output= bits.Take(size).Select(bit => bit ? 1 : 0).ToArray();
            return output;
        }

        [TestMethod]
        public void Random_1000x_Sample_Size1000_Test()
        {
            var isValid = true;
            var validator_Simple = new Reto2.Validator_Simple();
            var valiadator_On = new Reto2.Validator_On();

            for (int i = 0; i < 1000; i++)
            {
                var input = GenerateSample(1000);
                var groundTruth = validator_Simple.CountCollapsableSubarrays(input);
                var rst = valiadator_On.CountCollapsableSubarrays(input);
                if (groundTruth != rst) isValid = false;

            }
            Assert.AreEqual(true, isValid);
        }

        private int[] GenerateSample(int length)
        {
            var random = new Random();
            var sample = Enumerable.Range(0, length).Select(x => random.Next(2)).ToArray();

            return sample;
        }
    }
}

