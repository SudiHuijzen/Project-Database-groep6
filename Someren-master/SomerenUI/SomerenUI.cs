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
                pnlRooms.Hide();
                pnlRegister.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if(panelName == "DrinkSupply")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();
                pnlRooms.Hide();

                pnlDrinkSupply.Show();
                
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();

                // show rooms
                pnlRooms.Show();

                try
                {
                    // fill the rooms listview within the rooms panel with a list of rooms
                    RoomService roomService = new RoomService(); ;
                    List<Room> roomList = roomService.GetRooms(); ;

                    // clear the listview before filling it again

                    listViewRooms.Items.Clear();
                    foreach (Room r in roomList)
                    {

                        ListViewItem li = new ListViewItem(r.Number.ToString());
                        li.SubItems.Add(r.Capacity.ToString());
                        li.SubItems.Add(r.PrintRoom()); // shows whether or not the room is a teacher room
                        listViewRooms.Items.Add(li);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Lectures")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();

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
                        li.SubItems.Add(t.FirstName);
                        li.SubItems.Add(t.LastName);
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
                pnlRooms.Hide();
                pnlRegister.Hide();

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
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        li.SubItems.Add(s.BirthDate.ToString("dd/MM/yyyy"));
                        listViewStudents.Items.Add(li);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Register")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                // show register
                pnlRegister.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    // clear the listbox before filling it again
                    listBoxStudents.Items.Clear();

                    //show the students and drinks in de listboxes
                    foreach (Student s in studentList)
                    {
                        listBoxStudents.Items.Add($"{s.FirstName} {s.LastName}");
                        //listBoxDrinks.Items.Add
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

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }
        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("DrinkSupply");
        }
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Register");
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            string studentName = listBoxStudents.SelectedItem.ToString();
            //string drink = listBoxDrinks.SelectedItem.ToString();

            listBoxStudents.ClearSelected();
            //listBoxDrinks.ClearSelected();
        }

   
    }
}
