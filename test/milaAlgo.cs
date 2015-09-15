using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace test
{
    class milaAlgo
    {
        string _word;
        int _havarot;
        public bool _havaraPtuha=false;
       public bool _havaraSgura = false;

        public milaAlgo(String k)
        {
            _havarot = -1;
            _word = k;
        }
        public int MisparHavarot()
        {
            _havarot = 0;
         
            for (int i = 0; i < _word.Length; i++)
            {
                Debug.WriteLine(_word.ElementAt(i) + " is: " + (int)_word.ElementAt(i));
                    
                if (_word.ElementAt(i) < 'א' || _word.ElementAt(i) > 'ת')
                {
                    //                      kamatz                                  patach                                  holam                               
                    if (_word.ElementAt(i) == (char)1464 || _word.ElementAt(i) == (char)1463 || _word.ElementAt(i) == (char)1465 || _word.ElementAt(i) == (char)1461 || _word.ElementAt(i) == (char)1462 || _word.ElementAt(i) == (char)1467 || _word.ElementAt(i) == (char)1460)
                    {
                        _havarot++;
                    }
                     
                }


            }
            Debug.WriteLine(_havarot);
            return _havarot;
        }
        }
    

}

/*
 *    milaAlgo m = new milaAlgo("אִצְטְרֻבָּל");
           MessageBox.Show( m.MisparHavarot()+" Ptucha: " +m._havaraPtuha+" Sgura: " +m._havaraSgura);
           
            m = new milaAlgo("מַעֲרוֹךְ");

            MessageBox.Show(m.MisparHavarot() + " Ptucha: " + m._havaraPtuha + " Sgura: " + m._havaraSgura);
           
            //תְּמוּנָה
            //אֶנְצִיקְלוֹפֶּדְיָה
           m = new milaAlgo("תְּמוּנָה");

           MessageBox.Show(m.MisparHavarot() + " Ptucha: " + m._havaraPtuha + " Sgura: " + m._havaraSgura);
           m = new milaAlgo("אֶנְצִיקְלוֹפֶּדְיָה");

           MessageBox.Show(m.MisparHavarot() + " Ptucha: " + m._havaraPtuha + " Sgura: " + m._havaraSgura);
           */
