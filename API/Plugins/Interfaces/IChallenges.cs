using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IChallenges
	{
		Task<HttpResponseMessage> GetAvailableQueuesIdentifiers();
		Task<HttpResponseMessage> GetLocalPlayer(string product);
		Task<HttpResponseMessage> GetLevelPoints();
		Task<HttpResponseMessage> MyUpdatedChallenges(string gameId);
		Task<HttpResponseMessage> AddProcessGame(string gameId, string product);
		Task<HttpResponseMessage> GetSuggestedChallenges(string product);
		Task<HttpResponseMessage> GetSummaryPlayerData(string product);
		Task<HttpResponseMessage> GetSummaryPlayerData(string product, string puuid);
		Task<HttpResponseMessage> GetSummaryPlayersData(string product);
		Task<HttpResponseMessage> GetTitles();
		Task<HttpResponseMessage> GetUpdatedChallenge(string gameId, string puuid);
	}
}
