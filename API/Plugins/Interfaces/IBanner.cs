using LOL.CLI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IBanner
	{
		Task<HttpResponseMessage> GetSummonerFlags();
		Task<HttpResponseMessage> GetEquipedSummonerFlag();
		Task<HttpResponseMessage> ModifyEquipedSummonerFlag(Flag flag);
		Task<HttpResponseMessage> GetEquipedFrame();
		Task<HttpResponseMessage> GetEquipedFrame(string puuid);

	}
}
