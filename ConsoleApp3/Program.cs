using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************| Легкая атлетика |****************");
            Stage compitition = new Stage("Легкая атлтика", "Шукуров Шарзод Исламович", "09.05.2023", "1", "20 секунд");

            Teacher teacher = new Teacher("Сидоров ", "Иван", "ИВанович ","15.04.1999", "Мастер спорта", "Влад, Егор");
            Teacher teacher1 = new Teacher("Иванов ", "Петр", "Сергеевич", "15.10.1978", "Мастер спорта международного класса", "Вова, Дима");
            Teacher teacher2 = new Teacher("Петров ", "Илья", "Александрович", "03.05.1986", "Мастер спорта", "Шарзод, Глеб");

            Sportman sportman = new Sportman("Пятков ", "Влад", "Олегович ", "21.04.2005", 185 ,78, "Легкая атлетика");
            Sportman sportman1 = new Sportman("Беленьков ", "Егор", "Сергеевич", "22.01.2005", 190 ,79, "Легкая атлетика");

            Sportman sportman2 = new Sportman("Коршунов", "Вова", "Дмитрейвич ", "21.04.2005", 185, 78, "Легкая атлетика");
            Sportman sportman3 = new Sportman("Индин ", "Дима", "Глебович", "22.01.2005", 190, 79, "Легкая атлетика");

            Sportman sportman4 = new Sportman("Шукуров", "Шарзод", "Исламович", "21.04.2005", 185, 78, "Легкая атлетика");
            Sportman sportman5 = new Sportman("Корчуганов", "Глеб", "Семенович", "22.01.2005", 190, 79, "Легкая атлетика");


            Console.WriteLine(compitition.Passport());

            List<Teacher> teachers = new List<Teacher> { teacher, teacher1, teacher2  };
            List<Sportman> sportmans = new List<Sportman> { sportman, sportman1, sportman2, sportman3, sportman4, sportman5 };

            
            Console.WriteLine("Список преподователей:\n");
            foreach(Teacher t in teachers)
            {
                Console.WriteLine(t.Passport());
            }
            Console.WriteLine("Список спортсменов:\n");
            foreach(Sportman s in sportmans)
            {
                Console.WriteLine(s.Passport());
            }
            Console.WriteLine("Название место проведения соревнований: {0}\n" +
                              "Количество тренеров: {1}\n" +
                              "Количество спортсменов: {2}\n", compitition.Name, Teacher.GetNamberTeacher, Sportman.GetNamberSportman);
            Console.ReadKey();
        }
         

    }
}
