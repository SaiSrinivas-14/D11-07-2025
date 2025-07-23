using System.Security.Cryptography;
using System;
using System.Linq;

class Student
{
    public string Name {  get; set; }
    public List<int> marks {  get; set; }
    public double GPA {  get; set; }
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student{
                Name = "srinivas",
                marks = new List<int>{33,45,32,6,34,34},
                GPA =8.3
            },
            new Student
            {
                Name="Ram",
                marks = new List<int>{34,67,100,76,34,78},
                GPA = 9.0
            }
        };
        var orderBy = students.OrderBy(x => x.GPA);
        foreach(var s in orderBy)
        {
            Console.WriteLine($"{s.Name}");
            foreach(var marks in s.marks)
            {
                Console.WriteLine($"{marks}");
            }
        }
        //var orderbyDesc = students.OrderByDescending(x => x.marks.Average);
        //foreach (var s1 in orderbyDesc)
        //{
        //    Console.WriteLine($"{s1.Name} - Avg Marks: {s1.Marks.Average():F2}");
        //    foreach (var m1 in s1.Marks)
        //    {
        //        Console.WriteLine($"   {m1}");
        //    }
        //}
        bool allOperator = students.All(x => x.GPA > 8.3);
        Console.WriteLine(allOperator.ToString());
        bool anyOperator = students.Any(s => s.marks.Any(m => m < 10));
        Console.WriteLine(anyOperator.ToString());
        bool containsOperator = students.Any(s => s.marks.Contains(100));
        Console.WriteLine(containsOperator.ToString());

        
                          
    }
}
//djicskcdksfncdkncivksednvikdnfviknedcfjiowpasldcol