using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public enum Position
    {
        Foreman, Manager, Admin, Booker
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Position position { get; set; }
    }
}
