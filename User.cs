using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DSW_Semester_Project
{
    public class User
    {
        public string FullName;
        public string Email;
        public string Password;
        public string Role;

        public User(string fullName, string email, string password, string role)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Role = role;
        }
        public string Current_User(string fullName)
        {
           return FullName = fullName;
            
            
        }
       
    }
}