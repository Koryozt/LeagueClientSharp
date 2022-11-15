using LOL.CLI.Connection;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace LOL.CLI.Connection
{
	public enum HttpMethods
	{
		GET,
		POST,
		PUT,
		PATCH,
		DELETE
	}

	public class Request
	{
		private HttpClient _httpClient;
		private readonly HttpClientHandler _httpClientHandler;

		#pragma warning disable
		public Request()
		{
			_httpClientHandler = new()
			{
				ClientCertificateOptions = ClientCertificateOption.Manual
			};

			_httpClientHandler.ServerCertificateCustomValidationCallback = (response, cert, chain, errors) => true;

			CreateClient();

		}
		#pragma warning enable

		private void CreateClient()
		{
			string password = Setup.GetEncodedPassword();

			_httpClient = new HttpClient(_httpClientHandler);
			_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", password);
			_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			
		}

		public async Task<HttpResponseMessage> Execute(HttpMethods httpMethod, 
			IEnumerable<string> endpoints,
			KeyValuePair<string, string> data,
			params string[] queryParameters)
		{
			try
			{
				switch(httpMethod)
				{
					case HttpMethods.GET:

						string getUrl = URL.Make(endpoints, queryParameters);
						HttpResponseMessage getResponse = await _httpClient.GetAsync(getUrl);
						getResponse.EnsureSuccessStatusCode();

						return getResponse;

						break;

					case HttpMethods.POST:

						string postUrl = URL.Make(endpoints, queryParameters);

						FormUrlEncodedContent postContent = new FormUrlEncodedContent(new[] { data });
						HttpResponseMessage postResponse = await _httpClient.PostAsync(postUrl, postContent);

						postResponse.EnsureSuccessStatusCode();

						return postResponse;

						break;

					case HttpMethods.PUT:

						string putUrl = URL.Make(endpoints, queryParameters);

						FormUrlEncodedContent putContent = new FormUrlEncodedContent(new[] { data });
						Console.WriteLine(putUrl);
						Console.WriteLine(await putContent.ReadAsStringAsync());
						HttpResponseMessage putResponse = await _httpClient.PutAsync(putUrl, putContent);

						putResponse.EnsureSuccessStatusCode();

						return putResponse;
						break;

					default:
						return null!;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}
