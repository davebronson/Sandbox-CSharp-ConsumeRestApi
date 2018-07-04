using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Provides static helper methods to help in calling a REST web service.
	/// </summary>
	public static class RestServiceHelper
	{
		private static readonly HttpClient client;

		/// <summary>
		/// Initializes the <see cref="T:SandboxCSharpConsumeRestApi.RestServiceHelper"/> class.
		/// </summary>
		static RestServiceHelper()
		{
			client = new HttpClient();
		}

		/// <summary>
		/// Returns a Newtonsoft JArray object representation of the JSON result of a REST web service call, given the service's URL.
		/// </summary>
		/// <returns>A Newtonsoft JArray object representation of the JSON response received from the REST web service.</returns>
		/// <param name="url">The URL to retrieve a response from.</param>
		public static async Task<JArray> GetResponseAsObject(string url)
		{
			// Get the service response
			string response = await client.GetStringAsync(url);

			// If the request was successful...
			return (JArray)JsonConvert.DeserializeObject(response);
		}
	}
}
