using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reto1;
using System;

namespace Reto1.Test
{
	[TestClass]
	public class Advanced_Tests
	{
		public Advanced_Tests()
		{
		}

		[TestMethod]
		public void OneGreater_Number_End_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 3, 4, 7 }));
		}

		[TestMethod]
		public void OneGreater_Number_First_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 7, 2, 3, 4, 5 }));
		}

		[TestMethod]
		public void OneGreater_Number_Mid_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 7, 4, 5 }));
		}

		[TestMethod]
		public void Two_Consecutive_DecreasingGreater_Number_End_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 3, 8, 7 }));
		}

		[TestMethod]
		public void Two_Consecutive_DecreasingGreater_Number_First_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 8, 7, 3, 4, 5 }));
		}

		[TestMethod]
		public void Two_Consecutive_DecreasingGreater_Number_Mid_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 1, 8, 7, 4, 5 }));
		}

		[TestMethod]
		public void Two_Consecutive_IncreasingGreater_Number_End_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 3, 7, 8 }));
		}

		[TestMethod]
		public void Two_Consecutive_IncreasingGreater_Number_First_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 7, 8, 3, 4, 5 }));
		}

		[TestMethod]
		public void Two_Consecutive_IncreasingGreater_Number_Mid_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 1, 7, 8, 4, 5 }));
		}

		[TestMethod]
		public void Two_Non_Consecutive_Decreasing_Greater_Number_End_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 8, 4, 7 }));
		}

		[TestMethod]
		public void Two_Non_Consecutive_Decreasing_Greater_Number_Mid_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 1, 8, 3, 7, 5 }));
		}

		[TestMethod]
		public void Two_Non_Consecutive_DecreasingGreater_Number_First_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 8, 2, 7, 4, 5 }));
		}

		[TestMethod]
		public void Two_Non_Consecutive_Increasing_Greater_Number_End_Position_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 2, 7, 4, 8 }));
		}

		[TestMethod]
		public void Two_Non_Consecutive_Increasing_Greater_Number_Mid_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 1, 7, 3, 8, 5 }));
		}

		[TestMethod]
		public void Two_Non_Consecutive_IncreasingGreater_Number_First_Position_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 7, 2, 8, 4, 5 }));
		}
	}
}