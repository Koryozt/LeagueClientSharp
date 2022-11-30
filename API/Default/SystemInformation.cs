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
	public class SystemInformation : Base, ISystemInformation
	{
		public async Task<HttpResponseMessage> GetArtifactsInformation()
		{
			return await Request.Execute(HttpMethods.GET, "system/v1/builds");
		}

		public async Task<HttpResponseMessage> GetControlProcessInformation()
		{
			return await Request.Execute(HttpMethods.GET, "process-control/v1/process");
		}

		public async Task<HttpResponseMessage> GetCookies()
		{
			return await Request.Execute(HttpMethods.GET, "cookie-jar/v1/cookies");
		}

		public async Task<HttpResponseMessage> GetCrashStatus()
		{
			return await Request.Execute(HttpMethods.GET, "crash-reporting/v1/crash-status");
		}

		public async Task<HttpResponseMessage> GetInstallDirectory()
		{
			return await Request.Execute(HttpMethods.GET, "data-store/v1/install-dir");
		}

		public async Task<HttpResponseMessage> GetInstallSettings(string path)
		{
			return await Request.Execute(HttpMethods.GET, "data-store/v1/install-settings", queryParameters: "path=" + path);
		}

		public async Task<HttpResponseMessage> GetProcessMemoryStatus()
		{
			return await Request.Execute(HttpMethods.GET, "performance/v1/memory");
		}

		public async Task<HttpResponseMessage> GetSystemInformation()
		{
			return await Request.Execute(HttpMethods.GET, "performance/v1/system-info");
		}

		public async Task<HttpResponseMessage> IsFrontendProcessReady()
		{
			return await Request.Execute(HttpMethods.POST, "memory/v1/fe-process-ready");
		}

		public async Task<HttpResponseMessage> NotifyFrontendProcess()
		{
			return await Request.Execute(HttpMethods.POST, "memory/v1/notify-fe-process-ready");
		}

		public async Task<HttpResponseMessage> Quit()
		{
			return await Request.Execute(HttpMethods.POST, "process-control/v1/process/quit");
		}

		public async Task<HttpResponseMessage> Restart(int delaySeconds, string? restartVersion = null)
		{
			string data = JsonSerializer.Serialize(new
			{
				delaySeconds = delaySeconds,
				restartVersion = restartVersion
			});

			return await Request.Execute(HttpMethods.POST, "process-control/v1/process/restart", data);
		}

		public async Task<HttpResponseMessage> RestartToRepair()
		{
			return await Request.Execute(HttpMethods.POST, "process-control/v1/process/restart-to-repair");
		}

		public async Task<HttpResponseMessage> SetCookies(Cookie cookie)
		{
			string data = JsonSerializer.Serialize(new
			{
				domain = cookie.Domain,
				expires = cookie.Expires,
				httponly = cookie.HttpOnly,
				name = cookie.Name,
				path = cookie.Path,
				secure = cookie.Secure,
				url = cookie.Url,
				value = cookie.Value
			});

			return await Request.Execute(HttpMethods.GET, "cookie-jar/v1/cookies", data);
		}

		public async Task<HttpResponseMessage> SetInstallSettings(string path)
		{
			return await Request.Execute(HttpMethods.POST, "data-store/v1/install-settings", queryParameters: "path=" + path);
		}

		public async Task<HttpResponseMessage> Snapshot()
		{
			return await Request.Execute(HttpMethods.POST, "memory/v1/snapshot");
		}
	}
}
