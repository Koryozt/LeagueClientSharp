using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.Connection
{
	public class URL
	{
		private static string BaseURL { get => $"https://127.0.0.1:{Setup.Port}/"; }
		private static readonly StringBuilder _stringBuilder = new StringBuilder(BaseURL);

		public static string Make(IEnumerable<string> endpoints, params string[] queryParameters)
		{
			_stringBuilder.AppendJoin("/", endpoints);

			//if (queryParameters is not null)
			//{
			//	string extension = AddQueryParameters(queryParameters);
			//	_stringBuilder.Append(extension);
			//}

			return _stringBuilder.ToString();
		}

		private static string AddQueryParameters(IEnumerable<string> queryParameters)
		{
			queryParameters = queryParameters.Where(s => !string.IsNullOrEmpty(s));

			return "?" + string.Join("&", queryParameters);
		}
	}
}
