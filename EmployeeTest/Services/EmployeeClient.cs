using EmployeeTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeTest.Services
{
    public class EmployeeClient
    {
        public async Task<EmployeeResponseModel> GetAllEmployees()
        {
            var url = "http://dummy.restapiexample.com/api/v1/employees";
            return JsonConvert.DeserializeObject<EmployeeResponseModel>(await MakeRequest(url));
        }

        protected async Task<string> MakeRequest(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Date = DateTime.UtcNow;
            request.Accept = "application/json";
            using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return await reader.ReadToEndAsync();
                }
            }
        }
    }
}