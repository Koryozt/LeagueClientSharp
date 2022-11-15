using LOL.CLI.Connection;
using System.Diagnostics;
using System.Text;

namespace LeagueOfLegends.CommandLineInterface
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			Request request = new Request();

			IEnumerable<string> endpoints = new string[]
			{
				"lol-summoner",
				"v1",
				"current-summoner",
				"icon"
			};

			KeyValuePair<string, string> data = new KeyValuePair<string, string>("profileIconId", "23");
			HttpResponseMessage response = await request.Execute(HttpMethods.PUT, endpoints, data);
		}
	}
}