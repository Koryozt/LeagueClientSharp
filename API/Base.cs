using LOL.CLI.API.Default.Models;
using LOL.CLI.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API
{
	public class Base
	{
		protected HttpRequest Request { get; } = new HttpRequest();
	}
}
