using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace LOL.CLI.Connection
{
	public class URL
	{
		private static string BaseURL { get => $"https://127.0.0.1:{Setup.Port}/"; }
		private static readonly StringBuilder _stringBuilder = new StringBuilder(BaseURL);

		public static string Make(string endpoint, params string[] queryParameters)
		{
			_stringBuilder.Append(endpoint);

			if (queryParameters.Count() > 1)
			{
				string extension = AddQueryParameters(queryParameters);
				_stringBuilder.Append(extension);
			}

			return _stringBuilder.ToString();
		}

		private static string AddQueryParameters(IEnumerable<string> queryParameters)
		{
			queryParameters = queryParameters.Where(s => !string.IsNullOrEmpty(s));

			string query = "?" + string.Join("&", queryParameters);

			return HttpUtility.UrlEncode(query);
		}
	}
}
