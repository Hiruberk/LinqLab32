using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinqLab32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Linq with Nums\n");

            Console.WriteLine("1) Find the Minimum Value");
            int lowestNum = nums.Min();
            Console.WriteLine(lowestNum);
            Console.WriteLine();

            Console.WriteLine("2) Find the Maximum Value");
            int highestNum = nums.Max();
            Console.WriteLine(highestNum);
            Console.WriteLine();

            Console.WriteLine("3) Find the Maximum Value less than 10000");
            int highUnder10000 = nums.Where(x => x < 10000).Max();
            Console.WriteLine(highUnder10000);
            Console.WriteLine();

            Console.WriteLine("4) Find all the values between 10 and 100 (Inclusive)");
            List<int> between10n100 = nums.Where(x => x >= 10 && x <= 100).ToList();
            foreach(int num in between10n100)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("5) Find all the values between 100000 and 999999 (Inclusive)");
            List<int> between= nums.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach (int num in between)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("6) Count all the even numbers");
            List<int> evens = nums.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(evens.Count()+ " even numbers");

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Linq with Students\n");

            Console.WriteLine("1) Find all Students age of 21 and over");
            List<Student> drinkers = students.Where(x => x.CanDrink == true).ToList();
            foreach(Student drinker in drinkers)
            {
                Console.WriteLine(drinker.Name);
            }
            Console.WriteLine();

            Console.WriteLine("2) Find the oldest Student");
            Student old = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine(old.Name);
            Console.WriteLine();

            Console.WriteLine("3) Find the youngest Student");
            Student young = students.OrderByDescending(x => x.Age).Last();
            Console.WriteLine(young.Name);
            Console.WriteLine();

            Console.WriteLine("4) Find the oldest Student under the age of 25");
            Student old25 = students.Where(x => x.Age < 25).OrderByDescending(x => x.Age).First();
            Console.WriteLine(old25.Name);
            Console.WriteLine();

            Console.WriteLine("5) Find all students over 21 and with even ages");
            List<Student> evenstudents = students.Where(x => x.Age % 2 == 0).ToList();
            List<Student> evenunder25students = evenstudents.Where(x => x.Age > 21).ToList();
            foreach(Student s in evenunder25students)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            Console.WriteLine("6) Find all teenage students (13 to 19 inclusive)");
            List<Student> teens = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach (Student s in teens)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            Console.WriteLine("7) Find all students whose name starts with a vowel");
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            List<Student> vowel = students.Where(x => vowels.Any (L => x.Name.StartsWith(L))).ToList();
            foreach (Student s in vowel)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }
}
