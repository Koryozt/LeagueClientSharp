﻿using LOL.CLI.Connection;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace LOL.CLI.Connection
{
	public enum HttpMethods
	{
		GET,
		POST,
		PUT,
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
			StringContent data,
			params string[] queryParameters)
		{
			string url = URL.Make(endpoints, queryParameters);

			switch(httpMethod)
			{
				case HttpMethods.GET:
					return await Get(url);

				case HttpMethods.POST:
					return await Post(url, data);

				case HttpMethods.PUT:
					return await Put(url, data);

				case HttpMethods.DELETE:
					return await Delete(url);

				default:
					return null!;
			}
		}

		// TODO: Make custom exceptions.

		private async Task<HttpResponseMessage> Get(string url)
		{
			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				response.EnsureSuccessStatusCode();

				return response;
			}
			catch (Exception)
			{

				throw;
			}

		}

		private async Task<HttpResponseMessage> Post(string url, StringContent data)
		{
			try
			{
				HttpResponseMessage response = await _httpClient.PostAsync(url, data);

				response.EnsureSuccessStatusCode();

				return response;
			}
			catch (Exception)
			{

				throw;
			}
		}

		private async Task<HttpResponseMessage> Put(string url, StringContent data)
		{
			try
			{
				HttpResponseMessage response = await _httpClient.PutAsync(url, data);

				response.EnsureSuccessStatusCode();

				return response;
			}
			catch (Exception)
			{

				throw;
			}
		}

		private async Task<HttpResponseMessage> Delete(string url)
		{
			try
			{
				HttpResponseMessage response = await _httpClient.DeleteAsync(url);

				response.EnsureSuccessStatusCode();

				return response;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
