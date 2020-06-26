using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer_SPA_With_Dapper.Data {
    public class EmployeeModel : Employee {
        public string CityName { get; set; }
    }
}
