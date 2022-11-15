using LOL.CLI.Connection;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace LeagueOfLegends.CommandLineInterface
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			Request request = new Request();

			string content = JsonSerializer.Serialize(new
			{
				profileIconId = 23
			});

			using StringContent data = new StringContent(content, Encoding.UTF8, "application/json");

			IEnumerable<string> endpoints = new string[]
			{
				"lol-summoner",
				"v1",
				"current-summoner",
				"icon"
			};

			HttpResponseMessage response = await request.Execute(HttpMethods.PUT, endpoints, data);
		}
	}
}