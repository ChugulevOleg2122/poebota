using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Compitition
    {
        public string Name;
        public string Date;
        public string Stages;

        public Compitition(string name, string date, string stages)
        {
            this.Name = name;
            this.Date = date;
            this.Stages = stages;
        }
    }
}
