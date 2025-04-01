using System;
using System.Data.SQLite;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Student_Database
{
    public partial class studentForm : Form
    {
        private SQLiteConnection sqliteConn;
        private string connectionString = @"Data Source=Student_Database.sqlite;version=3.0";

        public studentForm()
        {
            InitializeComponent();
        }

        private void GetStudent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ID.Text, out int studentId))
            {
                Student student = Student_DB.GetStudent(studentId);
                if (student != null)
                {
                    First_Name.Text = student.FirstName;
                    Last_Name.Text = student.LastName;
                    Address.Text = student.Address;
                    City.Text = student.City;
                    States.Text = student.StateCode;
                    ZipCode.Text = student.ZipCode.ToString();
                    Majors.Text = student.MajorCode;
                    GPA.Text = student.GPA.ToString();
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID.");
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            float gpa;
            if (!float.TryParse(GPA.Text.Trim(), out gpa))
            {
                MessageBox.Show("Invalid GPA");
                return;
            }

            var student = new Student
            {
                FirstName = First_Name.Text,
                LastName = Last_Name.Text,
                Address = Address.Text,
                City = City.Text,
                StateCode = States.Text,
                ZipCode = int.Parse(ZipCode.Text),
                MajorCode = Majors.Text,
                GPA = gpa,
                IsDeleted = false
            };

            if (Student_DB.AddStudent(student))
            {
                MessageBox.Show("Student added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add student.");
            }
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            float gpa;
            if (!float.TryParse(GPA.Text.Trim(), out gpa))
            {
                MessageBox.Show("Invalid GPA");
                return;
            }

            if (int.TryParse(ID.Text, out int studentId))
            {
                var student = new Student
                {
                    StudentId = studentId,
                    FirstName = First_Name.Text,
                    LastName = Last_Name.Text,
                    Address = Address.Text,
                    City = City.Text,
                    StateCode = States.Text,
                    ZipCode = int.Parse(ZipCode.Text),
                    MajorCode = Majors.Text,
                    GPA = gpa,
                    IsDeleted = false
                };

                if (Student_DB.UpdateStudent(student))
                {
                    MessageBox.Show("Student updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update student.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID.");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}