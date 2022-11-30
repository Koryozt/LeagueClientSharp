using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface ICosmetics
	{
		Task<HttpResponseMessage> GetCompanions(string setName);
		Task<HttpResponseMessage> GetDamageSkins(string setName);
		Task<HttpResponseMessage> GetMapSkins(string setName);
	}
}
