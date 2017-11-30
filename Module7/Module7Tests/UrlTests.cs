using System;
using Module7;
using NUnit.Framework;
namespace Module7Tests
{
	[TestFixture]
	public class UrlTests
	{
		[TestCase("www.example.com","key=value","www.example.com?key=value")]
		public void Url_Insert(string url, string keyAndValue,string expected)
		{
			#region Arrange
			#endregion

			#region Act
			var actual = Url.AddOrChangeUrlParameter(url, keyAndValue);
			#endregion

			#region Assert
			Assert.AreEqual(expected, actual);
			#endregion
		}
	}
}
