using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IContentTargeting
	{
		Task<HttpResponseMessage> GetFilters();
		Task<HttpResponseMessage> GetLocale();
		Task<HttpResponseMessage> GetProtectedFilters();

	}
}
