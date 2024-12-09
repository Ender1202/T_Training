using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnAPIUsingEF.Entities
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get;set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }

    }
}