using System;
namespace Module7
{
	public class NameAndPhone : IFormat
	{
		public string Format(Customer customer)
		{
			return string.Format("{0}, {1}", customer.Name, customer.ContactPhone);
		}
	}
}
