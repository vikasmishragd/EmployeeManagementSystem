using Employee.Core;
using log4net;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Employee.Opertions
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private static readonly string apiBasicUri = "https://gorest.co.in";
		private static readonly string url = "/public-api/users";

		public async Task<T> GetAllEmployees<T>(SearchContext searchContext)
		{
			string completeUrl = string.Empty;
			if (!string.IsNullOrEmpty(searchContext.EmpName))
			{
				completeUrl = $"{apiBasicUri}{url}?name={searchContext.EmpName};page={searchContext.page}";
			}
			else
			{
				completeUrl = $"{apiBasicUri}{url}?page={searchContext.page}";
			}
			return GetEmployees<T>(completeUrl);
		}

		private static T GetEmployees<T>(string completeUrl)
		{
			T resultContent = JsonConvert.DeserializeObject<T>("");
			WebRequest request = (HttpWebRequest)WebRequest.Create(completeUrl);

			request.Headers.Add("Authorization", "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
			request.Method = "GET";
			request.Timeout = 100000;
			request.ContentType = "application/json";

			using (System.IO.Stream s = request.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					var jsonResponse = sr.ReadToEnd();
					resultContent = JsonConvert.DeserializeObject<T>(jsonResponse);
				}
			}
			return resultContent;
		}

		public async Task<T> GetEmployee<T>(string url)
		{
			return GetEmployees<T>(url);
		}

		public async Task<string> Post<T>(T contentValue)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(apiBasicUri);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
			client.DefaultRequestHeaders.Add("Authorization", "Bearer " + "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
			var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
			var response = await client.PostAsync(url, content);
			var result = response.Content.ReadAsStringAsync().Result;
			var str = response.Headers.Location;
			return str==null?string.Empty:str.ToString();
		}
	}
}
