using System;
using System.Text;

namespace Module7
{
	public static class Url
	{
		public static string AddOrChangeUrlParameter(string url, string key)
		{
			var tmp = key.Split('=');
			if (tmp.Length != 2)
				throw new ArgumentException();

			StringBuilder sb = new StringBuilder();

			var dupe = url;

			var localkey = tmp[0];
			var localvalue = tmp[1];

			if (!url.Contains("?"))
				return sb.Append(url + '?' + key).ToString();

			if (!url.Contains(localkey))
				return sb.Append(url + key).ToString();
			else {
				var index = url.IndexOf(localkey) + localkey.Length + 1;
				StringBuilder sbtmp = new StringBuilder();

				while (url[index] != '&' || url.Length != index)
					sbtmp.Append(url[index++]);

				dupe.Replace(sbtmp.ToString(), localvalue);
				return dupe;
			}
		}
	}
}
