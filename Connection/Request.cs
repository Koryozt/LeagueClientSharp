using LOL.CLI.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;

namespace League_of_Legends___Command_Line_Interface.Connection
{
	public class Request
	{
		private string _url = "https://127.0.0.1:";
		private HttpClient _httpClient;
		private HttpClientHandler _httpClientHandler;

		public Request()
		{
			_httpClientHandler = new()
			{
				ClientCertificateOptions = ClientCertificateOption.Manual
			};

			_httpClientHandler.ServerCertificateCustomValidationCallback = (response, cert, chain, errors) => true;
		}

		private async Task CreateClient()
		{
			string password = await Setup.GetPassword();

			using (HttpClient client = new HttpClient(_httpClientHandler))
			{
				client.DefaultRequestHeaders.Add("Authorization", password);
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			}
		}
	}
}
