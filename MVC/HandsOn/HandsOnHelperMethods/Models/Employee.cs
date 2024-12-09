using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HandsOnHelperMethods.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string Designation { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        public int Salary { get; set; }

    }
}