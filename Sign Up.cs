﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Tracking_Project
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            string email = EmailTB.Text;
            string pass = PasswordTB.Text;
            string confirmPass = ConfirmPassTB.Text;
            bool b = false;

            using (Graduation_Project_TrackerEntities ent = new Graduation_Project_TrackerEntities())
            {

                var query = from s in ent.Students select s;
                List<Student> students = query.ToList();
                for (int i = 0; i < students.Count(); i++)
                {
                    if (email == students[i].student_email.ToString())
                    {
                        MessageBox.Show("This email is already used!");
                        b = true;
                        break;
                    }
                }

                if (b == false)//email not found
                {
                    if (pass == confirmPass)
                    {
                        stud.student_password = pass;
                        stud.student_email = email;
                        stud.student_department = DepartmentTB.Text;
                        stud.student_name = NameTB.Text;
                        ent.Students.Add(stud);
                        ent.SaveChanges();
                        MessageBox.Show("The account is successfully created!");
                        Login.logged_user = email;
                        Login.studentID = stud.student_id;
                        Student_Home_Page home = new Student_Home_Page();
                        home.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Check Your Password Again!");
                }

            }
        }
    }
}
