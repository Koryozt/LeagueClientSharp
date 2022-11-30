using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IEndOfGame
	{
		Task<HttpResponseMessage> GetChampionMasteryUpdates();
		Task<HttpResponseMessage> GetEndOfGameStatsBlock();
		Task<HttpResponseMessage> GetGameClientEndOfGameStatsBlock();
		Task<HttpResponseMessage> SendGameClientEndOfGameStatsBlock(int gameId, string gamemode, bool isRanked, int queueId, string queueType, params string[] additionalProps);
		Task<HttpResponseMessage> GetReportedPlayers();
		Task<HttpResponseMessage> DimissStats();
		Task<HttpResponseMessage> GetTFTEndOfGameStats();
		Task<HttpResponseMessage> ReportPlayer(string comment, int gameId, IEnumerable<string> offenses, int reportedSummonerId);
	}
}
