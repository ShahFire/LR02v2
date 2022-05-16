using ClassLibrary;
using System;

namespace LR02v3
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanCreation SB = new HumanCreation("Татаринова Светлана Борисовна");
            Console.WriteLine(SB.GetName());
            Console.WriteLine(SB.GetJob());
            Console.WriteLine("\n");

            Student Shah = SB.CreateStudent("Шодиев Артур Хушвахтович", "3-1П9");
            Console.WriteLine(Shah.GetName());
            Console.WriteLine(Shah.GetGroup());
            Console.WriteLine("\n");

            Teacher SunFlower = SB.CreateTeacher("Климов Илья Витальевич", TeacherPosition.Assistant);
            Console.WriteLine(SunFlower.GetName());
            Console.WriteLine(SunFlower.GetJob());
            Console.WriteLine("\n");

            Teacher God = new Teacher("Силенок Юрий Викторович", TeacherPosition.StLecturer);
            Console.WriteLine(God.GetName());
            Console.WriteLine(God.GetJob());
            Console.WriteLine(God.GiveLectures());
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
