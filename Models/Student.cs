using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_models.Models
{
    internal class Student : person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string hometown { get; set; }
        public int score { get; set; }
        public string clas { get; set; }
        //add student
        //constructor
        public Student()
        {
        }
        public Student(int id, string name, int age, string hometown, int score, string clas)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.score = score;
            this.clas = clas;
        }
        public void add()
        {
            Console.WriteLine("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hometown: ");
            hometown = Console.ReadLine();
            Console.WriteLine("Enter score: ");
            score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter class: ");
            clas = Console.ReadLine();
        }
    }
}
