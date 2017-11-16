using System;
using System.Globalization;

namespace Module7
{
	public class FullFormat : IFormat
	{
		public string Format(Customer customer)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}, {1:###,###.00}, {2}",customer.Name, customer.Revenue, customer.ContactPhone);
		}
	}
}
