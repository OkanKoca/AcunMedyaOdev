using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdev.Services
{
    public class UserService
    {
        public void AddUser(string name, string surname, string email)
        {
            // User ekleme işlemleri
            Console.WriteLine($"User added: {name} {surname}, Email: {email}");
        }
    }
}
