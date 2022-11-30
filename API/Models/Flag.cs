using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Models
{
	public class Flag
	{
		public DateOnly? EarnedDate { get; set; }
		public int? ItemID { get; set; }
		public int? Level { get; set; }
		public int? SeasonID { get; set; }
		public string? Theme { get; set; }
	}
}
