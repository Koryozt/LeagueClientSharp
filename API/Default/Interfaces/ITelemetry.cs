using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Default.Interfaces
{
	public interface ITelemetry
	{
		Task<HttpResponseMessage> GetApplicationStartTime();
		Task<HttpResponseMessage> AddCommonDataKey(string key);
		Task<HttpResponseMessage> AddEvent(string eventType);
		Task<HttpResponseMessage> AddToEventsOnce(string eventType, string onceTag);
		Task<HttpResponseMessage> AddToEventsWithPerfomanceInformation(string eventType);
	}
}
