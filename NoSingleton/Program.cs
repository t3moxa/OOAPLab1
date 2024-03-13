using System.Text.Json;
namespace Singleton
{
    public class Student
    {
        public string name {  get; set; }
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
        private static List<Teacher> TeacherList = new List<Teacher>();
        private string name { get; set; }
        public Teacher(string nname, int n)
        {
            name = nname;
            if (n >= GetCount())
                TeacherList.Add(this);
        }
        public static Teacher GetTeacher(int n)
        {
            return TeacherList[n];
        }
        public string GetName()
        {
            return name;
        }
        public static void RemoveTeacher(int n)
        {
            TeacherList.RemoveAt(n);
        }
        public static int GetCount()
        {
            return TeacherList.Count;
        }
    }
    public class Course
    {
        public string courseName { get; set; }
        public List<Student> students { get; set; }
        public Teacher? courseTeacher { get; set; }
        public Course(string name)
        {
            courseName = name;
            students = new List<Student>();
            courseTeacher = null;
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
            Teacher.RemoveTeacher(n);
            courseTeacher = null;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public Teacher GetTeacher()
        {
            return courseTeacher;
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