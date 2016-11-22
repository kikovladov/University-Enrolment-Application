using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEnrolment;
using System.IO;

namespace Ass5 {
    public partial class Form1 : Form {
        //Forms initialising
        private Paper_Details _form2;
        private AddingPapers _form3;
        private Student _form4;
        public Dictionary<int, Students> StudentInfo = new Dictionary<int, Students>();
        public Dictionary<int, Papers> DetailsOfPaper = new Dictionary<int, Papers>();


        public Form1() {
            //Classes initialsing
            InitializeComponent();
            _form3 = new AddingPapers(this);
            _form2 = new Paper_Details(this);
            _form4 = new Student(this);
        }

        public string DisplayPapersOfStudent(int id) {
            try {
                if (id == null) {
                    return string.Empty;
                }
                Students studentInfo = StudentInfo[id]; //get student information from class and store it

                string outPutInfo = paperSearchBox.Text;
                if (studentInfo.paperSelection.Count > 0) {
                    foreach (int paperId in studentInfo.paperSelection) {
                        paperSearchBox.Text += DetailsOfPaper[paperId].PrintPaperDetail() + Environment.NewLine;
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            return paperSearchBox.Text;

        }
        public string DisplayPaperStudents(int code) {
            if (code == null) {
                return string.Empty;
            }
            foreach (Students stud in StudentInfo.Values) {
                if (stud.paperSelection.Contains(code)) //if the paper code is the same as code display it
                {
                    searchBox.Text += stud.printStudentDetails() + Environment.NewLine;
                }
            }
            return searchBox.Text;
        }
        public void OpenFile()  //opening file
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    if ((myStream = openFileDialog1.OpenFile()) != null)  //reading file
                    {
                        using (myStream) {
                            StreamReader reader = new StreamReader(myStream);
                            studentDetailsBox.Text = reader.ReadToEnd();
                            reader.Close();
                        }
                    }
                }
                catch (FormatException) {
                    MessageBox.Show("Please enter correct file\n");
                }

                catch (Exception) {
                    MessageBox.Show("Error: Could not read file..Please try again . ");
                }
            }

        }
        public void SaveFileStudent() //save file
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files(*txt)|*.txt";
            saveFile.FileName = "student Database";
            saveFile.Title = "Save file";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string path = saveFile.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write(studentDetailsBox.Text);
                bw.Dispose();
            }

        }
        /////////////BUTTONS\\\\\\\\\\\\\\

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFile();
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileStudent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        public String studentsString() {
            String printLine = "";
            foreach (Students a in StudentInfo.Values) {
                printLine += a.printStudentDetails() + "\n";
            }

            return printLine;
        }
        public String PaperTOString() {
            String printLineOfInformation = "";
            foreach (Papers papr in DetailsOfPaper.Values) {
                paperDetailsBox.Text += papr.PrintPaperDetail();
            }
            printLineOfInformation = paperDetailsBox.Text;
            return printLineOfInformation;
        }

        private void openFileToolStripMenuItem_Click_1(object sender, EventArgs e) {
            OpenFile();
        }

        private void saveFileToolStripMenuItem_Click_1(object sender, EventArgs e) {
            SaveFileStudent();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void addStudentBut_Click(object sender, EventArgs e) {
            _form4.Show();
            addStudentBut.Enabled = false;
        }

        private void addPaperBut_Click(object sender, EventArgs e) {
            _form2.Show();
            addPaperBut.Enabled = false;
        }

        private void enrollButt_Click(object sender, EventArgs e) {
            _form3.Show();
            enrollButt.Enabled = false;
        }

        private void displayStudentBut_Click(object sender, EventArgs e) {
            studentDetailsBox.Text = studentsString();
        }

        private void displayPaperBut_Click(object sender, EventArgs e) {
            PaperTOString();
        }
        private void searchStuBtn_Click(object sender, EventArgs e) {
            try {
                int studentId = Convert.ToInt32(SearchPaperBox.Text); //input what you are searching
                DisplayPapersOfStudent(studentId);   //display if a match
            }
            catch (FormatException e6) {
                MessageBox.Show(e6.Message);
            }
        }

        private void searchPaperBtn_Click(object sender, EventArgs e) {
            try {
                int paperCode = Convert.ToInt32(searchIdBox.Text);  //search for this
                DisplayPaperStudents(paperCode); //display the match
            }
            catch (Exception) {
                MessageBox.Show("Error");
            }
        }
    }
}

