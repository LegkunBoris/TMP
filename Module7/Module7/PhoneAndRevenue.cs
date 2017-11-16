using System;
using System.Globalization;

namespace Module7
{
	public class PhoneAndRevenue : IFormat
	{
		public string Format(Customer customer)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}, {1:###,###.00}", customer.ContactPhone, customer.Revenue);
		}
	}
}
