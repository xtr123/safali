using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class game : Form
    {
        int _userId;
        int _currentGame = -1;
        List<string>[] l;
        Form _back;
        int _homework;
        int _classNumber = -1;
        public game(int userId,Form back,int homework)
        {
            _homework = homework;

            _back = back;
            _userId = userId;
            InitializeComponent();
            
            db_connection k = new db_connection();
            int j=_classNumber=k.getCurrentClass(_userId,_homework);
            db_connection k2 = new db_connection();
           l=k2.Selectgame(_userId,j,_homework);
            if (l[0].Count > 0)
            {
                _currentGame = l[0].Count-1;
                db_connection t = new db_connection();
                 string[] l2=t.getWordDataById(l[0].ElementAt(_currentGame), pictureBox1);
                 label1.Text = l2[1];
            }
            else
            {
                MessageBox.Show("אין מילים למשחק!");
            }
        }
        
        private void game_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("אין יותר מילים לשחק");

            _back.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_currentGame >= 0) { 
            //update the yesNo filed to Yes
         db_connection m = new db_connection();
         bool b=   m.updateWordInClass(_userId, l[0].ElementAt(_currentGame), 1,_classNumber);
         MessageBox.Show(b + "");
         _currentGame--;
            }
            if (_currentGame >= 0)
            {
                db_connection t = new db_connection();
                string[] l2 = t.getWordDataById(l[0].ElementAt(_currentGame), pictureBox1);
                label1.Text = l2[1];
            }
            if (_currentGame < 0)
            {
                MessageBox.Show("אין יותר מילים לשחק");
                _back.Show();
                this.Dispose();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentGame >= 0) { 
            //update the yesNo filed to No1
            db_connection m = new db_connection();
            bool b = m.updateWordInClass(_userId, l[0].ElementAt(_currentGame), 2,_classNumber);
            MessageBox.Show(b + "");
            _currentGame--;
            }
            if (_currentGame >= 0) { 
            db_connection t = new db_connection();
            string[] l2 = t.getWordDataById(l[0].ElementAt(_currentGame), pictureBox1);
            label1.Text = l2[1];
            }
            if (_currentGame < 0)
            {
                _back.Show();
                this.Dispose();
            }
        }
    }
}
