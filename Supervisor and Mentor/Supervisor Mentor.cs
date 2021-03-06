﻿using Graduation_Tracking_Project.Supervisor_and_Mentor;
using Graduation_Tracking_Project.Supervisor_Mentor_Home;
using System;
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
    public partial class Supervisor_Mentor : Form
    {
        public Supervisor_Mentor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Upload_Student_Grades GUI = new Upload_Student_Grades();
            GUI.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Post_Announcements GUI = new Post_Announcements();
            GUI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Post_Office_Hours GUI = new Post_Office_Hours();
            GUI.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Assigned_Projects GUI = new View_Assigned_Projects();
            GUI.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email_Students GUI = new Email_Students();
            GUI.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings GUI = new Settings();
            GUI.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login.supervisor = false;
            Login.mentor = false;
            Login.logged_user = "";
            Entry home = new Entry();
            home.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_Project home = new Add_Project();
            home.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Update_Project home = new Update_Project();
            home.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Update_Task home = new Update_Task();
            home.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Add_Task home = new Add_Task();
            home.Show();
            this.Hide();
        }

        private void Supervisor_Mentor_Load(object sender, EventArgs e)
        {
            if(Login.supervisor)
            {
                AddProjectButton.Visible = true;
                AddTaskButton.Visible = true;
                UpdateProjectButton.Visible = true;
                UpdateTaskButton.Visible = true;
                StudentGradesButton.Visible = true;
            }
            else
            {
                AddProjectButton.Visible = false;
                AddTaskButton.Visible = false;
                UpdateProjectButton.Visible = false;
                UpdateTaskButton.Visible = false;
                StudentGradesButton.Visible = false;
            }
        }
    }
}
