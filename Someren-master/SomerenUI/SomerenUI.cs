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
                pnlRevenueReport.Hide();

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
                

                pnlDrinkSupply.Show();

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
                    MessageBox.Show("Something went wrong while loading the drink supply: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();
<<<<<<< HEAD
                pnlRevenueReport.Hide();

=======
                pnlDrinkSupply.Hide();
>>>>>>> 9cbf7bd94abe0c9d090a41ae4920a22712f640ca
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
<<<<<<< HEAD
                pnlRevenueReport.Hide();

=======
                pnlDrinkSupply.Hide();
>>>>>>> 9cbf7bd94abe0c9d090a41ae4920a22712f640ca
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
<<<<<<< HEAD
                pnlRevenueReport.Hide();

=======
                pnlDrinkSupply.Hide();  
>>>>>>> 9cbf7bd94abe0c9d090a41ae4920a22712f640ca
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
<<<<<<< HEAD
                pnlRevenueReport.Hide();

=======
                pnlDrinkSupply.Hide();
>>>>>>> 9cbf7bd94abe0c9d090a41ae4920a22712f640ca
                // show register
                pnlRegister.Show();

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
                    MessageBox.Show("Something went wrong while loading the Students: " + e.Message);
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
                    MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
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

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("DrinkSupply");
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

<<<<<<< HEAD
        private void pnlRevenueReport_Paint(object sender, PaintEventArgs e)
=======
        private void RemoveStockButton_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink()
            {
                DrinkId = int.Parse(listViewRegisterDrinks.SelectedItems[0].SubItems[0].Text)
            };
            DrinkService drinkService = new DrinkService();
            drinkService.RemoveDrinkStock(drink);
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink()
            {
                DrinkId = int.Parse(listViewRegisterDrinks.SelectedItems[0].SubItems[0].Text)
            };
            DrinkService drinkService = new DrinkService();
            drinkService.AddDrinkStock(drink);
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {

        }

        private void changePriceButton_Click(object sender, EventArgs e)
>>>>>>> 9cbf7bd94abe0c9d090a41ae4920a22712f640ca
        {

        }

<<<<<<< HEAD
        private void reveneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue Report");
=======
        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            DrinkService drinkService1 = new DrinkService();
            Drink drink = new Drink()
            {
                DrinkName = DrinkNameTextBox.Text,
                DrinkType = false,
                DrinkStock = 0
            };
            if (alcoholicRadioButton.Checked)
            {
                drink.DrinkType = true;
            }
            drinkService1.AddNewStock(drink);
            drinkService1.AddDrink(drink);
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

>>>>>>> 9cbf7bd94abe0c9d090a41ae4920a22712f640ca
        }
    }
}
