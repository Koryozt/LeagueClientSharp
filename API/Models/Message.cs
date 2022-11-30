using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Models
{
	public class Message
	{
		public string Body { get; set; } = string.Empty;
		public string FromId { get; set; } = string.Empty;
		public string FromPid { get; set; } = string.Empty;
		public int FromSummonerId { get; set; }
		public string Id { get; set; } = string.Empty;
		public bool IsHistorical { get; set; }
		public DateTime TimeStamp { get; set; }
		public string Type { get; set; } = string.Empty;
	}
}
