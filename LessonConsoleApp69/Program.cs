using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonConsoleApp69
{
    class Program
    {
        enum Gender
        {
            Man,
            Woman
        }
        struct Student
        {
            public string Surname;
            public string Name;
            public int Age;
            public Gender Gender;
        }
        static void Main(string[] args)
        {
            Student parviz = new Student();

            parviz.Name = "Parviz";
            parviz.Surname = "Azizov";
            parviz.Age = 23;
            parviz.Gender = Gender.Man;


            Console.WriteLine($"Name: {parviz.Name}\n" +
                $"Surname: {parviz.Surname}\n"+
                $"Age: {parviz.Age}\n" +
                $"Gender: {parviz.Gender}\n");

            Console.ReadLine();
        }
    }
}
