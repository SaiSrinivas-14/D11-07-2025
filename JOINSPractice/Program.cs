class Student
{
    public string Name {  get; set; }
    public int DeptID {  get; set; }
}
class Department
{
    public int ID { get; set; } 
    public string DepName {  get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student
            {
                Name="A",
                DeptID = 1
            },
            new Student
            {
                Name="B",
                DeptID = 2
            },
            new Student
            {
                Name="C",
                DeptID = 2
            },
            new Student
            {
                Name="D",
                DeptID = 3
            }
        };
        List<Department> departments = new List<Department>()
        {
            new Department
            {
                ID = 1,
                DepName = "CSE"
            },
            new Department
            {
                ID = 2,
                DepName = "ECE"
            }
        };
        var join = from s in students
                   join d in departments
                   on s.DeptID equals d.ID
                   select new
                   {
                       StudentName = s.Name,
                       deptName = d.DepName
                   };
        foreach (var student in join)
        {
            Console.WriteLine($"{student.StudentName} {student.deptName}");
        }
        //var groupjoin = from student in students
        //                join department in departments
        //                on student.DeptID equals department.ID into studentgroup
        //                select new
        //                {
        //                    StudName = student.Name,
        //                    Students = studentgroup
                            //Console.WriteLine("Group Join");
                            //foreach (var s in groupjoin)
                            //{
                            //    Console.WriteLine($"{s.StudName} ");
                            //    foreach(Department student in s.Students)
                            //    {
                            //        Console.WriteLine($"{student.DepName}");
                            //    }
                            //}
                        }
                        }
