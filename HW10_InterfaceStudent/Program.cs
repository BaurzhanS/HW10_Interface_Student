using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_InterfaceStudent
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int [] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }
    public class Student:IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }
        public Student(string name,string fullName)
        {
            this.Name = name;
            this.FullName = fullName;
        }

        public string GetName() { return this.Name; }
        public string GetFullName() { return this.FullName; }
        public double GetAvgGrade()
        {
            
            int sum = 0;
            for (int i = 0; i < this.Grades.Length; i++)
            {
                sum += Grades[i];
            }
            double avg = (double)sum / Grades.Length;
            return avg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Stalinov", "Lenin");
            s.Grades = new int[10];
            for (int i = 0; i < s.Grades.Length; i++)
            {
                s.Grades[i] = i;
            }
            Console.WriteLine(s.GetAvgGrade());
        }
    }
}
