using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class sylOptionsClass
    {
        public string _openClose="";
        public string _p_cut = "";
        public  string _agia = "";
        public string _koliot = "";
        public sylOptionsClass()
        {
             _openClose = "";
             _p_cut = "";
             _agia = "";
             _koliot = "";

        }
        public sylOptionsClass(string openClose,string p_cut,string agia,string koliot)
        {
            _openClose = openClose;
            _p_cut = p_cut;
            _agia = agia;
            _koliot=koliot;
        }
        public string toString()
        {
            return "openClose - " + _openClose + " ,p_cut - " + _p_cut + " ,agia - " + _agia + " ,koliot - " + _koliot; 
        }
    }
}
