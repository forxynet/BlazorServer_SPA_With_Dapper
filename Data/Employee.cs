﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer_SPA_With_Dapper.Data {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public string CityId { get; set; }
    }
}
