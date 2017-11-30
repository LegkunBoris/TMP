using System;
using System.Globalization;
using System.Text;

namespace Module7
{
	public class Customer : IFormattable
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
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.InvariantCulture);
		}
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (string.IsNullOrEmpty(format)) format = "NPC";
			if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < format.Length; i++)
			{
				switch (format[i])
				{
					case 'N':
						sb.Append(string.Format("{0}", Name));
						break;

					case 'P':
						sb.Append(string.Format("{0}", ContactPhone));
						break;

					case 'R':
						sb.Append(string.Format(formatProvider, "{0:###,###.00}", Revenue));
						break;
					default:
						continue;
				}
				if (i != format.Length - 1)
					sb.Append(", ");
			}
			return sb.ToString();
		}
	}
}
