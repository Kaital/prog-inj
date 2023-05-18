using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public enum Period { 
        Day, Week, Month, Quarter, HalfYear, Year
    }
    public class Plan
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public Period  period { get; set; }
    }
}
