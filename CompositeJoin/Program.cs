using System.Linq;
class Teacher
{
    public string First {  get; set; }
    public string Last { get; set; }
}
class Student
{
    public string FirstName {  set; get; }
    public string LastName { set; get; }
}
class Program
{
    static void Main()
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher
            {
                First = "A",Last = "B"
            },
            new Teacher
            {
                First = "C",Last = "D"
            },
            new Teacher
            {
                First = "E",Last = "F"
            }
        };
        List<Student> students = new List<Student>()
        {
            new Student{
                FirstName = "E",LastName = "F"
            },
            new Student
            {
                FirstName = "X",LastName = "Y"
            },
            new Student
            {
                FirstName = "A",LastName= "B"
            }
        };
        var compositeJoin = from teacher in teachers
                            join student in students
                            on new { teacher.First, teacher.Last } equals
                            new { First = student.FirstName, Last = student.LastName }
                            select $"{teacher.First},{teacher.Last}";

        foreach (var s in compositeJoin)
        {
            Console.WriteLine(s);
        }


    }
}