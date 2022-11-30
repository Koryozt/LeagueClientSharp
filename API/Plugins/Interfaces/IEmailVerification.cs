using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IEmailVerification
	{
		Task<HttpResponseMessage> ConfirmEmail();
		Task<HttpResponseMessage> GetEmail();
		Task<HttpResponseMessage> ModifyEmail(string email, string password);
	}
}
