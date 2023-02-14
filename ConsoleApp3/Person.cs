using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        public string Surname;
        public string Name;
        public string Middle_name;
        public string Year_of_birth;


        public Person(string name, string surname, string middle, string year)
        {
            this.Surname = surname;
            this.Name = name;
            this.Middle_name = middle;
            this.Year_of_birth = year;
        }
    }
}
