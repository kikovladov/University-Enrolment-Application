using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnrolment {
    public class Univers {
        int _StudentID; //declaring student ID
        int _PaperCodes1; //declaring Paper1
        int _PaperCodes2; //declaring paper2
        int _paperCodes3; //declaring paper3
        int _paperCodes4; //declaring paper4

        public Univers(int studentid, int papercods1, int papercods2, int papercods3, int papercods4) //getting the data into each variable
        {
            if (studentid > 0) //check if i is greater than 0
            {
                _StudentID = studentid;
            }
            else {
                throw new Exception("Enter Id please"); //if id not greater than 0 then this error happens
            }
            //assigning each input
            _PaperCodes1 = papercods1;
            _PaperCodes2 = papercods2;
            _paperCodes3 = papercods3;
            _paperCodes4 = papercods4;
        }


        public int studentid //returing student id
        {
            get {
                return _StudentID;
            }

        }
    }
}
