﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Singleton
{
    public partial class MainForm : Form
    {
        List<Course> CourseList = new List<Course>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            CourseList.Add(new Course(CourseNameBox.Text));
            CourseListBox.Items.Add(CourseNameBox.Text);
        }

        private void CourseDeleteButton_Click(object sender, EventArgs e)
        {
            CourseList.RemoveAt(CourseListBox.SelectedIndex);
            CourseListBox.Items.RemoveAt(CourseListBox.SelectedIndex);
        }
        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseListBox.SelectedIndex != -1)
            {
                StudentListBox.Items.Clear();
                foreach (Student S in CourseList[CourseListBox.SelectedIndex].GetStudents())
                {
                    StudentListBox.Items.Add(S.GetName());
                }
                TeacherListBox.Items.Clear();
                if ((Teacher.GetCount() > CourseListBox.SelectedIndex) && (CourseList[CourseListBox.SelectedIndex].GetTeacher()!=null))
                    TeacherListBox.Items.Add(CourseList[CourseListBox.SelectedIndex].GetTeacher().GetName());
            }
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (HumanNameBox.Text != "")
            {
                CourseList[CourseListBox.SelectedIndex].AddStudent(new Student(HumanNameBox.Text));
                StudentListBox.Items.Add(HumanNameBox.Text);
            }
        }
        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            if (HumanNameBox.Text != "")
            {
                CourseList[CourseListBox.SelectedIndex].AddTeacher(new Teacher(HumanNameBox.Text, CourseListBox.SelectedIndex));
                if (!TeacherListBox.Items.Contains(Teacher.GetTeacher(CourseListBox.SelectedIndex).GetName()))
                    TeacherListBox.Items.Add(Teacher.GetTeacher(CourseListBox.SelectedIndex).GetName());
            }
        }
        private void HumanDeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentListBox.SelectedIndex > -1)
            {
                CourseList[CourseListBox.SelectedIndex].RemoveStudent(StudentListBox.SelectedIndex);
                StudentListBox.Items.RemoveAt(StudentListBox.SelectedIndex);
            }
            else if (TeacherListBox.SelectedIndex > -1)
            {
                CourseList[CourseListBox.SelectedIndex].RemoveTeacher(CourseListBox.SelectedIndex);
                TeacherListBox.Items.Clear();
            }
        }
    }
}
