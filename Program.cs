using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace OOBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Muhanad" , "A" , 1 , "AB-121");
            //std1.Name = "Muhanad";
            //std1.grade = "A";
            //std1.id = 1;

            Console.WriteLine("student1 details");
            Console.WriteLine("*************");
            Console.WriteLine("ID: " + std1.id);
            Console.WriteLine("Name: " + std1.Name);
            Console.WriteLine("Grade: " + std1.grade);
            Console.WriteLine("registration Number is " + std1.registrationNumber);
            std1.study();
            std1.studentDatils();
            Console.WriteLine();

            Student std2 = new Student("Ahmed" , "B", 2 ,"AB-123" );
            //std2.Name = "Ahmed";
            //std2.grade = "B";
            //std2.id = 2;
           


            Console.WriteLine("student2 details");
            Console.WriteLine("*************");
            Console.WriteLine("ID: " + std2.id);
            Console.WriteLine("Name: " + std2.Name);
            Console.WriteLine("Grade: " + std2.grade);
            Console.WriteLine("registration Number is " + std2.registrationNumber);
            std2.study();
            std2.studentDatils();
            Console.WriteLine();

            //Teacher tec1 = new Teacher();
            //tec1.Name = "Mohammed";
            //tec1.Subject = "Arabic";
            //tec1.id = 12;

            //Console.WriteLine("teacher1 details");
            //Console.WriteLine("*************");
            //Console.WriteLine("ID: " + tec1.id);
            //Console.WriteLine("Name: " + tec1.Name);
            //Console.WriteLine("subject: " + tec1.Subject);
            //tec1.teaching();
            //Console.WriteLine();

            //Teacher tec2 = new Teacher();
            //tec2.Name = "khalid";
            //tec2.Subject = "MAth";
            //tec2.id = 22;

            //Console.WriteLine("teacher2 details");
            //Console.WriteLine("*************");
            //Console.WriteLine("ID: " + tec2.id);
            //Console.WriteLine("Name: " + tec2.Name);
            //Console.WriteLine("subject: " + tec2.Subject);
            //tec2.teaching();

        }
    }
}