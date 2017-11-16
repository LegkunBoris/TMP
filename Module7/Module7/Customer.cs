using System;
namespace Module7
{
	public class Customer
	{
		public readonly string Name;
		public string ContactPhone;
		public decimal Revenue;

		public Customer(string name, string phone, decimal revenue)
		{
			if (!string.IsNullOrEmpty(name))
				Name = name;
			else throw new ArgumentException("Name can not be NULL or empty!");

			if (!string.IsNullOrEmpty(phone))
				ContactPhone = phone;
			else throw new ArgumentException("Contact phone can not be NULL or empty!");

			if (!(revenue < 0))
				Revenue = revenue;
			else  throw new ArgumentException("Revenue can not be less then zero!");
		}
	}
}
