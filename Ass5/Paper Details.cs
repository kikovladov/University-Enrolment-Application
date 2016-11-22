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
    public partial class Paper_Details : Form
    {
        private Form1 _form1;


        public Paper_Details(Form1 f1)
        {
            InitializeComponent();
            _form1 = f1;


        }
        public Paper_Details()
        {
            InitializeComponent();
        }
        public void enrollpaper(int one, int two) //enrolling paper
        {
            try
            {
                int studentId = one;  //getting id 
                int studentPaperCode = two;  //getting the paper code
                Students studnt = _form1.StudentInfo[studentId];
                Papers papr = _form1.DetailsOfPaper[studentPaperCode];
                studnt.paperSelection.Add(papr.Code);
            }
            catch (EntryPointNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void EnrollBut_Click(object sender, EventArgs e)
        {
            try
            {
                int one = Convert.ToInt32(IdBox.Text);  //convert the text to a int when searching
                int two = Convert.ToInt32(paperCodeBox.Text);
                enrollpaper(one, two);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
            }
            catch (EntryPointNotFoundException)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
