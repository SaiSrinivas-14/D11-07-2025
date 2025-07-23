using System.Runtime.ExceptionServices;

//class Teacher
//{
//    public string First {  get; set; }
//    public string Last { get; set; }
//    public int ID {  get; set; }
//}
//class Department
//{
//    public int DeptID { get; set; }
//    public string Name { get; set; }
//}
public class Program
{
    public class Teacher
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
    }
    class Department
    {
        public int DeptID { get; set; }
        public string Name { get; set; }
    }
    static void Main(string[] args)
    {
        List<Department> departments = new List<Department>
        {
        new Department{
            DeptID = 1,
            Name = "A"
        }

        };
    }
}