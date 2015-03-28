using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test
{
    public partial class loginForm : Form
    {
        String _username,_password;
        Timer t = new Timer();
        
        public loginForm()
        {
          
            InitializeComponent();
           // makeClassWord m = new makeClassWord(this,"gil");
            //m.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // present clock on loding form
            t.Interval = 1000;
            t.Tick += new EventHandler(this.label4_Click);
            t.Start(); 
            ///////////////
           // edWord_form k = new edWord_form(this);
           // k.Show();
            _username = "";
            _password = "";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName_textBox.Text == "" || userName_textBox.Text == null)
            {
                MessageBox.Show("נא הקלד שם משתמש");
            }
            if (password_textBox.Text == "" || password_textBox.Text == null)
            {
                MessageBox.Show("נא הקלד סיסמא");
            }
            else { 
            try
            {
                _username=userName_textBox.Text;
                _password = password_textBox.Text;
                login now = new login(_username, _password);
                if (now.ans == 1)
                {
                    MessageBox.Show("Welcome");
                //now we want to move the homework page select game.
                }
                else if (now.ans == 2)
                {
                    askAdministrator_form k = new askAdministrator_form(this,_username);
                    k.Show();
                    this.Hide();
                    //here we move to the asking open administrator panle?
                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמא שגויים");
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if (hh < 10)
            {
                time += "0"+hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            label4.Text = time;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("האם אתה בטוח שברצונך לצאת?", "האם לצאת", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing!!
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            
        }
    }
}
