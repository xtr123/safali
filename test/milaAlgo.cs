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
            int f = 0;
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word.ElementAt(i) < 'א' || _word.ElementAt(i) > 'ת')
                {
                    Debug.WriteLine(_word.ElementAt(i) + " is: " + (int)_word.ElementAt(i));
                    if (_word.ElementAt(i) == (char)1464 || _word.ElementAt(i) == (char)1461 || _word.ElementAt(i) == (char)1456)
                    {
                        _havarot++;
                        _havaraPtuha = true;
                    }
                    else
                    {
                        if (f == 1)
                        {
                            if (_word.ElementAt(i) == (char)1456 || _word.ElementAt(i) == (char)1458 || _word.ElementAt(i) == (char)1459 || _word.ElementAt(i) == (char)1457)
                            {
                                _havarot++;
                                f = 0;
                                _havaraSgura = true;
                            }

                       }
                        else if (f == 0)
                        {
                            f = 1;
                        }

                    }
                }


            }



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
