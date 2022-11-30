using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface ICollectionInventory
	{
		Task<HttpResponseMessage> GetChestElegibility();
		Task<HttpResponseMessage> GetChampionMasteryScore();
		Task<HttpResponseMessage> GetScouting();
		Task<HttpResponseMessage> GetBackdrop(int summonerId);
		Task<HttpResponseMessage> GetChampionMastery(int summonerId);
		Task<HttpResponseMessage> GetTopChampionMastery(int summonerId);
		Task<HttpResponseMessage> GetSpells(int summonerId);
		Task<HttpResponseMessage> GetWardSkins(int summonerId);
		Task<HttpResponseMessage> GetWardSkin(int summonerId, int wardSkinId);

	}
}
