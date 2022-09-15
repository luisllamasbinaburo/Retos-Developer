using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reto1;
using System;

namespace Reto1.Test
{
	[TestClass]
	public class Basic_Tests
	{
		public Basic_Tests()
		{
		}

		[TestMethod]
		public void One_Numbers_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1 }));
		}

		[TestMethod]
		public void Three_Decreasing_Numbers_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 3, 2, 1 }));
		}

		[TestMethod]
		public void Three_Equals_Numbers_Shoud_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 1, 1, 1 }));
		}

		[TestMethod]
		public void Three_Increasing_Numbers_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 3 }));
		}

		[TestMethod]
		public void Two_Decreasing_Numbers_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 2, 1 }));
		}

		[TestMethod]
		public void Two_Increasing_Numbers_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2 }));
		}
	}
}