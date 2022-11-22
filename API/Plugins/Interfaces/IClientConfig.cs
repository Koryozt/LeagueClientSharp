using LOL.CLI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IClientConfig
	{
		Task<HttpResponseMessage> GetClientConfiguration();
		Task<HttpResponseMessage> GetClientConfiguration(string name);
		Task<HttpResponseMessage> TokenEntitlements(EntitlementsTokenResource entitlements, string createType);
		Task<HttpResponseMessage> RefreshConfigStatus();
		Task<HttpResponseMessage> GetStatus(string type);
		Task<HttpResponseMessage> GetConfiguration(string name);
		Task<HttpResponseMessage> NamespacesChanges(IEnumerable<string> player, IEnumerable<string> @public);
		Task<HttpResponseMessage> GetNamespaceByName(string name);
		Task<HttpResponseMessage> GetPlayerNamespace(string name);
		Task<HttpResponseMessage> GetPublicNamespace(string name);

	}
}
