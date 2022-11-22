using LOL.CLI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOL.CLI.API.BuiltIn
{
	public class HttpSockets : Base, IHttpSockets
	{
		public async Task<HttpResponseMessage> Cancel(string token)
		{
			string data = JsonSerializer.Serialize(new { asyncToken = token });
			return await Request.Execute(HttpMethods.POST, "Cancel");
		}

		public async Task<HttpResponseMessage> Close()
		{
			return await Request.Execute(HttpMethods.POST, "Close"); 
		}

		public Task<HttpResponseMessage> Help(string target, string format)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> HttpDelete(string token)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> HttpResult(string token)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> HttpStatus(string token)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SocketsDelete(string token)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SocketsResult(string token)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SocketsStatus(string token)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> Subscribe(string eventName, string format)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SwaggerV1()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SwaggerV1(string api)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SwaggerV2()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> SwaggerV3()
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> Unsuscribe(string eventName)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> WebSocketFormat(string? format = null)
		{
			throw new NotImplementedException();
		}
	}
}
