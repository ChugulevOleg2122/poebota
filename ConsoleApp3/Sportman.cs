using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Sportman : Person
    {
        int Height;
        int Weight;
        string Sport;

        static int namberSportman;

        public Sportman(string Surname, string Name, string Middle_name, string Year_of_birth,
             int height, int weight, string sport)
            : base(Surname, Name, Middle_name, Year_of_birth)
        {
            this.Height = height;
            this.Weight = weight;
            this.Sport = sport;
            

            namberSportman += 1;
           
        }

        public static int GetNamberSportman
        {
            get { return namberSportman; }
        }

        public string Passport()
        {
            return string.Format("ФИО: {0} {1} {2}\n" +
                                 "Дата рождения: {3}\n" +
                                 "Высота: {4}\n" +
                                 "Вес: {5}\n" +
                                 "Вид спорта: {6}\n",
                                 Surname, Name, Middle_name, Year_of_birth, Height, Weight, Sport);
        }

        /*public void To_study()
        {

        }
        public void Take_exams()
        {

        }*/
    }
}
