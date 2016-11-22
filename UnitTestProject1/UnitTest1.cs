using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ass5;
using ClassLibraryEnrolment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void PaperDetailsTest()  //testing the info that geats printed
        {
            Papers output = new Papers("Programming", 159333, "David Thegreat");  //output is this 
            string expectedOutput = "The Paper Code :" + 159333 + //expected should be this
            "\n Paper Name :" + "Programming" +
            "\n CourseCoordinator :" + "David Thegreat" + "\n";
            Assert.AreEqual(expectedOutput, output.PrintPaperDetail()); //checking if the output are equal
        }



        [TestMethod]
        public void StudentDetailsTest()  //testing student info 
        {
            string dOB = "01/12/1999";  //setting the DOB
            DateTime date = Convert.ToDateTime(dOB); //converting it to Date time
            Students studn = new Students("Akbarjon Odilov", 001, date, "50 BlueBird Ave , Auckland,NewZealand ,1122"); //assigneing this to stud
            string outputShouldBe = "Student ID : " + 001 +  //output should be this
                   "\n Student Name : " + "Akbarjon Odilov" +
                   "\n D.O.B :" + date.ToShortDateString() +
                   "\n Student Address : " + "50 BlueBird Ave , Auckland,NewZealand ,1122" +
                   "\n ";
            Assert.AreEqual(outputShouldBe, studn.printStudentDetails()); //comparing if both are eqaul

        }

        [TestMethod]
        public void DictonaryOutputTest() //checking dictionary output
        {
            DateTime input1 = Convert.ToDateTime("22/05/1966"); //getting the dates
            DateTime input2 = Convert.ToDateTime("21/12/1908");
            Students studnt1 = new Students("Lol Man", 001, Convert.ToDateTime("22/05/1966"), "154 K road Auckland City, Auckland,NewZealand ,1030");  //getting the info
            Students studnt2 = new Students("Haha Man", 002, Convert.ToDateTime("21/12/1908"), "188 Knob St Auckland City, Auckland,NewZealand ,1030");
            Form1 form1 = new Form1();
            Paper_Details form2 = new Paper_Details();
            form1.StudentInfo.Add(studnt1.Id, studnt1); //adding the info into studnt1
            form1.StudentInfo.Add(studnt2.Id, studnt2);//adding info into studnt 2
            Papers paper1 = new Papers("Coding", 000001, "Adilov Akboar"); //add data to the new papers
            Papers paper2 = new Papers("NONO", 000002, " Rekt");
            form1.DetailsOfPaper.Add(paper1.Code, paper1);
            form1.DetailsOfPaper.Add(paper2.Code, paper2);
            string Output1ShouldBe = "Student ID : " + 001 +  //output should be this
                    "\n Student Name : " + "Lol Man" +
                    "\n D.O.B :" + input1.ToShortDateString() +
                    "\n Student Address : " + "154 K road Auckland City, Auckland,NewZealand ,1030" +
                    "\n " + "Student ID is : " + 002 +
                    "\n Student Name : " + "Haha Man" +
                    "\n D.O.B :" + input2.ToShortDateString() +
                    "\n Student Address : " + "188 Knob St Auckland City, Auckland,NewZealand ,1030" +
                    "\n " + "\n";
            string Output2ShouldBe = "The Paper Code :" + 000001 +  //output should be this
             "\n Paper Name :" + "Coding" +
             "\n CourseCoordinator :" + "Adilov Akboar" + "\n" + "The Paper Code :" + 000002 +
             "\n Paper Name :" + "NONO" +
             "\n CourseCoordinator :" + " Rekt" + "\n";

            Assert.AreNotEqual(Output1ShouldBe, form1.studentsString());  //check if not equal
            Assert.AreEqual(Output2ShouldBe, form1.PaperTOString());     ///check if equal 
        }

        [TestMethod]
        public void SearchTes1t()
        {
            DateTime dOB = Convert.ToDateTime("22/05/1966"); //getting the date
            DateTime dOB2 = Convert.ToDateTime("21/12/1908");
            Students studnt1 = new Students("Blabla Man", 001, Convert.ToDateTime("22/05/1966"), "144 Idiotic Rd, Auckland,NewZealand ,10660");  //getting data 
            Students studnt2 = new Students("HIHI Man", 002, Convert.ToDateTime("21/12/1908"), "266 Hungry St Auckland City, Auckland,NewZealand ,1030");
            Form1 form1 = new Form1();
            Paper_Details form2 = new Paper_Details();
            form1.StudentInfo.Add(studnt1.Id, studnt1);
            form1.StudentInfo.Add(studnt2.Id, studnt2);
            Papers paper1 = new Papers("Coding", 000001, "Will Smith");  //getting paper info
            Papers paper2 = new Papers("NONO", 000002, "Will I AM");
            form1.DetailsOfPaper.Add(paper1.Code, paper1);
            form1.DetailsOfPaper.Add(paper2.Code, paper2);
            Papers pap1 = form1.DetailsOfPaper[000001];  //add the paper details
            Papers pap2 = form1.DetailsOfPaper[000002];
            Students student1 = form1.StudentInfo[002];  //add the student details
            Students student2 = form1.StudentInfo[001];
            student1.paperSelection.Add(paper1.Code);
            student2.paperSelection.Add(paper1.Code);
            student2.paperSelection.Add(paper2.Code);


            string searchOutputOfStudent = "Student ID : " + 001 +  //search output should be this 
                   "\n Student Name : " + "Blabla Man" +
                   "\n D.O.B :" + dOB.ToShortDateString() +
                   "\n Student Address : " + "144 Idiotic Rd, Auckland,NewZealand ,10660" +
                   "\n " + Environment.NewLine;
            string searchOutputOfPapers = "The Paper Code :" + 000001 +  //paper code search output should be this 
            "\n Paper Name :" + "Coding" +
            "\n CourseCoordinator :" + "Will Smith" + "\n" + Environment.NewLine + "The Paper Code :" + 000002 +
            "\n Paper Name :" + "NONO" +
            "\n CourseCoordinator :" + "Will I AM" + "\n" + Environment.NewLine;
            Assert.AreEqual(searchOutputOfStudent, form1.DisplayPaperStudents(paper2.Code));  //check if search ID are equal 
            Assert.AreEqual(searchOutputOfPapers, form1.DisplayPapersOfStudent(studnt1.Id));  //check if search code are equal 

        }

    }
}
