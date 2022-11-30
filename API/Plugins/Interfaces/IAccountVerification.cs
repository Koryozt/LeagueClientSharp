using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.CLI.API.Plugins.Interfaces
{
	public interface IAccountVerification
	{
		Task<HttpResponseMessage> Authenticate(string username, string password);
		Task<HttpResponseMessage> GetAccountVerificationDevice();
		Task<HttpResponseMessage> Invalidate();
		Task<HttpResponseMessage> IsVerified();
		Task<HttpResponseMessage> SendToken(string device, string locale, string mediator);
		Task<HttpResponseMessage> Verify(string token, string mediator);
	}
}
