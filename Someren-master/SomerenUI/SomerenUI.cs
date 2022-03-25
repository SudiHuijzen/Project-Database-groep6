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
        ErrorLogService logError = new ErrorLogService();
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
                pnlErrorList.Hide();
                pnlActivities.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if(panelName == "DrinkSupply")
            {
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlErrorList.Hide();

                pnlDrinkSupply.Show();
                LoadSupplyList();
               
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                // show rooms
                pnlRooms.Show();
                LoadRoomList();
  
            }
            else if (panelName == "Lectures")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                //show teachers
                pnlTeachers.Show();
                LoadTeacherList();
          
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                // show students
                pnlStudents.Show();
                LoadStudentList();
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
                pnlErrorList.Hide();
                // show register
                pnlRegister.Show();
                LoadRegisterList();
            }
            else if(panelName == "ErrorLog")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();

                pnlErrorList.Show();
                LoadErrorList();
            }
            else if (panelName == "Activities")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity.Hide();

                pnlActivities.Show();
                LoadActivitiesList();

                
            }
            else if (panelName == "ChangeActivity")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlErrorList.Hide();
                pnlActivities.Hide();

                pnlChangeActivity.Show();
              

                
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

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("DrinkSupply");
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("ErrorLog");
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            //clear the selected items after clicking the checkout button
            listViewRegisterStudents.SelectedItems.Clear();
            listViewRegisterDrinks.SelectedItems.Clear();

            //use the selected items to create a new object
            Student student = new Student();
            Drink drink = new Drink();

            for(int i = 0; i < listViewRegisterStudents.Items.Count; i++)
            {
                if(listViewRegisterStudents.Items[i].Selected)
                {
                    student = new Student(int.Parse(listViewRegisterStudents.Items[i].Text));
                }
            }

            for (int i = 0; i < listViewRegisterDrinks.Items.Count; i++)
            {
                if (listViewRegisterDrinks.Items[i].Selected)
                {
                    drink = new Drink(int.Parse(listViewRegisterDrinks.Items[i].Text));
                }
            }

            //get the values to the logic layer
            DrinkService drinkService = new DrinkService();
            drinkService.AddSale(student, drink);
        }

        private void RemoveStockButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditDrinkIdtextBox.Text);
            StockService stockService = new StockService();
            stockService.RemoveDrinkStock(id);
            LoadSupplyList();
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditDrinkIdtextBox.Text);
            StockService stockService = new StockService();
            stockService.AddDrinkStock(id);
            LoadSupplyList();
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditDrinkIdtextBox.Text);
            string name = changeNameTextBox.Text;
            DrinkService drinkService = new DrinkService();
            drinkService.ChangeDrinkName(name, id);
            LoadSupplyList();
            changeNameTextBox.Clear();
        }

        private void changePriceButton_Click(object sender, EventArgs e)
        {

        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            StockService stockService = new StockService();
            Drink drink = new Drink();
            Stock stock = new Stock();

            stock.Id = int.Parse(AddDrinkIdtextBox.Text);
            stock.StockAmount = 0;
            drink.DrinkId = int.Parse(AddDrinkIdtextBox.Text);
            drink.DrinkName = DrinkNameTextBox.Text;
            drink.DrinkType = false;
            drink.DrinkStockId = int.Parse(AddDrinkIdtextBox.Text);
            drink.DrinkStock = stock.StockAmount;

            if (alcoholicRadioButton.Checked)
            {
                drink.DrinkType = true;
            }
            stockService.AddNewStock(stock);
            drinkService.AddDrink(drink);
            LoadSupplyList();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LoadErrorList()
        {
            try
            {
                // fill the rooms listview within the rooms panel with a list of rooms
                ErrorLogService errorLogService = new ErrorLogService(); ;
                List<ErrorLog> errorLogs = errorLogService.GetErrorLogs(); ;


                // clear the listview before filling it again

                listViewErrorLog.Items.Clear();
                foreach (ErrorLog error in errorLogs)
                {

                    ListViewItem li = new ListViewItem(error.ErrorId.ToString());
                    li.SubItems.Add(error.TimeStamp.ToString("G"));
                    li.SubItems.Add(error.ErrorMessage);
                    listViewErrorLog.Items.Add(li);
                }

            }
            catch (Exception e)
            {
                string message = "Something went wrong while loading the Error Log: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }
        private void LoadSupplyList()
        {
            try
            {
                // fill the rooms listview within the rooms panel with a list of rooms
                DrinkService drinkService = new DrinkService(); ;
                List<Drink> drinks = drinkService.GetDrinks(); ;


                // clear the listview before filling it again

                listViewDrinkSupply.Items.Clear();
                foreach (Drink drink in drinks)
                {

                    ListViewItem li = new ListViewItem(drink.DrinkId.ToString());
                    li.SubItems.Add(drink.DrinkName);
                    li.SubItems.Add(drink.AlcoholCheck());
                    li.SubItems.Add(drink.DrinkStock.ToString());
                    listViewDrinkSupply.Items.Add(li);
                }

            }
            catch (Exception e)
            {
                string message = "Something went wrong while loading the Drinks Supply: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }

        }

        private void LoadStudentList()
        {
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
                string message = "Something went wrong while loading the Students: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }

        private void LoadTeacherList()
        {
           
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
                string message = "Something went wrong while loading the Teachers: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }

        private void LoadRoomList()
        {
            
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
                string message = "Something went wrong while loading the Rooms: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }

        private void LoadRegisterList()
        {
           
            try
            {
                // fill the students listview within the students panel with a list of students
                StudentService studService = new StudentService();
                List<Student> studentList = studService.GetStudents();


                // clear the listviews before filling it again
                listViewRegisterStudents.Items.Clear();

                //show the students and drinks in de listviews
                foreach (Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add($"{s.FirstName} {s.LastName}");
                    listViewRegisterStudents.Items.Add(li);
                }

            }
            catch (Exception e)
            {
                string message = "Something went wrong while loading the Register: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }

            try
            {
                DrinkService drinkService = new DrinkService();
                List<Drink> drinkList = drinkService.GetDrinks();
                listViewRegisterDrinks.Items.Clear();
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
                string message = "Something went wrong while loading the Drinks: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }

        public void LoadActivitiesList()
        {
            try
            {
                // fill the students listview within the students panel with a list of students
                ActivityService activityService = new ActivityService();
                List<Activity> activityList = activityService.GetActivities();


                // clear the listviews before filling it again
                listViewActivities.Items.Clear();

                //show the students and drinks in de listviews
                foreach (Activity a in activityList)
                {
                    ListViewItem li = new ListViewItem(a.ActivityId.ToString());
                    li.SubItems.Add(a.Description);
                    li.SubItems.Add(a.BeginTime.ToString());
                    li.SubItems.Add(a.EndTime.ToString());
                    listViewActivities.Items.Add(li);
                }

            }
            catch (Exception e)
            {
                string message = "Something went wrong while loading the Activities: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void btnChooseActivity_Click(object sender, EventArgs e)
        {
            int participent = int.Parse(textBoxActivity.Text);

            showPanel("ChangeActivity");
            LoadActivityStudent(participent);

        }

        public void LoadActivityStudent(int participent)
        {
            try
            {
                // fill the students listview within the students panel with a list of students
                ActivityService activityService = new ActivityService();
                List<Participent> participentList = activityService.GetParticipents(participent);


                // clear the listviews before filling it again
                listViewActivityStudent.Items.Clear();

                //show the students and drinks in de listviews
                foreach (Participent p in participentList)
                {
                    ListViewItem li = new ListViewItem(p.ParticipentId.ToString());
                    li.SubItems.Add(p.ParticipentFirstName);
                    listViewActivityStudent.Items.Add(li);
                }

            }
            catch (Exception e)
            {
                string message = "Something went wrong while loading the Activities: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }
    }
}
