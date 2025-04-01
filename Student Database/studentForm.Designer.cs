namespace Student_Database
{
    partial class studentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            First_Name = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            File = new ToolStripMenuItem();
            Import = new ToolStripMenuItem();
            Save = new ToolStripMenuItem();
            Export = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            Add = new ToolStripMenuItem();
            Last_Name = new TextBox();
            label3 = new Label();
            Address = new TextBox();
            label4 = new Label();
            City = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            GPA = new TextBox();
            label8 = new Label();
            States = new ComboBox();
            Majors = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            Exit = new Button();
            Status = new ComboBox();
            ID = new TextBox();
            label9 = new Label();
            Added = new TextBox();
            Changed = new TextBox();
            label12 = new Label();
            label13 = new Label();
            New_ID = new TextBox();
            label14 = new Label();
            Succes = new TextBox();
            Label15 = new Label();
            Search = new TextBox();
            ZipCode = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // First_Name
            // 
            First_Name.Location = new Point(81, 62);
            First_Name.Name = "First_Name";
            First_Name.Size = new Size(185, 23);
            First_Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { File, About });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(447, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { Import, Save, Export });
            File.Name = "File";
            File.Size = new Size(37, 20);
            File.Text = "File";
            // 
            // Import
            // 
            Import.Name = "Import";
            Import.Size = new Size(180, 22);
            Import.Text = "Import";
            Import.Click += GetStudent_Click;
            // 
            // Save
            // 
            Save.Name = "Save";
            Save.Size = new Size(180, 22);
            Save.Text = "Save";
            Save.Click += UpdateStudent_Click;
            // 
            // Export
            // 
            Export.Name = "Export";
            Export.Size = new Size(180, 22);
            Export.Text = "Export";
            // 
            // About
            // 
            About.DropDownItems.AddRange(new ToolStripItem[] { Add });
            About.Name = "About";
            About.Size = new Size(52, 20);
            About.Text = "About";
            About.Click += AddStudent_Click;
            // 
            // Add
            // 
            Add.Name = "Add";
            Add.Size = new Size(96, 22);
            Add.Text = "Add";
            Add.Click += AddStudent_Click;
            // 
            // Last_Name
            // 
            Last_Name.Location = new Point(81, 91);
            Last_Name.Name = "Last_Name";
            Last_Name.Size = new Size(185, 23);
            Last_Name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Street:";
            // 
            // Address
            // 
            Address.Location = new Point(81, 120);
            Address.Name = "Address";
            Address.Size = new Size(185, 23);
            Address.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "City:";
            // 
            // City
            // 
            City.Location = new Point(81, 149);
            City.Name = "City";
            City.Size = new Size(166, 23);
            City.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "State:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 30);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 12;
            label6.Text = "New ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 273);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "GPA:";
            // 
            // GPA
            // 
            GPA.Location = new Point(81, 265);
            GPA.Name = "GPA";
            GPA.Size = new Size(64, 23);
            GPA.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 372);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 16;
            label8.Text = "Status Code:";
            // 
            // States
            // 
            States.FormattingEnabled = true;
            States.Location = new Point(81, 178);
            States.Name = "States";
            States.Size = new Size(185, 23);
            States.TabIndex = 18;
            // 
            // Majors
            // 
            Majors.FormattingEnabled = true;
            Majors.Location = new Point(81, 236);
            Majors.Name = "Majors";
            Majors.Size = new Size(185, 23);
            Majors.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 215);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 20;
            label10.Text = "Zip Code:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 244);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 21;
            label11.Text = "Major:";
            // 
            // Exit
            // 
            Exit.Location = new Point(387, 372);
            Exit.Name = "Exit";
            Exit.Size = new Size(48, 23);
            Exit.TabIndex = 22;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Location = new Point(83, 369);
            Status.Name = "Status";
            Status.Size = new Size(92, 23);
            Status.TabIndex = 23;
            // 
            // ID
            // 
            ID.Location = new Point(115, 32);
            ID.Name = "ID";
            ID.Size = new Size(100, 23);
            ID.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 35);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 25;
            label9.Text = "ID:";
            // 
            // Added
            // 
            Added.Location = new Point(115, 294);
            Added.Name = "Added";
            Added.ReadOnly = true;
            Added.Size = new Size(100, 23);
            Added.TabIndex = 26;
            // 
            // Changed
            // 
            Changed.Location = new Point(115, 323);
            Changed.Name = "Changed";
            Changed.ReadOnly = true;
            Changed.Size = new Size(100, 23);
            Changed.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 302);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 28;
            label12.Text = "Added:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 331);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 29;
            label13.Text = "Changed:";
            // 
            // New_ID
            // 
            New_ID.Location = new Point(320, 27);
            New_ID.Name = "New_ID";
            New_ID.ReadOnly = true;
            New_ID.Size = new Size(100, 23);
            New_ID.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(286, 326);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 34;
            label14.Text = "Succes:";
            // 
            // Succes
            // 
            Succes.Location = new Point(338, 323);
            Succes.Name = "Succes";
            Succes.Size = new Size(97, 23);
            Succes.TabIndex = 33;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(290, 297);
            Label15.Name = "Label15";
            Label15.Size = new Size(42, 15);
            Label15.TabIndex = 32;
            Label15.Text = "Search";
            // 
            // Search
            // 
            Search.Location = new Point(338, 294);
            Search.Name = "Search";
            Search.Size = new Size(97, 23);
            Search.TabIndex = 31;
            // 
            // ZipCode
            // 
            ZipCode.Location = new Point(76, 207);
            ZipCode.Name = "ZipCode";
            ZipCode.Size = new Size(99, 23);
            ZipCode.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 99);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 36;
            label2.Text = "Last Name:";
            // 
            // studentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 401);
            Controls.Add(label2);
            Controls.Add(ZipCode);
            Controls.Add(label14);
            Controls.Add(Succes);
            Controls.Add(Label15);
            Controls.Add(Search);
            Controls.Add(New_ID);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(Changed);
            Controls.Add(Added);
            Controls.Add(label9);
            Controls.Add(ID);
            Controls.Add(Status);
            Controls.Add(Exit);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Majors);
            Controls.Add(States);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(GPA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(City);
            Controls.Add(label3);
            Controls.Add(Address);
            Controls.Add(Last_Name);
            Controls.Add(label1);
            Controls.Add(First_Name);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "studentForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox First_Name;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem File;
        private ToolStripMenuItem Import;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem Export;
        private TextBox Last_Name;
        private Label label3;
        private TextBox Address;
        private Label label4;
        private TextBox City;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox GPA;
        private Label label8;
        private ComboBox States;
        private ComboBox Majors;
        private Label label10;
        private Label label11;
        private Button Exit;
        private ComboBox Status;
        private TextBox ID;
        private Label label9;
        private TextBox Added;
        private TextBox Changed;
        private Label label12;
        private Label label13;
        private TextBox New_ID;
        private Label label14;
        private TextBox Succes;
        private Label Label15;
        private TextBox Search;
        private ToolStripMenuItem About;
        private TextBox ZipCode;
        private Label label2;
        private ToolStripMenuItem Add;
    }
}
