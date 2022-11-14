using LOL.CLI.Connection;
using System.Diagnostics;

namespace LeagueOfLegends.CommandLineInterface
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			string pro = await Setup.Start();
			Console.WriteLine(pro);


		}
	}
}