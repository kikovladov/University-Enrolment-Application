using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student
    {
        private string _StudentName;
        private DateTime _DOB;
        private int _StudentId;
        private string _StudentAddress;
        private List<int> _PaperSelection = new List<int>();

        public Student(string studentName, int studentId, DateTime birthday, string address) //getting the input 
        {
            if (studentName.Length > 0)
            {
                _StudentName = studentName;
            }
            else
            {
                throw new Exception("Enter Name Please");
            }
            _StudentId = studentId;
            _DOB = birthday;
            _StudentAddress = address;
        }

        public string printStudentDetails()
        {
            return "Student ID : " + _StudentId +
                   "\n Student Name : " + _StudentName +
                   "\n D.O.B :" + _DOB.ToShortDateString() +
                   "\n Student Address : " + _StudentAddress +
                   "\n ";
        }
        public int Id
        {
            get
            {
                return _StudentId;
            }
        }
        public List<int> paperSelection
        {
            get
            {
                return _PaperSelection;
            }
        }
    }
}
