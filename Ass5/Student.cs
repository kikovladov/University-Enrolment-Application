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

namespace Ass5
{
    public partial class Student : Form
    {
        private Form1 _form1;
          public Student (Form1 f1)
        {
            InitializeComponent();
            _form1 = f1;
        }
        public Student()
        {
            InitializeComponent();
        }

        private void _AddStudentDetailsButton_Click_1(object sender, EventArgs e)
        {
            //getting data 
            try
            {
                string nameOfStudent = _StudentNameTextBox.Text;
                DateTime DOB = birthdayDateTimePicker.Value.Date;
                string display = _StudentAddressTextBox.Text;
                int id = Convert.ToInt32(_StudentIDMaskedTextBox.Text);
                Students a = new Students(nameOfStudent, id, DOB, display); //entering the data into the class
                _form1.StudentInfo.Add(a.Id, a);
            }
            catch (FormatException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
