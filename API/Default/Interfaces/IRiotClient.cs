namespace LOL.CLI.API.Default.Interfaces
{
	public interface IRiotClient
	{
		public Task<HttpResponseMessage> GetAffinity();
		public Task<HttpResponseMessage> DeleteAffinity();
		public Task<HttpResponseMessage> SetAffinity();
		public Task<HttpResponseMessage> GetAppName();
		public Task<HttpResponseMessage> GetAppPort();
		public Task<HttpResponseMessage> GetAuthToken();
		public Task<HttpResponseMessage> GetCommandLineArguments();
		public Task<HttpResponseMessage> GetRegionLocale();
		public Task<HttpResponseMessage> KillAndRestartUX();
		public Task<HttpResponseMessage> KillUX();
		public Task<HttpResponseMessage> LaunchUX();
		public Task<HttpResponseMessage> MachineID();
		public Task<HttpResponseMessage> NewArgs();
		public Task<HttpResponseMessage> EditRegionLocale(string locale, string region, string webLanguage, string webRegion);
		public Task<HttpResponseMessage> SetRegionLocale();
		public Task<HttpResponseMessage> ShowSwagger();
		public Task<HttpResponseMessage> HideSplashScreen();
		public Task<HttpResponseMessage> ShowSplashScreen();
		public Task<HttpResponseMessage> GetSystemInformation();
		public Task<HttpResponseMessage> Trace();
		public Task<HttpResponseMessage> UnloadUX();
		public Task<HttpResponseMessage> AllowUXForeground();
		public Task<HttpResponseMessage> IsUXCrashed();
		public Task<HttpResponseMessage> FlashUX();
		public Task<HttpResponseMessage> UXState();
		public Task<HttpResponseMessage> ShowUX();
		public Task<HttpResponseMessage> HideUX();
		public Task<HttpResponseMessage> UnregisterAuthToken(string authToken);
		public Task<HttpResponseMessage> RegisterAuthToken(string authToken);
		public Task<HttpResponseMessage> GetCrashReportingEnvironmentID();
		public Task<HttpResponseMessage> IdentifyCrashWithEnvironment(string environment, string userId, string userName);
		public Task<HttpResponseMessage> CrashReportingLogs(string log);
		public Task<HttpResponseMessage> ElevationRequest(string action);
		public Task<HttpResponseMessage> SelfUpdateInformation();
		public Task<HttpResponseMessage> GetZoomScale();
		public Task<HttpResponseMessage> HandleZoomScale();
	}
}