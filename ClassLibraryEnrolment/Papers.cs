using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnrolment {
    public class Papers {
        private string _PaperName;  //intitlising paper name 
        private int _PaperCode;  // inilising paper code
        private string _CourseCooridnator; // inilising paper Cooridantor 


        public Papers(string paperName, int paperCode, string courseCoordinator) //get the input
        {
            if (paperName.Length > 0)  //checking if the papername length is more than zero 
            {
                _PaperName = paperName;  //paper name is assigned to _PaperName
            }
            else {
                throw new Exception("enter paper name"); //if noting is entered then show this message 
            }
            _PaperCode = paperCode;  //paper code is assigned to _PaperCode
            _CourseCooridnator = courseCoordinator; //courseCoordinator is assigned to _CourseCooridnator
        }

        public string PrintPaperDetail()  //printing all the details fromn the input
        {
            return "The Paper Code :" + _PaperCode +
            "\n Paper Name :" + _PaperName +
            "\n CourseCoordinator :" + _CourseCooridnator + "\n";
        }
        public int Code {
            get {
                return _PaperCode;
            }
        }
    }
}
