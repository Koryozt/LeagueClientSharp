using League_of_Legends___Command_Line_Interface.Connection;
using LOL.CLI.Connection;
using System.Diagnostics;
using System.Text;

namespace LeagueOfLegends.CommandLineInterface
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine(Setup.Port);
			Console.WriteLine(Setup.GetPassword());
		}
	}
}