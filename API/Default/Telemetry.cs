using LOL.CLI.API.Default.Interfaces;
using LOL.CLI.API.Models;
using LOL.CLI.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOL.CLI.API.Default
{
	public class Telemetry : Base, ITelemetry
	{
		public async Task<HttpResponseMessage> AddCommonDataKey(string key)
		{
			return await Request.Execute(HttpMethods.POST, "telemetry/v1/common-data", queryParameters: "key=" + key);
		}

		public async Task<HttpResponseMessage> AddEvent(string eventType)
		{
			return await Request.Execute(HttpMethods.POST, "telemetry/v1/events", queryParameters: "eventType=" + eventType);
		}

		public async Task<HttpResponseMessage> AddToEventsOnce(string eventType, string onceTag)
		{
			string data = JsonSerializer.Serialize(new
			{
				onceTag = onceTag
			});

			return await Request.Execute(HttpMethods.POST, "telemetry/v3/events-once", data, "eventType=" + eventType);
		}

		public async Task<HttpResponseMessage> AddToEventsWithPerfomanceInformation(string eventType)
		{
			return await Request.Execute(HttpMethods.POST, "telemetry/v3/events-with-perf-info", queryParameters: "eventType=" + eventType);
		}

		public async Task<HttpResponseMessage> GetApplicationStartTime()
		{
			return await Request.Execute(HttpMethods.GET, "telemetry/v1/application-start-time");
		}
	}
}