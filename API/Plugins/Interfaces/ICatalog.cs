using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface ICatalog
	{
		Task<HttpResponseMessage> ItemDetails();
		Task<HttpResponseMessage> Items();
		Task<HttpResponseMessage> Items(string inventoryType);
	}
}
