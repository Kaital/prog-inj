using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class Production
    {
        public int Id { get; set; }
        public Brand brand { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string Explanatory { get; set; }
    }
}
