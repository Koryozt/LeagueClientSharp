using LOL.CLI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Default.Interfaces
{
	public interface ISystemInformation
	{
		Task<HttpResponseMessage> GetArtifactsInformation();
		Task<HttpResponseMessage> GetCookies();
		Task<HttpResponseMessage> SetCookies(Cookie cookie);
		Task<HttpResponseMessage> GetCrashStatus();
		Task<HttpResponseMessage> GetInstallDirectory();
		Task<HttpResponseMessage> GetInstallSettings(string path);
		Task<HttpResponseMessage> SetInstallSettings(string path);
		Task<HttpResponseMessage> IsFrontendProcessReady();
		Task<HttpResponseMessage> NotifyFrontendProcess();
		Task<HttpResponseMessage> Snapshot();
		Task<HttpResponseMessage> GetProcessMemoryStatus();
		Task<HttpResponseMessage> GetSystemInformation();
		Task<HttpResponseMessage> GetControlProcessInformation();
		Task<HttpResponseMessage> Quit();
		Task<HttpResponseMessage> Restart(int delaySeconds, string? restartVersion = null);
		Task<HttpResponseMessage> RestartToRepair();

	}
}
