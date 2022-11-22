using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Default.Interfaces
{
	internal interface ILeagueClientUpdatedDefault
	{
		Task<HttpResponseMessage> GetAllBufferedLogEntries();
		Task<HttpResponseMessage> GetAllMetrics();
		Task<HttpResponseMessage> GetAllMetricsMetadata();
		Task<HttpResponseMessage> GetMemoryPool();
		Task<HttpResponseMessage> StartLogging();
		Task<HttpResponseMessage> StopLogging();
	}
}
