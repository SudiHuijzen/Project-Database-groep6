using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                pnlTeachers.Hide();
                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }else if(panelName == "Lectures")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();

                //show teachers
                pnlTeachers.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    TeacherService teachService = new TeacherService(); ;
                    List<Teacher> TeacherList = teachService.GetTeachers(); ;

                    // clear the items in the listview before filling it again
                    listViewTeachers.Items.Clear();

                    foreach (Teacher t in TeacherList)
                    {
                      
                        ListViewItem li = new ListViewItem(t.Number.ToString());
                        li.SubItems.Add(t.firstName);
                        li.SubItems.Add(t.lastName);
                        li.SubItems.Add(t.PrintSupervisor());   // shows whether or not teacher is supervicor when true
                        listViewTeachers.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Teacher: " + e.Message);
                }
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    // clear the listview before filling it again

                    listViewStudents.Items.Clear();
                    foreach (Student s in studentList)
                    {
         
                        ListViewItem li = new ListViewItem(s.Number.ToString());
                        li.SubItems.Add(s.Name);
                        li.SubItems.Add(s.BirthDate.ToString("dd/MM/yyyy"));
                        listViewStudents.Items.Add(li);
                    }
                   
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lectures");
        }

    }
}
