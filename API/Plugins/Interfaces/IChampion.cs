using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IChampion
	{
		Task<HttpResponseMessage> GetChampions(int summonerId);
		Task<HttpResponseMessage> GetChampionsMinimal(int summonerId);
		Task<HttpResponseMessage> GetPlayableChampionsCount(int summonerId);
		Task<HttpResponseMessage> GetChampion(int summonerId, int championId);
		Task<HttpResponseMessage> GetChampionSkins(int summonerId, int championId);
		Task<HttpResponseMessage> GetChampionSkin(int summonerId, int championId, int skinId);
		Task<HttpResponseMessage> GetChampionSkinChromas(int summonerId, int championId, int skinId);
		Task<HttpResponseMessage> GetSkinsMinimal(int summonerId);
		Task<HttpResponseMessage> GetOwnedChampionsMinimal(int summonerId);
	}
}
