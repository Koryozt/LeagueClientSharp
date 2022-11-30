using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IGameClientChat
	{
		Task<HttpResponseMessage> GetBuddies();
		Task<HttpResponseMessage> GetIgnoredSummoners();
		Task<HttpResponseMessage> InstantMessage(string summonerName, string message);
		Task<HttpResponseMessage> GetMutedSummoners();
		Task<HttpResponseMessage> PartyMessage(string message);
	}
}
