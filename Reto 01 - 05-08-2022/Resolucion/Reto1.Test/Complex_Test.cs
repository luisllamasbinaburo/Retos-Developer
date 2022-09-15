using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reto1;
using System;

namespace Reto1.Test
{
	[TestClass]
	public class Complex_Test
	{
		public Complex_Test()
		{
		}

		[TestMethod]
		public void One_End_Less_Number_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 4, 5, 6, 7, 2 }));
		}

		[TestMethod]
		public void One_First_Less_Number_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 5, 6, 7, 8 }));
		}

		[TestMethod]
		public void One_Mid_Less_Number_Should_BeOk()
		{
			Assert.IsTrue(Reto1.IsValid_O_n(new int[] { 1, 7, 8, 4, 9 }));
		}

		[TestMethod]
		public void One_Mid_Less_Number_Should_Fail()
		{
			Assert.IsFalse(Reto1.IsValid_O_n(new int[] { 1, 7, 8, 4, 8 }));
		}
	}
}