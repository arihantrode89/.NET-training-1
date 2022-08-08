using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linq_Examples
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Char Gender { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //query syntax
            string[] str = new string[] { "Arihant", "Ayushya", "Kick", "Sick", "Pig" };

            var str1 = from item in str
                            where item.Contains('A')
                            select item;
            foreach(var item in str1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //method
            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1, Name="Arihant",Age=22,Gender='M'},
                new Student(){ Id=2, Name="Ayushya",Age=22,Gender='F'},
                new Student(){ Id=3, Name="Chirag",Age=22,Gender='M'},
                new Student(){ Id=4, Name="Aastha",Age=23,Gender='F'},
            };

            Student[] res = students.Where(s => s.Age > 20 && s.Age <= 22).ToArray();
            foreach(var student in res)
            {
                Console.WriteLine(student.Name +' '+student.Age);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            Student std = students.Where(s => s.Name == "Arihant").FirstOrDefault();
            Console.WriteLine(std.Name);

            Student std1 = students.Where(s => s.Age > 20).ToList().FirstOrDefault();
            Console.WriteLine(std1.Name+' '+std1.Age);

            //oftype
            IList obj = new ArrayList() { 0, "arihant", 1, "rode" };
            var res1 = obj.OfType<string>();
            foreach(string s in res1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("".PadLeft(30,'-'));

            //order by
            var stuorderby = students.OrderBy(s => s.Age);
            foreach(Student student in stuorderby)
            {
                Console.WriteLine(student.Name + ' ' + student.Age);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //order by desc
            var stdorderbydesc = students.OrderByDescending(s => s.Age);
            foreach (Student student in stdorderbydesc)
            {
                Console.WriteLine(student.Name + ' ' + student.Age);
            }
            Console.WriteLine("".PadLeft(30, '-'));


            //group by
            var stdgroupby = students.GroupBy(s => s.Age);

            foreach(var item in stdgroupby)
            {
                Console.WriteLine($"Age Group:{item.Key}");
                foreach(Student student in item)
                {
                    Console.WriteLine($"{student.Name}--{student.Age}");
                }
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //tolookup
            var stdtolookup = students.ToLookup(s => s.Age);

            foreach (var item in stdtolookup)
            {
                Console.WriteLine($"Age Group:{item.Key}");
                foreach (Student student in item)
                {
                    Console.WriteLine($"{student.Name}--{student.Age}");
                }
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //then by 
            var stdthenby = students.OrderBy(s => s.Age).ThenBy(s=>s.Name);
            foreach (Student student in stdthenby)
            {
                Console.WriteLine(student.Name + ' ' + student.Age);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //thenby desc
            var stdthenbydesc = students.OrderBy(s => s.Age).ThenByDescending(s => s.Name);
            foreach (Student student in stdthenbydesc)
            {
                Console.WriteLine(student.Name + ' ' + student.Age);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //join
            List<string> list = new List<string>() { "one","two","three","four"};
            List<string> list1 = new List<string>() { "one", "five", "six", "seven" };

            var innerjoin = list.Join(list1, str3 => str3, str2 => str2, (str3, str2) => str3);
            foreach(string s in innerjoin)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //groupjoin

            List<Sample> obbj = new List<Sample>() { 
                new Sample() { id = 1, val = "A" }, 
                new Sample() { id = 2, val = "B" }, 
                new Sample() { id = 3, val = "C" },
                new Sample() { id = 4, val = "D" }
            };

            List<Sample1> obj1 = new List<Sample1>() {
                new Sample1() { id = 1, child = "a1" },
                new Sample1() { id = 1, child = "a2" },
                new Sample1() { id = 1, child = "a3" },
                new Sample1() { id = 2, child = "b1" },
                new Sample1() { id = 2, child = "b2" },
                new Sample1() { id = 3, child = "c1" },
            };

            var groupjoin = obbj.GroupJoin(obj1,
                s => s.id, s1 => s1.id,
                (value, childvalue) => new { value = value, child = childvalue });

            foreach(var item in groupjoin)
            {
                Console.WriteLine(item.value.val);
                foreach(var item1 in item.child)
                {
                    Console.WriteLine(item1.id.ToString() + '-'+item1.child);
                }

            }
            Console.WriteLine("".PadLeft(30,'-'));

            //select

            var stuselect = students.Select(s => new { Name = s.Name, Gender = s.Gender,Age=s.Age }).Where(s=>s.Age>22);
            foreach( var item in stuselect)
            {
                Console.WriteLine($"{item.Name} {item.Gender} {item.Age}");
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //select many
            var stuselmany = students.SelectMany(s => s.Name).ToList();
            foreach (var item in stuselmany)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("".PadLeft(30, '-'));

            //all any contains

            bool alluse = students.All(s => s.Age > 22);
            Console.WriteLine(alluse);

            bool anyuse = students.Any(s => s.Age > 22);
            Console.WriteLine(anyuse);

            //Element Operators

            var ss = students.FirstOrDefault(s => s.Name.Contains('a'));
            Console.WriteLine(ss.Name);
            var s2 = students.LastOrDefault(s => s.Name.Contains('a'));
            Console.WriteLine(s2.Name);

            List<Dept> dept = new List<Dept>()
            {
                new Dept(){id=1,dept=100,Age=20},
                new Dept(){id=2,dept=100,Age=22},
                new Dept(){id=3,dept=100,Age=25},
                new Dept(){id=4,dept=100,Age=22},
                new Dept(){id=5,dept=100,Age=23},
                new Dept(){id=6,dept=101,Age=26},
                new Dept(){id=7,dept=101,Age=23},
                new Dept(){id=8,dept=101,Age=25},
                new Dept(){id=9,dept=102,Age=20},
                new Dept(){id=10,dept=102,Age=22},
                new Dept(){id=11,dept=102,Age=22},
            };

            var result = dept.Select(s => new { dept=s.dept,Age=s.Age}).GroupBy(s => s.dept).Where(s => s.Sum(s1=>s1.Age)>19);
            foreach(var item in result)
            {
                Console.WriteLine($"dept:{item.Key}");
                foreach(var item2 in item)
                {
                    Console.WriteLine(item2.dept.ToString()+'-'+item2.Age);
                }
            }

        }
    }

    class Dept
    {
        public int id { get; set; }
        public int dept { get; set; }

        public byte Age { get; set; }
    }
    class Sample
    {
        public int id { get; set; }
        public string val { get; set; }
    }
    class Sample1
    {
        public int id { get; set; }
        public string child { get; set; }
    }


}
