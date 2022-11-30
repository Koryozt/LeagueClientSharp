using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface ICareerStats
	{
		Task<HttpResponseMessage> GetSeasonChampionAverages(string season, int championId, string position, string tier, string queue);
		Task<HttpResponseMessage> GetChampionAverages(int championId, string position, string tier, string queue);
		Task<HttpResponseMessage> GetChampionExperts(string season, int championId, string position);
		Task<HttpResponseMessage> GetChampionExperts(int championId, string position);
		Task<HttpResponseMessage> AddChampionStatsPercentiles(int championId, string position, string queue, string tier, int season);
		Task<HttpResponseMessage> GetPositionAverages(string season, string position, string tier, string queue);
		Task<HttpResponseMessage> GetPositionAverages(string position, string tier, string queue);
		Task<HttpResponseMessage> GetPositionExperts(string position);
		Task<HttpResponseMessage> GetPositionExperts(string position, string season);
		Task<HttpResponseMessage> AddPositionStatsPercentiles(string position, string queue, string tier, int season);
		Task<HttpResponseMessage> GetSummonerGames(string puuid);
		Task<HttpResponseMessage> GetSummonerGames(string puuid, string season);
		Task<HttpResponseMessage> GetSummonerGames(string puuid, string season, string queue, string position);
	}
}
