using LOL.CLI.API.Default.Interfaces;
using LOL.CLI.API.Models;
using LOL.CLI.Connection;
using Newtonsoft.Json.Linq;
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
			return await Request.Execute(HttpMethods.POST, "riotclient/ux-allow-foreground");
		}

		public async Task<HttpResponseMessage> GetAppName()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/app-name");
		}

		public async Task<HttpResponseMessage> GetAppPort()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/app-port");
		}

		public async Task<HttpResponseMessage> GetAuthToken()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/auth-token");
		}

		public async Task<HttpResponseMessage> GetCommandLineArguments()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/command-line-args");
		}

		public async Task<HttpResponseMessage> CrashReportingLogs(string log)
		{
			string data = JsonSerializer.Serialize(new { log = log });

			return await Request.Execute(HttpMethods.POST, "riotclient/v1/crash-reporting/logs", data);
		}

		public async Task<HttpResponseMessage> DeleteAffinity()
		{
			return await Request.Execute(HttpMethods.DELETE, "riotclient/affinity");
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

			return await Request.Execute(HttpMethods.PUT, "riotclient/region-locale", data);
		}

		public async Task<HttpResponseMessage> ElevationRequest(string action)
		{
			string data = JsonSerializer.Serialize(new { action = action });

			return await Request.Execute(HttpMethods.POST, "riotclient/v1/elevation-request", data);
		}

		public async Task<HttpResponseMessage> FlashUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/ux-flash");
		}

		public async Task<HttpResponseMessage> GetAffinity()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/affinity");
		}

		public async Task<HttpResponseMessage> GetCrashReportingEnvironmentID()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/v1/crash-reporting/environment");
		}

		public async Task<HttpResponseMessage> GetRegionLocale()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/region-locale");
		}

		public async Task<HttpResponseMessage> GetSystemInformation()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/system-info/v1/basic-info");
		}

		public async Task<HttpResponseMessage> GetZoomScale()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/zoom-scale");
		}

		public async Task<HttpResponseMessage> HandleZoomScale(string value)
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/zoom-scale", "newZoomScale=" + value);
		}

		public async Task<HttpResponseMessage> HideSplashScreen()
		{
			return await Request.Execute(HttpMethods.DELETE, "riotclient/splash");
		}

		public async Task<HttpResponseMessage> HideUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/ux-minimize");
		}

		public async Task<HttpResponseMessage> IdentifyCrashWithEnvironment(string environment, string userId, string userName)
		{
			string data = JsonSerializer.Serialize(new
			{
				environment = environment,
				userId = userId,
				userName = userName
			});

			return await Request.Execute(HttpMethods.POST, "riotclient/v1/crash-reporting/environment", data);
		}

		public async Task<bool> IsUXCrashed()
		{
			HttpResponseMessage response = await Request.Execute(HttpMethods.GET, "riotclient/ux-crash-count");

			string content = await response.Content.ReadAsStringAsync();
			int value = JObject.Parse(content).ToObject<int>();
			return value == 1; 
		}

		public async Task<HttpResponseMessage> KillAndRestartUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/kill-and-restart-ux");
		}

		public async Task<HttpResponseMessage> KillUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/kill-ux");
		}

		public async Task<HttpResponseMessage> LaunchUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/launch-ux");
		}

		public async Task<HttpResponseMessage> MachineID()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/machine-id");
		}


		public async Task<HttpResponseMessage> RegisterAuthToken(string authToken)
		{
			return await Request.Execute(HttpMethods.PUT, "riotclient/v1/auth-tokens", queryParameters: "authToken="  + authToken);
		}

		public async Task<HttpResponseMessage> SelfUpdateInformation(string url, string uuid)
		{
			string data = JsonSerializer.Serialize
				(
					new
					{
						url = url,
						uuid = uuid
					}
				);

			return await Request.Execute(HttpMethods.PUT, "riotclient/v1/self-update-info", data);
;		}

		public async Task<HttpResponseMessage> SetAffinity(string newAffinity)
		{
			string data = JsonSerializer.Serialize
				(
					new
					{
						newAffinity = newAffinity
					}
				);

			return await Request.Execute(HttpMethods.POST, "riotclient/affinity", data);
		}

		public async Task<HttpResponseMessage> SetRegionLocale(string region, string locale)
		{
			string data = JsonSerializer.Serialize
				(
					new
					{
						region = region,
						locale = locale
					}
				);

			return await Request.Execute(HttpMethods.POST, "riotclient/set-region-locale", data);
		}

		public async Task<HttpResponseMessage> ShowSplashScreen(string splash)
		{
			string data = JsonSerializer.Serialize
				(
					new
					{
						splash = splash
					}
				);

			return await Request.Execute(HttpMethods.PUT, "riotclient/splash");
		}

		public async Task<HttpResponseMessage> ShowSwagger()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/show-swagger");
		}

		public async Task<HttpResponseMessage> ShowUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/ux-show");
		}

		public async Task<HttpResponseMessage> Trace()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/trace");
		}

		public async Task<HttpResponseMessage> UnloadUX()
		{
			return await Request.Execute(HttpMethods.POST, "riotclient/unload");
		}

		public async Task<HttpResponseMessage> UnregisterAuthToken(string authToken)
		{
			return await Request.Execute(HttpMethods.DELETE, "riotclient/v1/auth-tokens", queryParameters: "authToken=" + authToken);
		}

		public async Task<HttpResponseMessage> UXState()
		{
			return await Request.Execute(HttpMethods.GET, "riotclient/ux-state");
		}
	}
}
