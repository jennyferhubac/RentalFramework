using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFormApplication.entities
{
    public class User : AUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Roles { get; set; }
    }
}
