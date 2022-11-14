using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LOL.CLI.Connection
{
	public static class Setup
	{
		private static string portPattern = "--app-port=([0-9])*";
		private static string tokenPattern = "--remoting-auth-token=([\\w-]*)";
		
		private static string Terminal
		{
			get
			{
				if (Environment.OSVersion.Platform is PlatformID.Unix)
					return "/System/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal";

				return "cmd.exe"; 
			}
		}
		private static string Argument
		{
			get
			{
				if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Other)
					return "-c ps -A | grep LeagueClientUx";

				return "/C wmic PROCESS WHERE name='LeagueClientUx.exe' GET commandline";
			}
		}

		private static async Task<string> Start()
		{
			ProcessStartInfo process = new ProcessStartInfo();
			process.FileName = Terminal;
			process.Arguments = Argument;
			process.UseShellExecute = false;
			process.RedirectStandardOutput = true;
			// To do: Make exception if client is not open.

			using (Process terminal = Process.Start(process)!)
			{
				return await terminal.StandardOutput.ReadToEndAsync();
			}
		}

		public static async Task<string> GetPort()
		{
			string content = await Start();
			string port = string.Empty;
			Regex regex = new Regex(portPattern);
			Match match = regex.Match(content);

			if (match.Success)
			{
				port = match.Groups[0].Value;
				port = port.Remove(0, port.IndexOf("=") + 1);
			}

			return port;

		}

		public static async Task<string> GetPassword()
		{
			string content = await Start();
			string token = string.Empty;

			Regex regex = new Regex(tokenPattern);
			Match match = regex.Match(content);

			if (match.Success)
			{
				token = match.Groups[0].Value;
				token = token.Remove(0, token.IndexOf("=") + 1);
			}

			string password = $"riot:{token}";

			return "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
		}
	}
}
