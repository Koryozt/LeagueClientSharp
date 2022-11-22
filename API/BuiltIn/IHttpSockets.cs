namespace LOL.CLI.API.BuiltIn
{
	public interface IHttpSockets
	{
		Task<HttpResponseMessage> SocketsDelete(string token);
		Task<HttpResponseMessage> SocketsResult(string token);
		Task<HttpResponseMessage> SocketsStatus(string token);
		Task<HttpResponseMessage> Cancel(string token);
		Task<HttpResponseMessage> Help(string target, string format);
		Task<HttpResponseMessage> Close();
		Task<HttpResponseMessage> Subscribe(string eventName, string format);
		Task<HttpResponseMessage> Unsuscribe(string eventName);
		Task<HttpResponseMessage> WebSocketFormat(string? format = null);
		Task<HttpResponseMessage> HttpResult(string token);
		Task<HttpResponseMessage> HttpDelete(string token);
		Task<HttpResponseMessage> HttpStatus(string token);
		Task<HttpResponseMessage> SwaggerV1();
		Task<HttpResponseMessage> SwaggerV1(string api);
		Task<HttpResponseMessage> SwaggerV2();
		Task<HttpResponseMessage> SwaggerV3();
	}
}