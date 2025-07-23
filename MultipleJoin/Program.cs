using System.Text.RegularExpressions;

class Student
{
    public string Name { get; set; }
    public int DeptId { get; set; }
}
class Department
{
    public string Name { get; set; }
    public int DepartmentId { get; set; }
    public int TeacherId { get; set; }

}
class Teacher
{
    public string Name { get; set; }
    public int TeacherId { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student
            {
                Name="S",DeptId = 1
            },
            new Student
            {
                Name="T",DeptId = 2
            },
            new Student
            {
                Name="H",DeptId=2
            }
        };
        List<Department> departments = new List<Department>()
        {
            new Department
            {
                Name="CSE",DepartmentId = 1,TeacherId = 101
            },
            new Department
            {
                Name="ECE",DepartmentId = 2 , TeacherId =102
            },
            new Department
            {
                Name="EEE",DepartmentId = 3,TeacherId = 103
            },

        };
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher{Name ="Joel",TeacherId = 101},
            new Teacher{Name="vinay",TeacherId = 102}
        };
        var multipleJoin = from student in students
                           join department in departments
                           on student.DeptId equals department.DepartmentId
                           join teacher in teachers
                           on department.TeacherId equals teacher.TeacherId
                           select $"{student.Name} belongs to {department.Name}";
        foreach(var s in multipleJoin)
        {
            Console.WriteLine(s);
        }
        //var query1 = from department in departments
        //             join student in students on department.DepartmentId equals student.DeptId into gj
        //             from subStudent in gj
        //             select new
        //             {
        //                 DepartmentName = department.Name,
        //                 StudentName = $"{subStudent.FirstName} {subStudent.LastName}"
        //             };

        //Console.WriteLine("Inner join using GroupJoin():");
        //foreach (var v in query1)
        //{
        //    Console.WriteLine($"{v.DepartmentName} - {v.StudentName}");
        //}

        List<int> numbers = [35, 44, 200, 84, 3987, 4, 199, 329, 446, 208];
        var even = from number in numbers
                   group number by number % 2;
        foreach(var group in even)
        {
            Console.WriteLine(group.Key == 0 ? "\n Even" : "\n Odd");
            foreach(var g  in group)
            {
                Console.WriteLine(g);
            }
        }
    }
}