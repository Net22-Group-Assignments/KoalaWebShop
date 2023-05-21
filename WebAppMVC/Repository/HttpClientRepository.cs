namespace WebAppMVC.Repository
{
	public static class HttpClientRepository
	{
		private static readonly HttpClient client;

		static HttpClientRepository()
		{
			client = new HttpClient();
		}

		public static HttpClient GetHttpClient()
		{
			return client;
		}

		public static void CloseHttpClient()
		{
			client.Dispose();
		}
	}
}
