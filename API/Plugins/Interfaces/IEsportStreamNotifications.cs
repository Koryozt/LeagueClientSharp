using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IEsportStreamNotifications
	{
		Task<HttpResponseMessage> GetLiveStreams();
		Task<HttpResponseMessage> SendStats(string eventType, string matchId);
		Task<HttpResponseMessage> GetStreamURL();	
	}
}
