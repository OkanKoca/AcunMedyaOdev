using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    [Serializable]
    public class Employee
    {
        public string Name;
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
