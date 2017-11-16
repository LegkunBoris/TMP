using System;
using System.Text;

namespace Module7
{
	public static class CustomerFormater
	{
		public static string ToString(this Customer str, string param)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < param.Length; i++)
			{
				char tmp = 'c';
				switch (tmp)
				{
					case 'n':
						sb.Append(string.Format("{0}", str.Name));
					break;
						
					case 'p':
						sb.Append(string.Format("{0}", str.ContactPhone));
					break;
						
					case 'r':
						sb.Append(string.Format("{0}", str.Revenue));
					break;
				}
				if (i != param.Length)
					sb.Append(", ");
			}
			return sb.ToString();
		}
	}
}
