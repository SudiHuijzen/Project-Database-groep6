using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        ErrorLogService logError = new ErrorLogService();
        int ActivityId;
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("LogIn");
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
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                pnlLogIn.Hide();
                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if(panelName == "DrinkSupply")
            {
                pnlLogIn.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                pnlDrinkSupply.Show();
                LoadSupplyList();
               
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlStudents.Hide();
                pnlRegister.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                // show rooms
                pnlRooms.Show();
                LoadRoomList();
  
            }
            else if (panelName == "Lectures")
            {
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity?.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                //show teachers
                pnlTeachers.Show();
                LoadTeacherList();
          
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlRegister.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                // show students
                pnlStudents.Show();
                LoadStudentList();
            }
            else if (panelName == "Register")
            {
                // hide all other panels
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                // show register
                pnlRegister.Show();
                LoadRegisterList();
            }
            else if(panelName == "ErrorLog")
            {
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlChangeActivity.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                pnlErrorList.Show();
                LoadErrorList();
            }
            else if (panelName == "Activities")
            {
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlErrorList.Hide();
                pnlChangeActivity.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();
                pnlActivities.Show();
                LoadActivitiesList();
            }
            else if (panelName == "ChangeActivity")
            {
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlErrorList.Hide();
                pnlActivities.Hide();
                pnlUserRegister.Hide();

                pnlChangeActivity.Show();
            }else if(panelName == "RegisterUser")
            {
                registerFirstPassTextBox.PasswordChar = '*';
                registerSecondPassTextBox.PasswordChar = '*';
                pnlLogIn.Hide();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlErrorList.Hide();
                pnlActivities.Hide();
             

                pnlChangeActivity.Hide();
                pnlUserRegister.Show();
            }else if(panelName == "LogIn")
            {
                passwordTextBox.PasswordChar = '*';
                changePassFirstTextBox.PasswordChar= '*';
                changePassSecondTextBox.PasswordChar= '*';  
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlDrinkSupply.Hide();
                pnlRegister.Hide();
                pnlErrorList.Hide();
                pnlActivities.Hide();


                pnlChangeActivity.Hide();
                pnlUserRegister.Hide();
                pnlLogIn.Show();
            }
        }

        /* ---------- Panel link clicks -----------*/
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
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showPanel("RegisterUser");
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are sure you want to Log out";
            string title = "Log Out";

            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                showPanel("LogIn");
                wrongPassWarningLabel.Hide();
                ChangePassLinkLabel.Hide();
            }
        }

        /* ----------- Loading Lists ------------*/
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
        private void LoadActivityStudentList()
        {
            try
            {
                // fill the students listview within the students panel with a list of students
                StudentService studService = new StudentService(); ;
                List<Student> studentList = studService.GetStudents(); ;

                // clear the listview before filling it again
                listViewAllStudents.Items.Clear();

                foreach (Student s in studentList)
                {

                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    li.SubItems.Add(s.BirthDate.ToString("dd/MM/yyyy"));
                    listViewAllStudents.Items.Add(li);
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

        private void LoadAllTeacherList()
        {

            try
            {
                // fill the students listview within the students panel with a list of students
                TeacherService teachService = new TeacherService(); ;
                List<Teacher> TeacherList = teachService.GetTeachers(); ;

                // clear the items in the listview before filling it again
                listViewAllTeachers.Items.Clear();

                foreach (Teacher t in TeacherList)
                {

                    ListViewItem li = new ListViewItem(t.Number.ToString());
                    li.SubItems.Add(t.FirstName);
                    li.SubItems.Add(t.LastName);
                    listViewAllTeachers.Items.Add(li);
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

        public void LoadActivityTeachers(int supervisor)
        {
            try
            {
                // fill the students listview within the students panel with a list of students
                ActivityService activityService = new ActivityService();
                List<Supervisor> supervisors = activityService.GetSupervisors(supervisor);


                // clear the listviews before filling it again
                listViewActivityTeachers.Items.Clear();

                //show the students and drinks in de listviews
                foreach (Supervisor s in supervisors)
                {
                    ListViewItem li = new ListViewItem(s.SupervisorId.ToString());
                    li.SubItems.Add(s.SupervisorFullName);
                    listViewActivityTeachers.Items.Add(li);
                }

            }
            catch (Exception e)
            {
                string message = "Something went wrong while loading the Activities: " + e.Message;
                logError.AddErroLog(message);
                MessageBox.Show(message);
            }
        }

        /* ---------- Button clicks ----------*/
        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            //clear the selected items after clicking the checkout button
            listViewRegisterStudents.SelectedItems.Clear();
            listViewRegisterDrinks.SelectedItems.Clear();

            //use the selected items to create a new object
            Student student = new Student();
            Drink drink = new Drink();

            for (int i = 0; i < listViewRegisterStudents.Items.Count; i++)
            {
                if (listViewRegisterStudents.Items[i].Selected)
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

        private void btnChooseActivity_Click(object sender, EventArgs e)
        {
            ActivityId = int.Parse(textBoxActivity.Text);

            showPanel("ChangeActivity");
            
            LoadActivityStudent(ActivityId);
            LoadActivityStudentList();
            LoadActivityTeachers(ActivityId);
            LoadAllTeacherList();
        }

        public void LoadActivityStudent(int participent)
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
                    li.SubItems.Add(p.ParticipentFullName);
                    listViewActivityStudent.Items.Add(li);
                }
        }

        private void AddParticipentButton_Click(object sender, EventArgs e)
        { 
            ActivityId = int.Parse(textBoxActivity.Text);
            int StudentId = int.Parse(SelectParticipentIdTextBox.Text);
            ActivityService activityService = new ActivityService();
            activityService.AddParticipent(StudentId, ActivityId);
            LoadActivityStudent(ActivityId);
            SelectParticipentIdTextBox.Clear();
        }

        private void RemoveParticipentButton_Click(object sender, EventArgs e)
        {
            string message = "Are sure you want to remove the participent?";
            string title = "Remove participent";

            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if(result == DialogResult.Yes)
            {
                ActivityId = int.Parse(textBoxActivity.Text);
                int StudentId = int.Parse(SelectParticipentIdTextBox.Text);
                ActivityService activityService = new ActivityService();
                activityService.RemoveParticipent(StudentId, ActivityId);
                LoadActivityStudent(ActivityId);
                SelectParticipentIdTextBox.Clear();
            }
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            ActivityId = int.Parse(textBoxActivity.Text);
            int teacherId = int.Parse(SelectTeacherIdTextBox.Text);
            ActivityService activityService = new ActivityService();
            activityService.AddSupervisor(teacherId, ActivityId);
            LoadActivityTeachers(ActivityId);
            SelectTeacherIdTextBox.Clear();
        }

        private void RemoveTeacherButton_Click(object sender, EventArgs e)
        {
            string message = "Are sure you want to remove the Supervisor?";
            string title = "Remove Supervisor";

            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                ActivityId = int.Parse(textBoxActivity.Text);
                int teacherId = int.Parse(SelectTeacherIdTextBox.Text);
                ActivityService activityService = new ActivityService();
                activityService.RemoveSupervisor(teacherId, ActivityId);
                LoadActivityTeachers(ActivityId);
                SelectTeacherIdTextBox.Clear();
            }
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            string description = DescriptionTextBox.Text;
            string day = startDaysTextBox.Text;
            string month = startMonthtextBox.Text;
            string year = startYearTextBox.Text;
            string time = startTimeTextBox.Text;
            string endTime = endTimeTextBox.Text;

            DateTime startDate = DateTime.Parse($"{day}-{month}-{year} {time}");
            DateTime endDate = DateTime.Parse($"{day}-{month}-{year} {endTime}");
            ActivityService activityService = new ActivityService();

            activityService.AddActivity(description, startDate, endDate);
            LoadActivitiesList();
        }

        private void RemoveActivityButton_Click(object sender, EventArgs e)
        {
            string message = "Are sure you want to remove the Activity?";
            string title = "Remove Activity";

            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                int activityId = int.Parse(ChangeActivityTextBox.Text);
                ActivityService activityService = new ActivityService();
                activityService.RemoveActivity(activityId);
                LoadActivitiesList();
            }
        }

        private void ChangeActivityDescriptionButton_Click(object sender, EventArgs e)
        {
            string newDescription = ChangeDescriptionTextBox.Text;
            int activityId = int.Parse(ChangeActivityTextBox.Text);
            ActivityService activityService = new ActivityService();
            activityService.ChangeDescription(newDescription, activityId);
            LoadActivitiesList();
            ChangeDescriptionTextBox.Clear();
            ChangeActivityTextBox.Clear();
        }

        private void ChangeActivityDateButton_Click(object sender, EventArgs e)
        {
            int activityId = int.Parse(ChangeActivityTextBox.Text);
            string day = changeDayTextBox.Text;
            string month = changeMonthTextBox.Text;
            string year = ChangeYearTextBox.Text;
            string time = changeStartTimeTextBox.Text;
            string endTime = changeEndTimeTextBox.Text;

            DateTime startDate = DateTime.Parse($"{day}-{month}-{year} {time}");
            DateTime endDate = DateTime.Parse($"{day}-{month}-{year} {endTime}");
            ActivityService activityService = new ActivityService();

            activityService.ChangeActivityDateTime(activityId, startDate, endDate);
            LoadActivitiesList();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();
            HashSalt hashSalt = new HashSalt();
          
            foreach (User user in users)
            {  
                if (user.UserName == userNameTextBox.Text && user.Password == hashSalt.HashPassword(passwordTextBox.Text,
                    user.Salt, hashSalt.Iterations, hashSalt.Hash))
                { 
                    showPanel("Dashboard");
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();
                    
                }
                else
                {
                    wrongPassWarningLabel.Show();
                    ChangePassLinkLabel.Show();
                }
            } 
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            if (registerSecondPassTextBox.Text != registerFirstPassTextBox.Text)
            {
                registerPasswEnteredWarningLabel.Show();
            }
            else
            {
                registerPasswEnteredWarningLabel.Hide();
            }

            if (registerFirstPassTextBox.Text == registerSecondPassTextBox.Text && registerFirstPassTextBox.Text != string.Empty &&
                registerAwnserTextBox.Text != string.Empty && registerQuestionTextBox.Text != string.Empty)
            {
                licenseKeyGroupBox.Show();
            }
            else
            {
                registerEnterAllFieldsWarningLabel.Show();
            }
        }

        private void FinalAddUserButton_Click(object sender, EventArgs e)
        { 
            string licenseKey = "XsZAb - tgz3PsD - qYh69un - WQCEx";

            UserService userService = new UserService();
            if (compareLicenseTextBox.Text == licenseKey )
            {
                userService.CreateUser(registerUserNameTextBox.Text, registerFirstPassTextBox.Text,
                    registerQuestionTextBox.Text, registerAwnserTextBox.Text);
            }

            MessageBox.Show("Registration complete");
            showPanel("LogIn");
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();
            foreach (User user in users)
            {
                // if the username and anwser of the secret question are correct and all fields are correctly filled 
                // the password will be changed
                if (changePassSecondTextBox.Text != changePassFirstTextBox.Text)
                {
                    changePassNoMatchWarningLabel.Show();
                }
                else
                {
                    changePassNoMatchWarningLabel.Hide();
                }

                if (changePassUserNameTextBox.Text == user.UserName && secretAwnserTextBox.Text == user.SecretAwnser
                    && changePassFirstTextBox.Text == changePassSecondTextBox.Text && changePassFirstTextBox.Text != string.Empty)
                {
                    userService.ChangePassword(changePassUserNameTextBox.Text, secretAwnserTextBox.Text, changePassFirstTextBox.Text);
                    MessageBox.Show("Your password has been changed.");
                    logInGroupBox.Show();
                    changePasswordGroupBox.Hide();
                    changePassAllFieldsWarningLabel.Hide();
                }
                else
                {
                    changePassAllFieldsWarningLabel.Show();
                }
            }    
        }

        private void ReturnToLogInButton_Click(object sender, EventArgs e)
        {
            
            showPanel("LogIn");
            logInGroupBox.Show();
            changePasswordGroupBox.Hide();
            wrongPassWarningLabel.Hide();
            ChangePassLinkLabel.Hide();
        }

        private void ChangePassBackToLogInButton_Click(object sender, EventArgs e)
        {
            changePasswordGroupBox.Hide();
            logInGroupBox.Show();
            wrongPassWarningLabel.Hide();
            ChangePassLinkLabel.Hide();
            changePassAllFieldsWarningLabel.Hide();
        }

        /* ------- Link Labels ------- */

        private void ChangePassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInGroupBox.Hide();
            changePasswordGroupBox.Visible = true;
            changePasswordGroupBox.Show();
        }


        /*---------- Textbox behavior -----------*/

        private void changePassUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();
            foreach (User user in users)
            {
                if(user.UserName == changePassUserNameTextBox.Text)
                {
                    secretQuestionLabel.Text = user.SecretQuestion;
                }
            }
        }    
    }
}
