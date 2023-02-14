using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Teacher : Person
    {
        string Rank;
        string haveSportmans;
        
        List<Sportman> sportman { get; set; } = null ;

        static int namberTeacher;
        public Teacher(string Surname, string Name, string Middle_name, string Year_of_birth,
            string rank, string havesportmans)
            : base(Surname, Name, Middle_name, Year_of_birth) 
            {
            this.Rank = rank;
            this.haveSportmans = havesportmans;

            

            namberTeacher += 1;
            }
        public static int GetNamberTeacher
        {
            get { return namberTeacher; }
        }
        
        public string Passport()
        {
            return string.Format("ФИО: {0} {1} {2}\n" +
                                 "Дата рождения: {3}\n" +
                                 "Разряд: {4}\n" +
                                 "Тренируемые спортсмены: {5}\n",
                                 Surname,Name,Middle_name,Year_of_birth,Rank,haveSportmans);
        }

        public void AddSpotmam(Sportman newSportman)
        {
            sportman.Add(newSportman);
        }

        public void DelSportman(Sportman delSportman)
        {
            sportman.Remove(delSportman);
        }

        /*public void Teach_student()
        {

        }
        public void Take_exams()
        {

        }
        public void Scientific_supervisor()
        {

        }*/
    }
}
