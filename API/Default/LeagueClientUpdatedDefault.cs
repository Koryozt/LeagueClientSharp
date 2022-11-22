using LOL.CLI.API.Default.Interfaces;
using LOL.CLI.API.Models;
using LOL.CLI.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Default
{
	public class LeagueClientUpdatedDefault : Base, ILeagueClientUpdatedDefault
	{
		public async Task<HttpResponseMessage> GetAllBufferedLogEntries()
		{
			return await Request.Execute(HttpMethods.POST, "LoggingGetEntries");
		}

		public async Task<HttpResponseMessage> GetAllMetrics()
		{
			return await Request.Execute(HttpMethods.POST, "LoggingMetrics");
		}

		public async Task<HttpResponseMessage> GetAllMetricsMetadata()
		{
			return await Request.Execute(HttpMethods.POST, "LoggingMetricsMetadata");
		}

		public async Task<HttpResponseMessage> GetMemoryPool()
		{
			return await Request.Execute(HttpMethods.POST, "MemoryPools");
		}

		public async Task<HttpResponseMessage> StartLogging()
		{
			return await Request.Execute(HttpMethods.POST, "LoggingStart");
		}

		public async Task<HttpResponseMessage> StopLogging()
		{
			return await Request.Execute(HttpMethods.POST, "LoggingStop");
		}
	}
}
