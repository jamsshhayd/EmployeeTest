using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTest.Models
{
    public class EmployeeResponseModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<EmployeeModel> Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}