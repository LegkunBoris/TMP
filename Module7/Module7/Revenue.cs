using System.Globalization;
namespace Module7
{
	public class Revenue : IFormat
	{
		public string Format(Customer customer)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0:###,###.00}", customer.Revenue);
		}
	}
}
