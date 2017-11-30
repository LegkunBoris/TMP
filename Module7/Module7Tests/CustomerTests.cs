using NUnit.Framework;
using System;
using Module7;
namespace Module7Tests
{
	[TestFixture()]
	public class Test
	{
		[TestCase("Boris Legkun", "+7 (951) 647-02-88", "10000000,45", "Boris Legkun, 10,000,000.45, +7 (951) 647-02-88")]
		public void Customer_FullFormatTest(string name, string phone, string revenue, string expected)
		{
			#region Arrange
			Customer customer = new Customer(name, phone, Convert.ToDecimal(revenue));
			#endregion

			#region Act
			var actual = customer.ToString("NRP");
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
		[TestCase("Boris Legkun", "+7 (951) 647-02-88", "10000000,45", "Boris Legkun")]
		public void Customer_NameOnlyTest(string name, string phone, string revenue, string expected)
		{
			#region Arrange
			Customer customer = new Customer(name, phone, Convert.ToDecimal(revenue));
			#endregion

			#region Act
			var actual = customer.ToString("N");
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
		[TestCase("Boris Legkun", "+7 (951) 647-02-88", "10000000,45", "+7 (951) 647-02-88, 10,000,000.45")]
		public void Customer_PhoneAndRevenueOnlyTest(string name, string phone, string revenue, string expected)
		{
			#region Arrange
			Customer customer = new Customer(name, phone, Convert.ToDecimal(revenue));
			#endregion

			#region Act
			var actual = customer.ToString("PR");
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
		[TestCase("Boris Legkun", "+7 (951) 647-02-88", "10000000,45", "Boris Legkun, +7 (951) 647-02-88")]
		public void Customer_NameAndPhoneOnlyTest(string name, string phone, string revenue, string expected)
		{
			#region Arrange
			Customer customer = new Customer(name, phone, Convert.ToDecimal(revenue));
			#endregion

			#region Act
			var actual = customer.ToString("NP");
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
		[TestCase("Boris Legkun", "+7 (951) 647-02-88", "10000000,45", "10,000,000.45")]
		public void Customer_RevenueOnlyTest(string name, string phone, string revenue, string expected)
		{
			#region Arrange
			Customer customer = new Customer(name, phone, Convert.ToDecimal(revenue));
			#endregion

			#region Act
			var actual = customer.ToString("R");
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
		[TestCase("Boris Legkun", "+7 (951) 647-02-88", "10000000,45", "+7 (951) 647-02-88")]
		public void Customer_PhoneOnlyTest(string name, string phone, string revenue, string expected)
		{
			#region Arrange
			Customer customer = new Customer(name, phone, Convert.ToDecimal(revenue));
			#endregion

			#region Act
			var actual = customer.ToString("P");
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
		[TestCase(null, "+7 (951) 647-02-88", 1000000)]
		[TestCase("Bosov Leonid", null, 1000000)]
		[TestCase("Bosov Leonid", "+7 (951) 647-02-88", -1000)]
		public void Customer_TestNulls(string name, string phone, decimal revenue)
		{
			#region Arrange
			#endregion

			#region Act
			#endregion

			#region Assert
			Assert.Throws<ArgumentException>(() => new Customer(name, phone, revenue));
			#endregion
		}
	}
}
