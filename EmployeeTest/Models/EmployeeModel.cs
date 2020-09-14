using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTest.Models
{
    public class EmployeeModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; }

        [JsonProperty("employee_salary")]
        public long EmployeeSalary { get; set; }

        [JsonProperty("employee_age")]
        public long EmployeeAge { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }
    }
}