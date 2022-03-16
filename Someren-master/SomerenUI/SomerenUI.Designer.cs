namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reveneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.teacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherIsSupervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.RoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.listBoxDrinks = new System.Windows.Forms.ListBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlRevenueReport = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.monthCalendarRevenue = new System.Windows.Forms.MonthCalendar();
            this.listViewRevenue = new System.Windows.Forms.ListView();
            this.columnSales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTurnover = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumberCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlRevenueReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(627, 0);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(311, 270);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.barToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click_1);
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.reveneToolStripMenuItem});
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.barToolStripMenuItem.Text = "Bar";
            // 
            // drinkToolStripMenuItem
            // 
            this.drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            this.drinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drinkToolStripMenuItem.Text = "Drinks supply";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // reveneToolStripMenuItem
            // 
            this.reveneToolStripMenuItem.Name = "reveneToolStripMenuItem";
            this.reveneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reveneToolStripMenuItem.Text = "Revenue Report";
            this.reveneToolStripMenuItem.Click += new System.EventHandler(this.reveneToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(12, 27);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(938, 466);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.lbl_Students);
            this.pnlStudents.Location = new System.Drawing.Point(12, 24);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(938, 466);
            this.pnlStudents.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentFirstName,
            this.studentLastName,
            this.studentDOB});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Tag = "";
            this.studentID.Text = "ID";
            // 
            // studentFirstName
            // 
            this.studentFirstName.Tag = "";
            this.studentFirstName.Text = "Firstname";
            this.studentFirstName.Width = 100;
            // 
            // studentLastName
            // 
            this.studentLastName.Text = "Lastname";
            this.studentLastName.Width = 100;
            // 
            // studentDOB
            // 
            this.studentDOB.Tag = "";
            this.studentDOB.Text = "Date of Birth";
            this.studentDOB.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(805, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.listViewTeachers);
            this.pnlTeachers.Controls.Add(this.pictureBox2);
            this.pnlTeachers.Controls.Add(this.lbl_Teachers);
            this.pnlTeachers.Location = new System.Drawing.Point(12, 24);
            this.pnlTeachers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(938, 468);
            this.pnlTeachers.TabIndex = 6;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teacherID,
            this.teacherFirstName,
            this.TeacherLastName,
            this.TeacherIsSupervisor});
            this.listViewTeachers.GridLines = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(18, 46);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(749, 299);
            this.listViewTeachers.TabIndex = 2;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // teacherID
            // 
            this.teacherID.Text = "ID";
            // 
            // teacherFirstName
            // 
            this.teacherFirstName.Text = "Firstname";
            this.teacherFirstName.Width = 80;
            // 
            // TeacherLastName
            // 
            this.TeacherLastName.Text = "Lastname";
            this.TeacherLastName.Width = 100;
            // 
            // TeacherIsSupervisor
            // 
            this.TeacherIsSupervisor.Text = "Supervisor";
            this.TeacherIsSupervisor.Width = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(808, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 123);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_Teachers.Location = new System.Drawing.Point(14, 14);
            this.lbl_Teachers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(115, 29);
            this.lbl_Teachers.TabIndex = 0;
            this.lbl_Teachers.Text = "Teachers";
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.pictureBox3);
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Controls.Add(this.lbl_Rooms);
            this.pnlRooms.Location = new System.Drawing.Point(0, 24);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(948, 447);
            this.pnlRooms.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(815, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 123);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomNumber,
            this.Capacity,
            this.Type});
            this.listViewRooms.GridLines = true;
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(18, 60);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(770, 362);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Text = "room_nr";
            this.RoomNumber.Width = 80;
            // 
            // Capacity
            // 
            this.Capacity.Text = "nrOfBeds";
            this.Capacity.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "IsTeacherRoom";
            this.Type.Width = 120;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rooms.Location = new System.Drawing.Point(14, 22);
            this.lbl_Rooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(90, 29);
            this.lbl_Rooms.TabIndex = 0;
            this.lbl_Rooms.Text = "Rooms";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btn_Checkout);
            this.pnlRegister.Controls.Add(this.listBoxDrinks);
            this.pnlRegister.Controls.Add(this.listBoxStudents);
            this.pnlRegister.Controls.Add(this.lbl_Register);
            this.pnlRegister.Controls.Add(this.pictureBox4);
            this.pnlRegister.Location = new System.Drawing.Point(0, 23);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(962, 449);
            this.pnlRegister.TabIndex = 9;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Location = new System.Drawing.Point(692, 321);
            this.btn_Checkout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(87, 29);
            this.btn_Checkout.TabIndex = 15;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // listBoxDrinks
            // 
            this.listBoxDrinks.FormattingEnabled = true;
            this.listBoxDrinks.Location = new System.Drawing.Point(332, 61);
            this.listBoxDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxDrinks.Name = "listBoxDrinks";
            this.listBoxDrinks.Size = new System.Drawing.Size(303, 290);
            this.listBoxDrinks.TabIndex = 14;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(20, 61);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(303, 290);
            this.listBoxStudents.TabIndex = 13;
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_Register.Location = new System.Drawing.Point(15, 24);
            this.lbl_Register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(104, 29);
            this.lbl_Register.TabIndex = 10;
            this.lbl_Register.Text = "Register";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(820, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 123);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pnlRevenueReport
            // 
            this.pnlRevenueReport.Controls.Add(this.listViewRevenue);
            this.pnlRevenueReport.Controls.Add(this.monthCalendarRevenue);
            this.pnlRevenueReport.Controls.Add(this.lbl_revenue);
            this.pnlRevenueReport.Controls.Add(this.pictureBox5);
            this.pnlRevenueReport.Location = new System.Drawing.Point(0, 22);
            this.pnlRevenueReport.Name = "pnlRevenueReport";
            this.pnlRevenueReport.Size = new System.Drawing.Size(962, 481);
            this.pnlRevenueReport.TabIndex = 16;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(816, -2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 123);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_revenue.Location = new System.Drawing.Point(12, 16);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(179, 29);
            this.lbl_revenue.TabIndex = 11;
            this.lbl_revenue.Text = "Revenue report";
            // 
            // monthCalendarRevenue
            // 
            this.monthCalendarRevenue.Location = new System.Drawing.Point(416, 62);
            this.monthCalendarRevenue.Name = "monthCalendarRevenue";
            this.monthCalendarRevenue.TabIndex = 12;
            this.monthCalendarRevenue.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listViewRevenue
            // 
            this.listViewRevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSales,
            this.columnTurnover,
            this.columnNumberCustomer});
            this.listViewRevenue.GridLines = true;
            this.listViewRevenue.HideSelection = false;
            this.listViewRevenue.Location = new System.Drawing.Point(12, 62);
            this.listViewRevenue.Name = "listViewRevenue";
            this.listViewRevenue.Size = new System.Drawing.Size(293, 213);
            this.listViewRevenue.TabIndex = 13;
            this.listViewRevenue.UseCompatibleStateImageBehavior = false;
            this.listViewRevenue.View = System.Windows.Forms.View.Details;
            this.listViewRevenue.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnSales
            // 
            this.columnSales.Text = "Sales";
            this.columnSales.Width = 90;
            // 
            // columnTurnover
            // 
            this.columnTurnover.Text = "Turnover";
            this.columnTurnover.Width = 88;
            // 
            // columnNumberCustomer
            // 
            this.columnNumberCustomer.Text = "Number of customers";
            this.columnNumberCustomer.Width = 112;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnlRevenueReport);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlRevenueReport.ResumeLayout(false);
            this.pnlRevenueReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentFirstName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader teacherID;
        private System.Windows.Forms.ColumnHeader teacherFirstName;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.ColumnHeader TeacherLastName;
        private System.Windows.Forms.ColumnHeader TeacherIsSupervisor;
        private System.Windows.Forms.ColumnHeader studentLastName;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader RoomNumber;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reveneToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.ListBox listBoxDrinks;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Panel pnlRevenueReport;
        private System.Windows.Forms.MonthCalendar monthCalendarRevenue;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListView listViewRevenue;
        private System.Windows.Forms.ColumnHeader columnSales;
        private System.Windows.Forms.ColumnHeader columnTurnover;
        private System.Windows.Forms.ColumnHeader columnNumberCustomer;
    }
}

