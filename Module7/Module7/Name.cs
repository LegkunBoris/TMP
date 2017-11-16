using System;
namespace Module7
{
	public class Name : IFormat
	{
		public string Format(Customer customer)
		{
			return string.Format("{0}", customer.Name);
		}
	}
}
