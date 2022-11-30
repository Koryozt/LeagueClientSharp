using LOL.CLI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IChat
	{
		Task<HttpResponseMessage> GetBlockedPlayers();
		Task<HttpResponseMessage> BlockPlayer(string gameName, string gameTag, int icon, string id, string name, string pid, string puuid, int summonerId);
		Task<HttpResponseMessage> RemoveBlockedPlayer(int id);
		Task<HttpResponseMessage> GetBlockedPlayer(int id);
		Task<HttpResponseMessage> GetConfiguration();
		Task<HttpResponseMessage> GetConversations();
		Task<HttpResponseMessage> CreateConversation(string gameName, string gameTag, string id, string inviterId, bool isMuted, Message message, string name, string password, string targetRegion, string type, int unreadMessageCount);
		Task<HttpResponseMessage> DeleteActiveConversation(int id);
		Task<HttpResponseMessage> GetActiveConversation(int id);
		Task<HttpResponseMessage> ChangeActiveConversation(int id);
		Task<HttpResponseMessage> GetConversationNotification();
		Task<HttpResponseMessage> DeleteConversation(int id);
		Task<HttpResponseMessage> GetConversation(int id);
		Task<HttpResponseMessage> ModifyConversation(int pathId, string gameName, string gameTag, string id, string inviterId, bool isMuted, Message message, string name, string password, string targetRegion, string type, int unreadMessageCount);
		Task<HttpResponseMessage> CloseConversation(int id);
		Task<HttpResponseMessage> GetConversationMessages();
		Task<HttpResponseMessage> DeleteConversationMessages(int id);
		Task<HttpResponseMessage> AddMessage(int id, Message message);
		Task<HttpResponseMessage> GetConversationParticipants(int id);
		Task<HttpResponseMessage> GetErrors();
		Task<HttpResponseMessage> DeleteErrors(int id);
		Task<HttpResponseMessage> GetFriendsCount();
		Task<HttpResponseMessage> FriendExists(string summonerId);
		Task<HttpResponseMessage> GetFriendsGroups();
		Task<HttpResponseMessage> GetFriendsGroup(int id);
		Task<HttpResponseMessage> CreateFriendsGroup(bool collapsed, int id, bool isLocalized, bool isMetaGroup, string name, int priority);
		Task<HttpResponseMessage> UpdateFriendsGroup(bool? collapsed, int? id, bool? isLocalized, bool? isMetaGroup, string? name, int? priority);
		Task<HttpResponseMessage> DeleteFriendsGroup(int id);
		Task<HttpResponseMessage> GetFriendsInFriendsGroup(int id);
		Task<HttpResponseMessage> GetFriendsRequest();
		Task<HttpResponseMessage> MakeFriendRequest(string direction, string gameName, string gameTag, int iconId, string id, string name, string note, string pid, string puuid, int summonerId);
		Task<HttpResponseMessage> DeleteFriendRequest(int id);
		Task<HttpResponseMessage> GetFriendRequest(int id);
		Task<HttpResponseMessage> GetFriends();
		Task<HttpResponseMessage> DeleteFriend(int id);
		Task<HttpResponseMessage> GetFriend(int id);
		Task<HttpResponseMessage> GetMe();
		Task<HttpResponseMessage> GetResources();
		Task<HttpResponseMessage> DeleteSession();
		Task<HttpResponseMessage> GetSession();
		Task<HttpResponseMessage> PlainSession(string username, string password);
		Task<HttpResponseMessage> RSOSession(int expiry, IEnumerable<string> scopes, string token);
		Task<HttpResponseMessage> GetSettings();
	}
}
