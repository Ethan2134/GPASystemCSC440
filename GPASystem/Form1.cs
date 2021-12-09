using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace GPASystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //C# GUI BUILDER FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################

        //display the main menu here
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (usernameText.Text.Length <= 9 && passwordText.Text.Length <= 9 && isValidNum(usernameText.Text) && isValidNum(passwordText.Text) && validUserLogin(usernameText.Text, passwordText.Text))
            {
                mainPanel.Visible = true;
                loginPanel.Visible = false;
                invalidLoginLabel.Visible = false;
            }
            else {
                invalidLoginLabel.Visible = true;
                passwordText.Text = "";
            }
            
            
        }
        //from main to search for student by ID to edit grades
        private void editGradesButton_Click(object sender, EventArgs e)
        {
            selectStudentCoursePanel.Visible = true;
            mainPanel.Visible = false;
            studentCoursesListBox.Items.Clear();
            invalidStudentIDEGLabel.Visible = false;
            studentIDTextEG.Text = "";
        }
        //selected a course to edit the grade for
        private void studentCoursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectStudentCoursePanel.Visible = false;
            editGradePanel.Visible = true;
            String name = getStudentName(studentIDTextEG.Text);
            String[] courseInfo = studentCoursesListBox.SelectedItem.ToString().Split(' ');
            //[0] = pre, 1 = Num
            studentNameTextBox.Text = name;
            courseNameTextBox.Text = courseInfo[0] + " " +courseInfo[1];
            currentGradeTextBox.Text = courseInfo[courseInfo.Length - 1][1].ToString();
        }
        

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            selectStudentCoursePanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void courseNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //add edited grade to the database and return to main
        private void submitNewGradeButton_Click(object sender, EventArgs e)
        {
            editGradePanel.Visible = false;
            errorUploadingPanel.Visible = true;
            String newGrade;
            if (newGradeComboBox.SelectedItem == null)
                newGrade = "M";
            else
            {
                newGrade = newGradeComboBox.SelectedItem.ToString();
            }
            String studentID = studentIDTextEG.Text;
            String courseInfo = studentCoursesListBox.SelectedItem.ToString();
            String[] course = courseInfo.Split(' ');
            
            //Pre, Num, year, sem
            if (editGrade(studentID, course, newGrade))
            {
                calcGPA(studentID);
                errorUploadText.Text = "You have successfully changed the grade for student " + studentID + " from " + course[4][1] + " to " + newGrade +
                    " in " + course[0] + " " + course[1] + " for " + course[3] + " of " + course[2];
            }
            else
            {
                errorUploadText.Text = "Uh oh! Something went wrong when trying to change this grade. Please try again later.";
            }
            
        }

        //return to main from select student to edit
        private void backToMainButton_Click_1(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            selectStudentCoursePanel.Visible = false;
        }
        //return to main from print transcript
        private void button1_Click(object sender, EventArgs e)
        {
            invalidStudentIDTSLabel.Visible = false;
            mainPanel.Visible = true;
            printTranscriptPanel.Visible = false;
        }
        //back to select course
        private void button2_Click(object sender, EventArgs e)
        {
            editGradePanel.Visible = false;
            selectStudentCoursePanel.Visible = true;
        }
        //go to the transcript page
        private void printTranscriptButton_Click(object sender, EventArgs e)
        {
            printTranscriptPanel.Visible = true;
            mainPanel.Visible = false;
            studentIDTS.Text = "";
            studentNameTSTB.Text = "";
            studentIDTSTB.Text = "";
            overallGPATSTB.Text = "";
            transcriptCoursesListBox.Items.Clear();

        }
        //log the user out
        private void logoutButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            loginPanel.Visible = true;
            passwordText.Text = "";
            usernameText.Text = "";

        }

        private void studentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void printTranscriptPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewGradesButton_Click(object sender, EventArgs e)
        {
            String path = "";
            readExcel = false;
            partialUpload = false;
            courseUploaded = false;
            importCoursesWindow.Title = "Select Excel File";
            importCoursesWindow.ShowDialog();
            path = importCoursesWindow.FileName;
            Console.WriteLine("PATH: "+path);
            if (path.Length > 1)
            {
                String[] course = prepCourses(importCoursesWindow.SafeFileName);
                String extension = System.IO.Path.GetExtension(path);
                //Console.WriteLine("-----------------------------------------"+course[1]+"..."+ importCoursesWindow.SafeFileName);
                //if we have to import the whole folder at once, call this for each file in folder
                //add errors into here
                //if(importCoursesWindow.)
                readExcelFile(path, extension, course);
                //ERROR CREATING COURSE
                if (!readExcel)
                {
                    //Console.WriteLine("read");
                    String t = "Uh Oh! It seems like there was an error uploading your file." +
                                "The Excel file was unable to be read. Please make sure you selected an Excel file with a valid course title format and try again.";
                    mainPanel.Visible = false;
                    errorUploadingPanel.Visible = true;
                    errorUploadText.Text = t;
                }
                //ERROR UPLOADING ONE OR MORE STUDENTS
                else if (partialUpload)
                {
                    //Console.WriteLine("partial");
                    String t = "Uh Oh! It seems like there was an error uploading your file." +
                                "The grades of one or more students could not be uploaded. This could be due to an invalid format at one or more students. Please check your Excel file contents and try again.";
                    mainPanel.Visible = false;
                    errorUploadingPanel.Visible = true;
                    errorUploadText.Text = t;
                }
                //ERROR CREATING NEW COURSE
                else if (!courseUploaded)
                {
                    //Console.WriteLine("course");
                    String t = "Uh Oh! It seems like there was an error uploading your file." +
                                "The course was unable to be created. Please check your Excel file title and try again.";
                    mainPanel.Visible = false;
                    errorUploadingPanel.Visible = true;
                    errorUploadText.Text = t;

                }
                //SUCCESSFUL UPLOAD
                else
                {
                    //Console.WriteLine("SUCCESSFUL UPLOAD AND SAVE");
                    String t = "You have successfully uploaded your course! ";
                    mainPanel.Visible = false;
                    errorUploadingPanel.Visible = true;
                    errorUploadText.Text = t;
                }
            }
            else
            {

            }
            //need to save the course to the DataBase next
            //[0] = Prefix; [1] = Number; [2] = year; [3] = semester

        }
        private void submitStudentIDTranscript_Click(object sender, EventArgs e)
        {
            
            studentNameTSTB.Text = "";
            studentIDTSTB.Text = "";
            overallGPATSTB.Text = "";
            transcriptCoursesListBox.Items.Clear();
            if (studentIDTS.Text.Length < 10 && isValidNum(studentIDTS.Text))
            {
                invalidStudentIDTSLabel.Visible = false;
                //check the database
                //populate the fields
                if (doesStudentExist(studentIDTS.Text))
                {
                    ArrayList courses = getStudentCourses(studentIDTS.Text, 1);
                    foreach (String course in courses)
                    {
                        transcriptCoursesListBox.Items.Add(course);
                    }
                    studentNameTSTB.Text = getStudentName(studentIDTS.Text);
                    studentIDTSTB.Text = studentIDTS.Text;
                    overallGPATSTB.Text = getGPA(studentIDTS.Text);
                }
                else
                {
                    studentIDTS.Text = "";
                    invalidStudentIDTSLabel.Visible = true;
                }
            }
            else
            {
                studentIDTS.Text = "";
                invalidStudentIDTSLabel.Visible = true;
            }

        }
        
        private void submitStudentID_Click(object sender, EventArgs e)
        {
            studentCoursesListBox.Items.Clear();

            if (studentIDTextEG.Text.Length < 10 && isValidNum(studentIDTextEG.Text))
            {
                //populate the course tab
                invalidStudentIDEGLabel.Visible = false;
                ArrayList studentCourses = getStudentCourses(studentIDTextEG.Text, 0);
                if (studentCourses.Count > 0)
                {
                    foreach (String course in studentCourses)
                    {
                        studentCoursesListBox.Items.Add(course);
                        //Console.WriteLine(course);
                    }

                }
                else
                {
                    invalidStudentIDEGLabel.Visible = true;
                    studentIDTextEG.Text = "";
                }
            }
            else
            {
                invalidStudentIDEGLabel.Visible = true;
                studentIDTextEG.Text = "";
            }
        }

        private void errorToMain_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            errorUploadingPanel.Visible = false;
            
        }

        //END GUI FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################


        //START LOGIN FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################

        private static bool validUserLogin(String uname, String pword)
        {
            int user = Convert.ToInt32(uname);
            int pass = Convert.ToInt32(pword);
            bool exists = false;
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT COUNT(*) from rabyUser WHERE ID=@ID AND password=@pass";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                object obj = cmd.ExecuteScalar();
                if (Convert.ToInt32(obj) > 0)
                    exists = true;
                else
                    exists = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //Console.WriteLine("Done.");
            return exists;
        }

        //END LOGIN FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################

        //IMPORT GRADES FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        private static bool readExcel = false;
        private static bool courseUploaded = false;
        private static bool partialUpload = false;

        //CHECKS/PREPS EXCEL DATA FOR DATABASE ENTRY
        private static void saveExcelData(ArrayList excelData, String[] course)
        {
            //Course DNE, make it
            if (!doesCourseExist(course))
            {
                Console.WriteLine("COURSE DOES NOT EXIST");
                if (!addCourseToDatabase(course))
                    return;
            }
            else
                courseUploaded = true;
            //Iterate over each student in excel file
            foreach (String data in excelData)
            {
                String[] takesData = data.Split('-');
                //STUDENT EXISTS
                if (doesStudentExist(takesData[1]))
                {
                    Console.WriteLine("STUDENT EXISTS: " + takesData[1]);
                    //Add the data from excel into rabyTakes
                    addDataToStudentTakes(takesData, course);
                    //calculate and save the GPA
                    calcGPA(takesData[1]);
                }
                //STUDENT DOES NOT EXIST
                else
                {
                    Console.WriteLine("STUDENT DOES NOT EXIST: " + takesData[1]);
                    //Create a new student in the database
                    addStudentToDatabase(takesData[1], takesData[0]);
                    //Add the data from excel to the rabyTakes table
                    addDataToStudentTakes(takesData, course);
                    //Calculate and save the GPA
                    calcGPA(takesData[1]);
                }
            }
        }


        //ADDS INFO TO RABYTAKES TABLE
        private static void addDataToStudentTakes(String[] student, String[] course)
        {

            //course[]: [0] = Prefix; [1] = Number; [2] = year; [3] = semester
            //student[]: [1] = ID; [2] = grade 
            //Console.WriteLine("ADDING STUDENT TAKES DATA");
            int id = Convert.ToInt32(student[1]);
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO rabytakes(studentID, coursePrefix, courseNum, year, semester, grade) VALUES(@sID, @coursePre, @courseNo, @year, @sem, @grade)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", id);
                cmd.Parameters.AddWithValue("@coursePre", course[0]);
                cmd.Parameters.AddWithValue("@courseNo", course[1]);
                cmd.Parameters.AddWithValue("@year", course[2]);
                cmd.Parameters.AddWithValue("@sem", course[3]);
                cmd.Parameters.AddWithValue("@grade", student[2].ToUpper());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                //Console.WriteLine(ex.ToString());
                //Console.WriteLine("EXCEPTION IN ADD DATA TO STUDENT TAKES");
            }
            conn.Close();
        }


        //ADDS STUDENT TO RABYSTUDENT TABLE
        private static void addStudentToDatabase(String ID, String name)
        {
            int sID = Convert.ToInt32(ID);
            Console.WriteLine("ADDING STUDENT: " + ID);
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO rabystudent(ID, name) VALUES(@sID, @name)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", sID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                //Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }


        //CHECKS IF STUDENT EXISTS IN DATABASE
        private static bool doesStudentExist(String studentID)
        {
            int sID = Convert.ToInt32(studentID);
            bool exists = false;
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT COUNT(*) from rabyStudent WHERE ID=@sID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", sID);
                object obj = cmd.ExecuteScalar();
                if (Convert.ToInt32(obj) > 0)
                    exists = true;
                else
                    exists = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //Console.WriteLine("Done.");
            return exists;
        }


        //ADD A NEW COURSE TO RABYCOURSE
        private static bool addCourseToDatabase(String[] course)
        {
            //course[]: [0] = prefix; [1] = number; [2] = year; [3] = semester
            Console.WriteLine("ADDING COURSE");
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO rabyCourse(coursePrefix, courseNum, year, semester, hours) VALUES(@pre, @courseNo, @newyear, @sem, @hour)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pre", course[0]);
                cmd.Parameters.AddWithValue("@courseNo", course[1]);
                cmd.Parameters.AddWithValue("@newyear", course[2]);
                cmd.Parameters.AddWithValue("@sem", course[3]);
                cmd.Parameters.AddWithValue("@hour", Convert.ToInt32(course[4]));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                //Console.WriteLine(ex.ToString());
                courseUploaded = false;
                return false;
            }
            conn.Close();
            courseUploaded = true;
            return true;

        }


        //CHECKS IF COURSE EXISTS IN DATABASE
        private static bool doesCourseExist(String[] course)
        {
            bool exists = false;
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT COUNT(*) from rabyCourse WHERE coursePrefix=@pre AND year=@newYear AND courseNum=@courseNo AND semester=@sem";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pre", course[0]);
                cmd.Parameters.AddWithValue("@courseNo", course[1]);
                cmd.Parameters.AddWithValue("@newyear", course[2]);
                cmd.Parameters.AddWithValue("@sem", course[3]);
                object obj = cmd.ExecuteScalar();
                Console.WriteLine("***" + Convert.ToInt32(obj));
                if (Convert.ToInt32(obj) > 0)
                    exists = true;
                else
                    exists = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return exists;
        }


        //CHECKS IF EXCEL DATA IS IN CORRECT FORMAT
        //FORMAT: NAME     ID     GRADE
        private static bool validateExcelData(String data)
        {
            //cut off the last split modifier (-)
            
            data = data.Substring(0, data.Length - 1);
            //Console.WriteLine("Validating Excel Data");
            //Console.WriteLine(data);
            String[] dataTakes = data.Split('-');
            //If there are more/less than 3 elements (Name, ID, Grade), do not add it
            if (dataTakes.Length != 3)
            {
                //Console.WriteLine("FAILED LENGTH" + dataTakes.Length + ". VALUE AT 4: " + dataTakes[3]);
                return false;
            }
            //Not a valid ID
            if (dataTakes[1].Length < 4 || dataTakes[1].Length > 9 || !(dataTakes[1].All(char.IsDigit)))
            {
                //Console.WriteLine("FAILED DIGIT");
                return false;
            }
            //All possible inputs for a grade; M = Missing Grade;
            String c = dataTakes[2].ToUpper();
            switch (c[0])
            {
                case 'A':
                    return true;
                case 'B':
                    return true;
                case 'C':
                    return true;
                case 'D':
                    return true;
                case 'F':
                    return true;
                case 'M':
                    return true;
                default:
                    return false;
            }

        }


        //READS THE INFORMATION FROM EXCEL FILE
        private static void getExcelData(String[] course, Excel._Worksheet sheet, int r, int c)
        {
            
            ArrayList excelData = new ArrayList();
            //iterate over the rows and columns
            //Build a string, data, that contains the name, ID, and grade
            //Use a '-' for easy splitting of string
            for (int i = 2; i <= r; i++)
            {
                String data = "";
                for (int j = 1; j <= c; j++)
                {
                    data += ((Excel.Range)sheet.Cells[i, j]).Value2.ToString() + "-";

                }
                if (validateExcelData(data))
                    excelData.Add(data);
                //could not add 1 or more student grades into the table due to invalid data
                else
                    partialUpload = true;
            }

            String hours = "3";
            //Check if there is a valid credit hour and change if yes
            object g = ((Excel.Range)sheet.Cells[1, 4]).Value2;
            if (g != null && isValidNum(g.ToString()) && Convert.ToInt32(g.ToString()) > 0 && Convert.ToInt32(g.ToString()) <= 5)
                hours = g.ToString();
            course = course.Concat(new String[] { hours }).ToArray();
            //Flag for error messgae to be displayed
            readExcel = true;
            //Save the excel data to the database
            saveExcelData(excelData, course);
        }


        //MAKES SURE EXCEL TITLE IS IN CORRECT FORMAT
        //FORMAT: PREFIX     NUMBER     YEAR     SEMESTER
        private static bool validateCourse(String[] course)
        {
            //Ensures it only has Prefix, Number, Year, Semester in valid form
            if (course.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < course.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (course[i].Length != 3)
                            return false;
                        break;
                    case 1:
                        if (!course[i].All(char.IsDigit) || course[i].Length != 3)
                            return false;
                        break;
                    case 2:
                        if (!course[i].All(char.IsDigit))
                            return false;
                        break;
                    case 3:
                        if (course[i].ToLower() == "spring" ||
                            course[i].ToLower() == "summer" ||
                            course[i].ToLower() == "fall" ||
                            course[i].ToLower() == "winter")
                            return true;
                        break;
                    default:
                        return false;
                }
            }
            return false;
        }


        //MAKES SURE FILE IS AN EXCEL FILE
        private static void readExcelFile(String path, String extension, String[] course)
        {
            //create the objects to start reading
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(path);
            Excel._Worksheet sheet = workbook.Sheets[1];
            if ((extension.CompareTo(".xls") == 0 ||
                extension.CompareTo(".xlsx") == 0) && validateCourse(course))
            {
                try
                {
                    int c = 3;
                    int r = sheet.UsedRange.Rows.Count;
                    getExcelData(course, sheet, r, c);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
            }
            else
            {
                //INVALID FILE, Flag for error type
                readExcel = false;
            }
            //Close the excel file
            workbook.Close();
            excelApp.Quit();
            Marshal.FinalReleaseComObject(sheet);
            Marshal.FinalReleaseComObject(workbook);
            Marshal.FinalReleaseComObject(excelApp);
            sheet = null;
            workbook = null;
            excelApp = null;
            GC.Collect();
        }


        //BREAKS THE TITLE INTO AN ARRAY
        //RETURNED ARRAY: [0] = PREFIX. [1] = NUMBER. [2] = YEAR. [3] = SEMESTER
        private static String[] prepCourses(String s)
        {
            int trim = s.IndexOf(".");
            s = s.Substring(0, trim);
            return s.Split(' ');
        }

        //END IMPORT GRADES FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################



        //START EDIT GRADES FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################

        //CHANGES THE GRADE OF A STUDENT
        private static bool editGrade(String studentID, String[] course, String newGrade)
        {
            int ID = Convert.ToInt32(studentID);
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE rabyTakes SET grade=@newGrade WHERE studentID=@sID AND coursePrefix=@coursePre AND courseNum=@courseNum AND year=@year AND semester=@sem";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", ID);
                cmd.Parameters.AddWithValue("@coursePre", course[0]);
                cmd.Parameters.AddWithValue("@courseNum", course[1]);
                cmd.Parameters.AddWithValue("@year", course[2]);
                cmd.Parameters.AddWithValue("@sem", course[3]);
                cmd.Parameters.AddWithValue("@newGrade", newGrade);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            conn.Close();
            return true;

        }

        //GETS ALL OF A STUDENT'S COURSES FROM AN ID IN THE DATABASE
        private static ArrayList getStudentCourses(String id, int op)
        {

            int studentID = Convert.ToInt32(id);
            ArrayList courses = new ArrayList(); 
            DataTable myTable = new DataTable();
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM rabyTakes WHERE studentID=@sID ORDER BY year ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", studentID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                //Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in myTable.Rows)
            {
                if (!row["grade"].ToString().Equals("W") || op != 0)
                {
                    String s = row["coursePrefix"].ToString() + " " + row["courseNum"].ToString()
                         + " " + row["year"] + " " + row["semester"].ToString() + " (" + row["grade"].ToString() + ")";
                    courses.Add(s);
                }

            }
            return courses;

        }

        //END EDIT GRADES FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################

        //START TRANSCRIPT FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################


        //CALCULATES GPA GIVEN STUDENT ID FROM DATABASE
        private static void calcGPA(String id)
        {
            int studentID = Convert.ToInt32(id);
            ArrayList courses = new ArrayList();
            DataTable myTable = new DataTable();
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT c.hours, t.grade, t.courseNum FROM rabyCourse as c NATURAL JOIN rabyTakes as t WHERE studentID=@sID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", studentID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                //Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            float totalCredits = 0.00f;
            float qualityPoints = 0.00f;
            foreach (DataRow row in myTable.Rows)
            {
                switch (row["grade"].ToString().ToUpper())
                {
                    case "A":
                        totalCredits += Convert.ToInt32(row["hours"].ToString());
                        qualityPoints += 4 * Convert.ToInt32(row["hours"].ToString());
                        break;
                    case "B":
                        totalCredits += Convert.ToInt32(row["hours"].ToString());
                        qualityPoints += 3 * Convert.ToInt32(row["hours"].ToString());
                        break;
                    case "C":
                        totalCredits += Convert.ToInt32(row["hours"].ToString());
                        qualityPoints += 2 * Convert.ToInt32(row["hours"].ToString());
                        break;
                    case "D":
                        totalCredits += Convert.ToInt32(row["hours"].ToString());
                        qualityPoints += 1 * Convert.ToInt32(row["hours"].ToString());
                        break;
                    case "F":
                        totalCredits += Convert.ToInt32(row["hours"].ToString());
                        qualityPoints += 0 * Convert.ToInt32(row["hours"].ToString());
                        break;
                    default:
                        break;
                }
            }
            if (totalCredits > 0)
            {
                double GPA = Math.Round(qualityPoints / totalCredits, 2);
                saveGPA(id, GPA);
            }
            else
            {
                saveGPA(id, -1);
            }
        }

        //GETS THE GPA GIVEN STUDENT ID FROM DATABASE
        private static String getGPA(String id)
        {
            int studentID = Convert.ToInt32(id);
            String overallGPA = "";
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT overallGPA FROM rabyStudent WHERE ID=@sID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", studentID);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    overallGPA = myReader["overallGPA"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //No GPA to give, return not applicable
            if (String.IsNullOrEmpty(overallGPA))
                return "NA";
            return overallGPA;
        }


        //SAVES THE GPA TO THE DATABASE GIVEN A STUDENT ID AND THE NEW GPA
        private static void saveGPA(String id, double GPA)
        {
            int studentID = Convert.ToInt32(id);
            
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE rabyStudent SET overallGPA=@GPA WHERE ID=@sID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", studentID);
                if(GPA >= 0)
                    cmd.Parameters.AddWithValue("@GPA", GPA);
                else
                    cmd.Parameters.AddWithValue("@GPA", null);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.ToString());
                return;
            }
            conn.Close();
        }

        //END TRANSCRIPT FUNCTIONS
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################
        //###################################################

        //MISC FUNCTIONS

        //CHECKS IF THE STRING IS A VALID INTEGER
        private static bool isValidNum(String s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            //valid number
            else if (s.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //RETURNS THE STUDENT NAME FROM AN ID IN THE DATABASE
        //USED IN TRANSCRIPT AND EDIT GRADE
        private static String getStudentName(String id)
        {
            int studentID = Convert.ToInt32(id);
            String name = "";
            //prepare an SQL query to retrieve all the events on the same, specified date
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT name FROM rabyStudent WHERE ID=@sID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sID", studentID);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    name = myReader["name"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return name;
        }   
    }
}
