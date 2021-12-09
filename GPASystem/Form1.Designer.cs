
namespace GPASystem
{
    partial class Form1
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.invalidLoginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.printTranscriptButton = new System.Windows.Forms.Button();
            this.editGradesButton = new System.Windows.Forms.Button();
            this.addNewGradesButton = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.TextBox();
            this.selectStudentCoursePanel = new System.Windows.Forms.Panel();
            this.invalidStudentIDEGLabel = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.backToMainButton = new System.Windows.Forms.Button();
            this.studentCoursesListBox = new System.Windows.Forms.ListBox();
            this.submitStudentID = new System.Windows.Forms.Button();
            this.studentIDTextEG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editGradePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.submitNewGradeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newGradeComboBox = new System.Windows.Forms.ComboBox();
            this.currentGradeTextBox = new System.Windows.Forms.TextBox();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.currentGradeLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.printTranscriptPanel = new System.Windows.Forms.Panel();
            this.invalidStudentIDTSLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.overallGPATSTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentIDTSTB = new System.Windows.Forms.TextBox();
            this.studentNameTSTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transcriptCoursesListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.submitStudentIDTranscript = new System.Windows.Forms.Button();
            this.studentIDTS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.importCoursesWindow = new System.Windows.Forms.OpenFileDialog();
            this.errorUploadingPanel = new System.Windows.Forms.Panel();
            this.errorToMain = new System.Windows.Forms.Button();
            this.errorUploadText = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.selectStudentCoursePanel.SuspendLayout();
            this.editGradePanel.SuspendLayout();
            this.printTranscriptPanel.SuspendLayout();
            this.errorUploadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.invalidLoginLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameText);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.loginText);
            this.loginPanel.Location = new System.Drawing.Point(6, 9);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(910, 554);
            this.loginPanel.TabIndex = 0;
            // 
            // invalidLoginLabel
            // 
            this.invalidLoginLabel.AutoSize = true;
            this.invalidLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLoginLabel.Location = new System.Drawing.Point(178, 408);
            this.invalidLoginLabel.Name = "invalidLoginLabel";
            this.invalidLoginLabel.Size = new System.Drawing.Size(412, 29);
            this.invalidLoginLabel.TabIndex = 12;
            this.invalidLoginLabel.Text = "Error! Invalid Username or Password!";
            this.invalidLoginLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(246, 452);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(248, 48);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(246, 364);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(241, 38);
            this.passwordText.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(241, 320);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(162, 38);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(246, 255);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(241, 38);
            this.usernameText.TabIndex = 8;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(241, 207);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(168, 38);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.Location = new System.Drawing.Point(220, 58);
            this.loginText.Multiline = true;
            this.loginText.Name = "loginText";
            this.loginText.ReadOnly = true;
            this.loginText.Size = new System.Drawing.Size(465, 121);
            this.loginText.TabIndex = 6;
            this.loginText.TabStop = false;
            this.loginText.Text = "Registrar System Login";
            this.loginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.logoutButton);
            this.mainPanel.Controls.Add(this.printTranscriptButton);
            this.mainPanel.Controls.Add(this.editGradesButton);
            this.mainPanel.Controls.Add(this.addNewGradesButton);
            this.mainPanel.Controls.Add(this.mainText);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(907, 554);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Visible = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(715, 513);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(180, 35);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // printTranscriptButton
            // 
            this.printTranscriptButton.BackColor = System.Drawing.Color.White;
            this.printTranscriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTranscriptButton.Location = new System.Drawing.Point(222, 405);
            this.printTranscriptButton.Name = "printTranscriptButton";
            this.printTranscriptButton.Size = new System.Drawing.Size(463, 92);
            this.printTranscriptButton.TabIndex = 3;
            this.printTranscriptButton.Text = "Print Transcript";
            this.printTranscriptButton.UseVisualStyleBackColor = false;
            this.printTranscriptButton.Click += new System.EventHandler(this.printTranscriptButton_Click);
            // 
            // editGradesButton
            // 
            this.editGradesButton.BackColor = System.Drawing.Color.White;
            this.editGradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGradesButton.Location = new System.Drawing.Point(221, 280);
            this.editGradesButton.Name = "editGradesButton";
            this.editGradesButton.Size = new System.Drawing.Size(463, 92);
            this.editGradesButton.TabIndex = 2;
            this.editGradesButton.Text = "Edit Grades";
            this.editGradesButton.UseVisualStyleBackColor = false;
            this.editGradesButton.Click += new System.EventHandler(this.editGradesButton_Click);
            // 
            // addNewGradesButton
            // 
            this.addNewGradesButton.BackColor = System.Drawing.Color.White;
            this.addNewGradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewGradesButton.Location = new System.Drawing.Point(222, 146);
            this.addNewGradesButton.Name = "addNewGradesButton";
            this.addNewGradesButton.Size = new System.Drawing.Size(463, 95);
            this.addNewGradesButton.TabIndex = 1;
            this.addNewGradesButton.Text = "Add New Grades";
            this.addNewGradesButton.UseVisualStyleBackColor = false;
            this.addNewGradesButton.Click += new System.EventHandler(this.addNewGradesButton_Click);
            // 
            // mainText
            // 
            this.mainText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.Location = new System.Drawing.Point(220, 37);
            this.mainText.Multiline = true;
            this.mainText.Name = "mainText";
            this.mainText.ReadOnly = true;
            this.mainText.Size = new System.Drawing.Size(465, 76);
            this.mainText.TabIndex = 0;
            this.mainText.TabStop = false;
            this.mainText.Text = "EKU Registrar";
            this.mainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectStudentCoursePanel
            // 
            this.selectStudentCoursePanel.Controls.Add(this.invalidStudentIDEGLabel);
            this.selectStudentCoursePanel.Controls.Add(this.textBox8);
            this.selectStudentCoursePanel.Controls.Add(this.backToMainButton);
            this.selectStudentCoursePanel.Controls.Add(this.studentCoursesListBox);
            this.selectStudentCoursePanel.Controls.Add(this.submitStudentID);
            this.selectStudentCoursePanel.Controls.Add(this.studentIDTextEG);
            this.selectStudentCoursePanel.Controls.Add(this.label1);
            this.selectStudentCoursePanel.Location = new System.Drawing.Point(6, 9);
            this.selectStudentCoursePanel.Name = "selectStudentCoursePanel";
            this.selectStudentCoursePanel.Size = new System.Drawing.Size(913, 557);
            this.selectStudentCoursePanel.TabIndex = 2;
            this.selectStudentCoursePanel.Visible = false;
            // 
            // invalidStudentIDEGLabel
            // 
            this.invalidStudentIDEGLabel.AutoSize = true;
            this.invalidStudentIDEGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidStudentIDEGLabel.Location = new System.Drawing.Point(37, 283);
            this.invalidStudentIDEGLabel.Name = "invalidStudentIDEGLabel";
            this.invalidStudentIDEGLabel.Size = new System.Drawing.Size(205, 29);
            this.invalidStudentIDEGLabel.TabIndex = 15;
            this.invalidStudentIDEGLabel.Text = "Invalid Student ID!";
            this.invalidStudentIDEGLabel.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(214, 22);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(471, 76);
            this.textBox8.TabIndex = 14;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Edit Grade";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backToMainButton
            // 
            this.backToMainButton.BackColor = System.Drawing.Color.White;
            this.backToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainButton.Location = new System.Drawing.Point(10, 484);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(143, 67);
            this.backToMainButton.TabIndex = 4;
            this.backToMainButton.Text = "Back";
            this.backToMainButton.UseVisualStyleBackColor = false;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click_1);
            // 
            // studentCoursesListBox
            // 
            this.studentCoursesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCoursesListBox.FormattingEnabled = true;
            this.studentCoursesListBox.ItemHeight = 31;
            this.studentCoursesListBox.Location = new System.Drawing.Point(292, 134);
            this.studentCoursesListBox.Name = "studentCoursesListBox";
            this.studentCoursesListBox.Size = new System.Drawing.Size(624, 407);
            this.studentCoursesListBox.TabIndex = 3;
            this.studentCoursesListBox.SelectedIndexChanged += new System.EventHandler(this.studentCoursesListBox_SelectedIndexChanged);
            // 
            // submitStudentID
            // 
            this.submitStudentID.BackColor = System.Drawing.Color.White;
            this.submitStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitStudentID.Location = new System.Drawing.Point(37, 207);
            this.submitStudentID.Name = "submitStudentID";
            this.submitStudentID.Size = new System.Drawing.Size(217, 53);
            this.submitStudentID.TabIndex = 2;
            this.submitStudentID.Text = "Submit";
            this.submitStudentID.UseVisualStyleBackColor = false;
            this.submitStudentID.Click += new System.EventHandler(this.submitStudentID_Click);
            // 
            // studentIDTextEG
            // 
            this.studentIDTextEG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTextEG.Location = new System.Drawing.Point(37, 149);
            this.studentIDTextEG.Name = "studentIDTextEG";
            this.studentIDTextEG.Size = new System.Drawing.Size(217, 38);
            this.studentIDTextEG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student ID";
            // 
            // editGradePanel
            // 
            this.editGradePanel.Controls.Add(this.button2);
            this.editGradePanel.Controls.Add(this.submitNewGradeButton);
            this.editGradePanel.Controls.Add(this.label2);
            this.editGradePanel.Controls.Add(this.newGradeComboBox);
            this.editGradePanel.Controls.Add(this.currentGradeTextBox);
            this.editGradePanel.Controls.Add(this.courseNameTextBox);
            this.editGradePanel.Controls.Add(this.studentNameTextBox);
            this.editGradePanel.Controls.Add(this.currentGradeLabel);
            this.editGradePanel.Controls.Add(this.textBox2);
            this.editGradePanel.Controls.Add(this.courseNameLabel);
            this.editGradePanel.Controls.Add(this.studentNameLabel);
            this.editGradePanel.Location = new System.Drawing.Point(6, 9);
            this.editGradePanel.Name = "editGradePanel";
            this.editGradePanel.Size = new System.Drawing.Size(913, 558);
            this.editGradePanel.TabIndex = 3;
            this.editGradePanel.TabStop = true;
            this.editGradePanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(55, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // submitNewGradeButton
            // 
            this.submitNewGradeButton.BackColor = System.Drawing.Color.White;
            this.submitNewGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitNewGradeButton.Location = new System.Drawing.Point(696, 408);
            this.submitNewGradeButton.Name = "submitNewGradeButton";
            this.submitNewGradeButton.Size = new System.Drawing.Size(156, 52);
            this.submitNewGradeButton.TabIndex = 9;
            this.submitNewGradeButton.Text = "Submit";
            this.submitNewGradeButton.UseVisualStyleBackColor = false;
            this.submitNewGradeButton.Click += new System.EventHandler(this.submitNewGradeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Grade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // newGradeComboBox
            // 
            this.newGradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGradeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGradeComboBox.FormattingEnabled = true;
            this.newGradeComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "M",
            "W"});
            this.newGradeComboBox.Location = new System.Drawing.Point(696, 329);
            this.newGradeComboBox.Name = "newGradeComboBox";
            this.newGradeComboBox.Size = new System.Drawing.Size(156, 39);
            this.newGradeComboBox.TabIndex = 7;
            // 
            // currentGradeTextBox
            // 
            this.currentGradeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGradeTextBox.Location = new System.Drawing.Point(277, 329);
            this.currentGradeTextBox.Name = "currentGradeTextBox";
            this.currentGradeTextBox.ReadOnly = true;
            this.currentGradeTextBox.Size = new System.Drawing.Size(111, 38);
            this.currentGradeTextBox.TabIndex = 6;
            this.currentGradeTextBox.Text = "Grade";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameTextBox.Location = new System.Drawing.Point(277, 250);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.ReadOnly = true;
            this.courseNameTextBox.Size = new System.Drawing.Size(181, 38);
            this.courseNameTextBox.TabIndex = 5;
            this.courseNameTextBox.Text = "Course";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(277, 180);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.ReadOnly = true;
            this.studentNameTextBox.Size = new System.Drawing.Size(258, 38);
            this.studentNameTextBox.TabIndex = 4;
            this.studentNameTextBox.Text = "Name";
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.studentNameTextBox_TextChanged);
            // 
            // currentGradeLabel
            // 
            this.currentGradeLabel.AutoSize = true;
            this.currentGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGradeLabel.Location = new System.Drawing.Point(50, 329);
            this.currentGradeLabel.Name = "currentGradeLabel";
            this.currentGradeLabel.Size = new System.Drawing.Size(212, 36);
            this.currentGradeLabel.TabIndex = 3;
            this.currentGradeLabel.Text = "Current Grade:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(226, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(465, 62);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Edit Grade";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(50, 250);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(204, 36);
            this.courseNameLabel.TabIndex = 1;
            this.courseNameLabel.Text = "Course Name:";
            this.courseNameLabel.Click += new System.EventHandler(this.courseNameLabel_Click);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(43, 182);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(211, 36);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "Student Name:";
            this.studentNameLabel.Click += new System.EventHandler(this.studentNameLabel_Click);
            // 
            // printTranscriptPanel
            // 
            this.printTranscriptPanel.Controls.Add(this.invalidStudentIDTSLabel);
            this.printTranscriptPanel.Controls.Add(this.textBox7);
            this.printTranscriptPanel.Controls.Add(this.overallGPATSTB);
            this.printTranscriptPanel.Controls.Add(this.label7);
            this.printTranscriptPanel.Controls.Add(this.studentIDTSTB);
            this.printTranscriptPanel.Controls.Add(this.studentNameTSTB);
            this.printTranscriptPanel.Controls.Add(this.label6);
            this.printTranscriptPanel.Controls.Add(this.transcriptCoursesListBox);
            this.printTranscriptPanel.Controls.Add(this.label5);
            this.printTranscriptPanel.Controls.Add(this.label4);
            this.printTranscriptPanel.Controls.Add(this.button1);
            this.printTranscriptPanel.Controls.Add(this.submitStudentIDTranscript);
            this.printTranscriptPanel.Controls.Add(this.studentIDTS);
            this.printTranscriptPanel.Controls.Add(this.label3);
            this.printTranscriptPanel.Location = new System.Drawing.Point(6, 9);
            this.printTranscriptPanel.Name = "printTranscriptPanel";
            this.printTranscriptPanel.Size = new System.Drawing.Size(913, 557);
            this.printTranscriptPanel.TabIndex = 5;
            this.printTranscriptPanel.Visible = false;
            this.printTranscriptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.printTranscriptPanel_Paint);
            // 
            // invalidStudentIDTSLabel
            // 
            this.invalidStudentIDTSLabel.AutoSize = true;
            this.invalidStudentIDTSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidStudentIDTSLabel.Location = new System.Drawing.Point(44, 311);
            this.invalidStudentIDTSLabel.Name = "invalidStudentIDTSLabel";
            this.invalidStudentIDTSLabel.Size = new System.Drawing.Size(205, 29);
            this.invalidStudentIDTSLabel.TabIndex = 14;
            this.invalidStudentIDTSLabel.Text = "Invalid Student ID!";
            this.invalidStudentIDTSLabel.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(220, 26);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(471, 76);
            this.textBox7.TabIndex = 13;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Print Transcript";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // overallGPATSTB
            // 
            this.overallGPATSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallGPATSTB.Location = new System.Drawing.Point(564, 259);
            this.overallGPATSTB.Name = "overallGPATSTB";
            this.overallGPATSTB.ReadOnly = true;
            this.overallGPATSTB.Size = new System.Drawing.Size(337, 38);
            this.overallGPATSTB.TabIndex = 12;
            this.overallGPATSTB.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "  Overall GPA: ";
            // 
            // studentIDTSTB
            // 
            this.studentIDTSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTSTB.Location = new System.Drawing.Point(564, 205);
            this.studentIDTSTB.Name = "studentIDTSTB";
            this.studentIDTSTB.ReadOnly = true;
            this.studentIDTSTB.Size = new System.Drawing.Size(337, 38);
            this.studentIDTSTB.TabIndex = 10;
            this.studentIDTSTB.TabStop = false;
            // 
            // studentNameTSTB
            // 
            this.studentNameTSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTSTB.Location = new System.Drawing.Point(564, 149);
            this.studentNameTSTB.Name = "studentNameTSTB";
            this.studentNameTSTB.ReadOnly = true;
            this.studentNameTSTB.Size = new System.Drawing.Size(337, 38);
            this.studentNameTSTB.TabIndex = 9;
            this.studentNameTSTB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Courses:";
            // 
            // transcriptCoursesListBox
            // 
            this.transcriptCoursesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcriptCoursesListBox.FormattingEnabled = true;
            this.transcriptCoursesListBox.ItemHeight = 31;
            this.transcriptCoursesListBox.Location = new System.Drawing.Point(474, 320);
            this.transcriptCoursesListBox.Name = "transcriptCoursesListBox";
            this.transcriptCoursesListBox.Size = new System.Drawing.Size(433, 221);
            this.transcriptCoursesListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitStudentIDTranscript
            // 
            this.submitStudentIDTranscript.BackColor = System.Drawing.Color.White;
            this.submitStudentIDTranscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitStudentIDTranscript.Location = new System.Drawing.Point(55, 221);
            this.submitStudentIDTranscript.Name = "submitStudentIDTranscript";
            this.submitStudentIDTranscript.Size = new System.Drawing.Size(182, 56);
            this.submitStudentIDTranscript.TabIndex = 2;
            this.submitStudentIDTranscript.Text = "Submit";
            this.submitStudentIDTranscript.UseVisualStyleBackColor = false;
            this.submitStudentIDTranscript.Click += new System.EventHandler(this.submitStudentIDTranscript_Click);
            // 
            // studentIDTS
            // 
            this.studentIDTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTS.Location = new System.Drawing.Point(55, 173);
            this.studentIDTS.Name = "studentIDTS";
            this.studentIDTS.Size = new System.Drawing.Size(182, 38);
            this.studentIDTS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Student ID";
            // 
            // errorUploadingPanel
            // 
            this.errorUploadingPanel.Controls.Add(this.errorToMain);
            this.errorUploadingPanel.Controls.Add(this.errorUploadText);
            this.errorUploadingPanel.Location = new System.Drawing.Point(6, 5);
            this.errorUploadingPanel.Name = "errorUploadingPanel";
            this.errorUploadingPanel.Size = new System.Drawing.Size(928, 562);
            this.errorUploadingPanel.TabIndex = 6;
            this.errorUploadingPanel.Visible = false;
            // 
            // errorToMain
            // 
            this.errorToMain.BackColor = System.Drawing.Color.White;
            this.errorToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorToMain.Location = new System.Drawing.Point(210, 372);
            this.errorToMain.Name = "errorToMain";
            this.errorToMain.Size = new System.Drawing.Size(475, 68);
            this.errorToMain.TabIndex = 1;
            this.errorToMain.Text = "OKAY";
            this.errorToMain.UseVisualStyleBackColor = false;
            this.errorToMain.Click += new System.EventHandler(this.errorToMain_Click);
            // 
            // errorUploadText
            // 
            this.errorUploadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorUploadText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorUploadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUploadText.ForeColor = System.Drawing.Color.Black;
            this.errorUploadText.Location = new System.Drawing.Point(74, 34);
            this.errorUploadText.Multiline = true;
            this.errorUploadText.Name = "errorUploadText";
            this.errorUploadText.ReadOnly = true;
            this.errorUploadText.Size = new System.Drawing.Size(768, 257);
            this.errorUploadText.TabIndex = 0;
            this.errorUploadText.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(934, 578);
            this.Controls.Add(this.editGradePanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.printTranscriptPanel);
            this.Controls.Add(this.selectStudentCoursePanel);
            this.Controls.Add(this.errorUploadingPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EKU Registrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.selectStudentCoursePanel.ResumeLayout(false);
            this.selectStudentCoursePanel.PerformLayout();
            this.editGradePanel.ResumeLayout(false);
            this.editGradePanel.PerformLayout();
            this.printTranscriptPanel.ResumeLayout(false);
            this.printTranscriptPanel.PerformLayout();
            this.errorUploadingPanel.ResumeLayout(false);
            this.errorUploadingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button printTranscriptButton;
        private System.Windows.Forms.Button editGradesButton;
        private System.Windows.Forms.Button addNewGradesButton;
        private System.Windows.Forms.Panel selectStudentCoursePanel;
        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.ListBox studentCoursesListBox;
        private System.Windows.Forms.Button submitStudentID;
        private System.Windows.Forms.TextBox studentIDTextEG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel editGradePanel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox newGradeComboBox;
        private System.Windows.Forms.TextBox currentGradeTextBox;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label currentGradeLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button submitNewGradeButton;
        private System.Windows.Forms.Panel printTranscriptPanel;
        private System.Windows.Forms.TextBox overallGPATSTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentIDTSTB;
        private System.Windows.Forms.TextBox studentNameTSTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox transcriptCoursesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitStudentIDTranscript;
        private System.Windows.Forms.TextBox studentIDTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label invalidLoginLabel;
        private System.Windows.Forms.Label invalidStudentIDTSLabel;
        public System.Windows.Forms.OpenFileDialog importCoursesWindow;
        private System.Windows.Forms.Label invalidStudentIDEGLabel;
        private System.Windows.Forms.Panel errorUploadingPanel;
        private System.Windows.Forms.Button errorToMain;
        private System.Windows.Forms.TextBox errorUploadText;
    }
}

