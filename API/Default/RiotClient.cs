using LOL.CLI.API.Default.Interfaces;
using LOL.CLI.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOL.CLI.API.Default
{
	public class RiotClient : Base, IRiotClient
	{
		public async Task<HttpResponseMessage> AllowUXForeground()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"ux-allow-foreground"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> GetAppName()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"app-name"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> GetAppPort()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"app-port"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> GetAuthToken()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"auth-token"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> GetCommandLineArguments()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"command-line-args"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> CrashReportingLogs(string log)
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"v1",
				"crash-reporting",
				"logs"
			};


			return await Request.Execute(HttpMethods.POST, endpoints, log);
		}

		public async Task<HttpResponseMessage> DeleteAffinity()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"affinity"
			};

			return await Request.Execute(HttpMethods.DELETE, endpoints);
		}

		public async Task<HttpResponseMessage> EditRegionLocale(string locale, string region, string webLanguage, string webRegion)
		{
			string data = JsonSerializer.Serialize(new
			{
				locale = locale,
				region = region,
				webLanguage = webLanguage,
				webRegion = webRegion
			});

			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"region-locale"
			};

			return await Request.Execute(HttpMethods.PUT, endpoints, data);
		}

		public async Task<HttpResponseMessage> ElevationRequest(string action)
		{
			string data = JsonSerializer.Serialize(new { action = action });

			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"v1",
				"elevation-request"
			};

			return await Request.Execute(HttpMethods.POST, endpoints, data);
		}

		public async Task<HttpResponseMessage> FlashUX()
		{
			IEnumerable<string> endppoints = new string[]
			{
				"riotclient",
				"ux-flash"
			};

			return await Request.Execute(HttpMethods.POST, endppoints);
		}

		public Task<HttpResponseMessage> GetAffinity()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> GetCrashReportingEnvironmentID()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> GetRegionLocale()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> GetSystemInformation()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> GetZoomScale()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> HandleZoomScale()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> HideSplashScreen()
		{
			throw new NotImplementedException();
		}

		public async Task<HttpResponseMessage> HideUX()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"ux-minimize"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> IdentifyCrashWithEnvironment(string environment, string userId, string userName)
		{
			string data = JsonSerializer.Serialize(new
			{
				environment = environment,
				userId = userId,
				userName = userName
			});

			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"v1",
				"crash-reporting",
				"environment"
			};

			return await Request.Execute(HttpMethods.POST, endpoints, data);
		}

		public Task<HttpResponseMessage> IsUXCrashed()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> KillAndRestartUX()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> KillUX()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> LaunchUX()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> MachineID()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> NewArgs()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> RegisterAuthToken(string authToken)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SelfUpdateInformation()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SetAffinity()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SetRegionLocale()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> ShowSplashScreen()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> ShowSwagger()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> ShowUX()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> Trace()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> UnloadUX()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> UnregisterAuthToken(string authToken)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> UXState()
		{
			throw new NotImplementedException();
		}
	}
}
