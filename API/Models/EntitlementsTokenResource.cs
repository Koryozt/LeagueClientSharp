using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Models
{
	public struct EntitlementsTokenResource
	{
		public string? AccessToken { get; set; }
		public IEnumerable<string>? Entitlements { get; set; }
		public string? Issuer { get; set; }
		public string? Subject { get; set; }
		public string? Token { get; set; }
	}
}
