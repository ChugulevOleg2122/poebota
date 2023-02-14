using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Stage : Compitition
    {
         string Winner;
         string Time;



        List<Teacher> teacher { get; set; } = null;
        
        List<Sportman> sportman { get; set; } = null;

        public Stage(string Name,string Date, string Stages, string winner,string time) : base(Name, Date, Stages)
        {
            this.Winner = winner;
            this.Time = time;
        }

        public string Passport()
        {
            return string.Format("Название: {0}\n" + 
                "Победитель: {1}\n" + 
                "Время: {2}\n" + 
                "Дата: {3}\n" + 
                "Этап: {4}\n",Name,Date,Time,Stages,Winner);
        }
        
        public void AddTeacher(Teacher newTeacher)
        {
            teacher.Add(newTeacher);
        }

        public void DelTeacher(Teacher delTeacher) 
        {
            teacher.Remove(delTeacher);
        }

        public void AddSportman(Sportman newSportman)
        {
            sportman.Add(newSportman);
        }

        public void DelSportman(Sportman delSportman)
        {
            sportman.Remove(delSportman);
        }
    }
}