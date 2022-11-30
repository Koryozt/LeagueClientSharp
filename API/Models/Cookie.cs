using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Models
{
	public class Cookie
	{
		public string? Domain { get; set; }
		public int? Expires { get; set; }
		public bool? HttpOnly { get; set; }
		public string? Name { get; set; }
		public string? Path { get; set; }
		public bool? Secure { get; set; }
		public string? Url { get; set; }
		public string? Value { get; set; }

	}
}
