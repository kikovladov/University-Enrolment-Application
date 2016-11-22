using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Uni
    {
        int _StudentID;
        int _PaperCodes1;
        int _PaperCodes2;
        int _paperCodes3;
        int _paperCodes4;

        public Uni(int studentid, int papercods1, int papercods2, int papercods3, int papercods4)
        {
            if (studentid > 0)
            {
                _StudentID = studentid;
            }
            else
            {
                throw new Exception("Enter Id please");
            }
            
            _PaperCodes1 = papercods1;
            _PaperCodes2 = papercods2;
            _paperCodes3 = papercods3;
            _paperCodes4 = papercods4;
        }

        public int studentid
        {
            get
            {
                return _StudentID;
            }

        }
    }
}
