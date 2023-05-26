using oop_models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_models.implement
{
    internal class services
    {
        List<Student> students = new List<Student>();
        public void insert(Student student)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();
                sv.add();
                students.Add(sv);
            }
        }
        //search by id
        public void search(Student student)
        {
            //check id for duplicates
            
            Student student1 = students.Find(x => x.id == student.id);
            Console.WriteLine("id: " + student1.id + " name: " + student1.name + " age: " + student1.age + " hometown: " + student1.hometown + " score: " + student1.score + " class: " + student1.clas);
            Console.WriteLine( );

        }
        public void update(Student student)
        {
            Student student1 = students.Find(x => x.id == student.id);
            student1.name = student.name;
            student1.age = student.age;
            student1.hometown = student.hometown;
        }   
        public void delete(int id)
        {
            Student student = students.Find(x => x.id == id);
            students.Remove(student);
        }
        //sort by score
        public List<Student> sort()
        {
            students.Sort((x, y) => x.score.CompareTo(y.score));
            return students;
        }

        public List<Student> getAll()
        {
            return students;
        }

    }
}
