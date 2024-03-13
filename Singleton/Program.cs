using System.Text.Json;
namespace Singleton
{
    public class Student
    {
        private string name {  get; set; }
        public Student(string nname)
        {
            name = nname;
        }
        public string GetName()
        {
            return name;
        }
    }
    public class Teacher
    {
        private static List<Teacher> uniqueInstanceList = new List<Teacher>();
        private string name { get; set; }
        private Teacher(string nname)
        {
            name = nname;
        }
        public static Teacher Instance(string name, int n)
        {
            if (n >= uniqueInstanceList.Count)
            {
                uniqueInstanceList.Add(new Teacher(name));
            }
            return uniqueInstanceList[n];
        }
        public static Teacher Instance(int n)
        {
            return uniqueInstanceList[n];
        }
        public static void RemoveInstance(int n)
        {
            uniqueInstanceList.RemoveAt(n);
        }
        public static int GetCount()
        {
            return uniqueInstanceList.Count;
        }
        public string GetName()
        {
            return name;
        }
    }
    public class Course
    {
        private string courseName { get; set; }
        private List<Student> students { get; set; }
        private Teacher? courseTeacher { get; set; }
        public Course(string name)
        {
            courseName = name;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            courseTeacher = teacher;
        }
        public void RemoveStudent(int n)
        {
            students.RemoveAt(n);
        }
        public void RemoveTeacher(int n)
        {
            Teacher.RemoveInstance(n);
            courseTeacher = null;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}