using System;
namespace Module7
{
	public class ContactPhone : IFormat
	{
		public string Format(Customer customer)
		{
			return string.Format("{0}", customer.ContactPhone);
		}
	}
}
