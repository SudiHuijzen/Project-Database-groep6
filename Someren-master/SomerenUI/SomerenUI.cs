﻿using SomerenLogic;
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
                pnlRevenueReport.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();
                pnlRevenueReport.Hide();

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
                pnlRevenueReport.Hide();

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
                pnlRevenueReport.Hide();

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
                pnlRevenueReport.Hide();

                // show register
                pnlRegister.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    DrinkService drinkService = new DrinkService(); ;
                    List<Drink> drinkList = drinkService.GetDrinks(); ;

                    // clear the listviews before filling it again
                    listViewRegisterStudents.Items.Clear();
                    listViewRegisterDrinks.Items.Clear();

                    //show the students and drinks in de listviews
                    foreach (Student s in studentList)
                    {
                        ListViewItem li = new ListViewItem(s.Number.ToString());
                        li.SubItems.Add($"{s.FirstName} {s.LastName}");
                        listViewRegisterStudents.Items.Add(li);
                    }

                    foreach (Drink d in drinkList)
                    {
                        ListViewItem list = new ListViewItem(d.DrinkId.ToString());
                        list.SubItems.Add(d.DrinkName);
                        list.SubItems.Add(d.DrinkPrice.ToString());
                        list.SubItems.Add(d.DrinkStock.ToString());
                        listViewRegisterDrinks.Items.Add(list);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }

            }
            else if (panelName == "Revenue Report")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();

                // show register
                pnlRevenueReport.Show();

                
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

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Register");
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            //clear the selected items after clicking the checkout button
            listViewRegisterStudents.SelectedItems.Clear();
            listViewRegisterDrinks.SelectedItems.Clear();

            //use the selected items to create a new object
            Student student = new Student(int.Parse(listViewRegisterStudents.SelectedItems[0].SubItems[0].Text));
            Drink drink = new Drink(int.Parse(listViewRegisterDrinks.SelectedItems[0].SubItems[0].Text));

            //get the values to the logic layer
            DrinkService drinkService = new DrinkService();
            drinkService.AddSale(student, drink);
        }

        private void pnlRevenueReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reveneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue Report");
        }
    }
}
