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
		private const string _portPattern = @"(?=\d[0-9]{4,5})\w+";
		private const string _tokenPattern = @"(remoting-auth-token=(?<password>.*?(?=""\s)))";

        static Setup()
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = Terminal;
            process.Arguments = Argument;
            process.UseShellExecute = false;
            process.RedirectStandardOutput = true;
            // To do: Make exception if client is not open.

            using (Process terminal = Process.Start(process)!)
			{
                string output = terminal.StandardOutput.ReadToEnd();
                Port = new Regex(portPattern, RegexOptions.Compiled).Match(output).Groups[0].Value;
                Password = new Regex(tokenPattern, RegexOptions.Compiled).Match(output).Groups["password"].Value;
            }
        }

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

        private string Password
        {
            get;
            set;
        }

        public static string Port
        {
            get;
            private set;
        }

		public static string GetEncodedPassword() =>
            "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"riot:{Password}"));
	}
}
