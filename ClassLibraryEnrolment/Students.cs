using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnrolment {
    public class Students {
        //Declerations
        private string _StudentName;
        private DateTime _DOB;
        private int _StudentId;
        private string _StudentAddress;
        private List<int> _PaperSelection = new List<int>();

        public Students(string studentName, int studentId, DateTime birthday, string address) {
            if (studentName.Length > 0) {
                _StudentName = studentName;
            }
            else {
                throw new Exception("Enter Name Please");
            }
            _StudentId = studentId;
            _DOB = birthday;
            _StudentAddress = address;
        }

        public string printStudentDetails()  //prints details 
        {
            return "Student ID : " + _StudentId +
                   "\n Student Name : " + _StudentName +
                   "\n D.O.B :" + _DOB.ToShortDateString() +
                   "\n Student Address : " + _StudentAddress +
                   "\n ";
        }
        public int Id {
            get {
                return _StudentId;
            }
        }
        public List<int> paperSelection //returns paper selection
        {
            get {
                return _PaperSelection;
            }
        }
    }
}
