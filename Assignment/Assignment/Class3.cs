using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Current_User
    {
        string Name { get; set; }
        string Password { get; set; }
        string Phone_Number { get; set; }
        string Email { get; set; }
        string Role { get; set; }



        public Current_User(string name, string password, string phone_number, string email, string role)
        {
            this.Name = name;   
            this.Password = password;
            this.Phone_Number = phone_number;
            this.Email = email;
            this.Role = role;
        }
        



    }
}
