using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.Connection
{
	public static class Setup
	{
		private static string Terminal
		{
			get
			{
				return Environment.OSVersion.Platform is PlatformID.Win32NT ?
					"cmd.exe" : "open";
			}
		}
		private static string Argument
		{
			get
			{
				if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Other)
					return "ps -A | grep LeagueClientUx";

				return "wmic PROCESS WHERE name='LeagueClientUx.exe' GET commandline";
			}
		}

		public static async Task<string> Start()
		{
			ProcessStartInfo process = new ProcessStartInfo();
			process.FileName = Terminal;
			process.Arguments = Argument;
			process.UseShellExecute = false;
			process.RedirectStandardOutput = true;

			// To do: Make exception if client is not open.

			using (Process terminal = Process.Start(process)!)
			{
				using (StreamReader reader = terminal.StandardOutput)
				{
					string result = await reader.ReadToEndAsync();
					return result;
				}
			}
		}
	}
}
