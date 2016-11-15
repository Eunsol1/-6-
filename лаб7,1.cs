using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Student
    {
        public string Name;
        public int Group;
        public int[] Ses;

        public Student(string Name, int Group, int[] Ses)
        {
            this.Name = Name;
            this.Group = Group;
            this.Ses = Ses;
        }
        public void WriteStudent()
        {
            Console.WriteLine("фамилия и инициалы:{0}, номер группы:{1}", Name, Group);
        }
        public bool IsGoodStudent(int[] Ses)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Ses[i] < 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size");
            int a = 0;
            int k = int.Parse(Console.ReadLine());
            Student[] Students = new Student[k];
            for (int i = 0; i < k; i++)
            {
                var student = new Student();
                Console.WriteLine("Name");
                student.Name = Console.ReadLine();

                Console.WriteLine("Group");
                student.Group = int.Parse(Console.ReadLine());
                student.Ses = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Mark {0}", j + 1);
                    student.Ses[j] = int.Parse(Console.ReadLine());
                }
                Students[i] = student;
            }

            foreach (var student in Students)
            {
                if (student.IsGoodStudent(student.Ses) == true)
                {
                    student.WriteStudent();
                }
                    }
                 Console.ReadKey();
        }
    }
}