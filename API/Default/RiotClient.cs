using LOL.CLI.API.Default.Interfaces;
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

			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> GetAppPort()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"app-port"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
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

		public async Task<HttpResponseMessage> GetAffinity()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"affinity"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> GetCrashReportingEnvironmentID()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"v1",
				"crash-reporting",
				"environment"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> GetRegionLocale()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"region-locale"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> GetSystemInformation()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"system-info",
				"v1",
				"basic-info"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> GetZoomScale()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"zoom-scale"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> HandleZoomScale(string value)
		{
			string[] endpoints = new[]
			{
				"riotclient",
				"zoom-scale"
			},
			queryParameters = new[]
			{
				"newZoomScale=" + value
			};

			return await Request.Execute(HttpMethods.GET, endpoints, queryParameters: queryParameters);
		}

		public async Task<HttpResponseMessage> HideSplashScreen()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"splash"
			};

			return await Request.Execute(HttpMethods.DELETE, endpoints);
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

		public async Task<bool> IsUXCrashed()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"ux-crash-count"
			};

			HttpResponseMessage response = await Request.Execute(HttpMethods.GET, endpoints);

			string content = await response.Content.ReadAsStringAsync();
			int value = JObject.Parse(content).ToObject<int>();
			return value == 1; 
		}

		public async Task<HttpResponseMessage> KillAndRestartUX()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"kill-and-restart-ux"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> KillUX()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"kill-ux"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> LaunchUX()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"launch-ux"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> MachineID()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"machine-id"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}


		public async Task<HttpResponseMessage> RegisterAuthToken(string authToken)
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"v1",
				"auth-tokens"
			};

			return await Request.Execute(HttpMethods.PUT, endpoints, queryParameters: authToken);
		}

		public async Task<HttpResponseMessage> SelfUpdateInformation(string url, string uuid)
		{
			IEnumerable<string> endpoints = new []
				{
					"riotclient",
					"v1",
					"self-update-info"
				};

			string data = JsonSerializer.Serialize
				(
					new
					{
						url = url,
						uuid = uuid
					}
				);

			return await Request.Execute(HttpMethods.PUT, endpoints, data);
;		}

		public async Task<HttpResponseMessage> SetAffinity(string newAffinity)
		{
			IEnumerable<string> endpoints = new[]
			{
				"riotclient",
				"affinity"
			};

			string data = JsonSerializer.Serialize
				(
					new
					{
						newAffinity = newAffinity
					}
				);

			return await Request.Execute(HttpMethods.POST, endpoints, data);
		}

		public async Task<HttpResponseMessage> SetRegionLocale(string region, string locale)
		{
			IEnumerable<string> endpoints = new[]
			{
				"riotclient",
				"set-region-locale"
			};

			string data = JsonSerializer.Serialize
				(
					new
					{
						region = region,
						locale = locale
					}
				);

			return await Request.Execute(HttpMethods.POST, endpoints, data);
		}

		public async Task<HttpResponseMessage> ShowSplashScreen(string splash)
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"splash"
			};

			string data = JsonSerializer.Serialize
				(
					new
					{
						splash = splash
					}
				);

			return await Request.Execute(HttpMethods.PUT, endpoints);
		}

		public async Task<HttpResponseMessage> ShowSwagger()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"show-swagger"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> ShowUX()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"ux-show"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> Trace()
		{
			IEnumerable<string> endpoints = new string[] { "riotclient", "trace" };
			return await Request.Execute(HttpMethods.GET, endpoints);
		}

		public async Task<HttpResponseMessage> UnloadUX()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"unload"
			};

			return await Request.Execute(HttpMethods.POST, endpoints);
		}

		public async Task<HttpResponseMessage> UnregisterAuthToken(string authToken)
		{
			string[] endpoints = new[]
			{
				"riotclient",
				"v1",
				"auth-tokens"
			},
			queryParameters = new[]
			{
				"authToken=" + authToken
			};

			return await Request.Execute(HttpMethods.DELETE, endpoints);
		}

		public async Task<HttpResponseMessage> UXState()
		{
			IEnumerable<string> endpoints = new string[]
			{
				"riotclient",
				"ux-state"
			};

			return await Request.Execute(HttpMethods.GET, endpoints);
		}
	}
}
