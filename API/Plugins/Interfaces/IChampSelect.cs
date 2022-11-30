using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IChampSelect
	{
		Task<HttpResponseMessage> GetAllGridChampions();
		Task<HttpResponseMessage> GetBannableChampionIdentifiers();
		Task<HttpResponseMessage> LaunchBattleTraining();
		Task<HttpResponseMessage> GetCurrentChampion();
		Task<HttpResponseMessage> GetDisabledChampionIdentifiers();
		Task<HttpResponseMessage> GetChampionGrid(int championId);
		Task<HttpResponseMessage> GetMutedPlayers();
		Task<HttpResponseMessage> GetOngoingTrade();
		Task<HttpResponseMessage> ClearOngoingTrade(string id);
		Task<HttpResponseMessage> GetPickableChampionIdentifiers();
		Task<HttpResponseMessage> GetPickableSkinIdentifiers();
		Task<HttpResponseMessage> GetPinDropNotification();
		Task<HttpResponseMessage> RetrieveLastGameDTO();
		Task<HttpResponseMessage> GetSession();
		Task<HttpResponseMessage> UpdateSessionAction(string id, int actorCellId, int championId, bool completed, bool isAllyAction, string type);
		Task<HttpResponseMessage> CompleteSessionAction(string id);
		Task<HttpResponseMessage> SwapBench(int chanmpionId);
		Task<HttpResponseMessage> ModifyMySelection(int selectedSkinId, int firstSpellId, int secondSpellId, int wardSkinId);
		Task<HttpResponseMessage> Reroll();
		Task<HttpResponseMessage> SimpleInventory();
		Task<HttpResponseMessage> GetTimer();
		Task<HttpResponseMessage> GetTrades();
		Task<HttpResponseMessage> GetTrades(int id);
		Task<HttpResponseMessage> AccepdTrade(int id);
		Task<HttpResponseMessage> CancelTrade(int id);
		Task<HttpResponseMessage> DeclineTrade(int id);
		Task<HttpResponseMessage> RequestTrade(int id);
		Task<HttpResponseMessage> GetSFXNotifications();
		Task<HttpResponseMessage> GetSkinCarouselSkins();
		Task<HttpResponseMessage> GetSlot(string slotId);
		Task<HttpResponseMessage> GetTeamBoost();
		Task<HttpResponseMessage> PurchaseTeamBoost();
		Task<HttpResponseMessage> ToggleFavorites(int championId, string position);
		Task<HttpResponseMessage> TogglePlayerMuted(string puuid, int summonerId);
	}
}
