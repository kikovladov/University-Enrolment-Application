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

namespace Ass5 {
    public partial class AddingPapers : Form {
        private Form1 _f1;

        //Initialising
        public AddingPapers(Form1 f1) {
            InitializeComponent();
            _f1 = f1;

        }
        public AddingPapers() {
            InitializeComponent();

        }
        private String PapersString() //getting the paper details and storing it into a string
        {
            String printInfo = "";
            foreach (Papers t in _f1.DetailsOfPaper.Values) {
                printInfo += t.PrintPaperDetail() + "\n";
            }
            return printInfo;
        }
        private void AddPaper_Click(object sender, EventArgs e) {
            try {
                string nameOfPaper = NameOfPaperBox.Text;
                int codeOfPaper = Convert.ToInt32(CodePaperBox.Text); //int add to paper code
                string courseCoordinator = CourseBox.Text;

                Papers pap = new Papers(nameOfPaper, codeOfPaper, courseCoordinator);
                _f1.DetailsOfPaper.Add(pap.Code, pap);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
