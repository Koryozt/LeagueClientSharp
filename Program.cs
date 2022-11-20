using LOL.CLI.API.Default;
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
			RiotClient client = new();

			await client.ShowSwagger();
		}
	}
}