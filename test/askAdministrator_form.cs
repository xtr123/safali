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
    public partial class askAdministrator_form : Form
    {
        loginForm _back;
        string _name;
        public askAdministrator_form(loginForm back,string name)
        {
            _name = name;
            _back = back;
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            administratorMain_Panle k = new administratorMain_Panle(_name,this);
            k.Show();
            this.Visible = false;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            patitionetSelect_Form m = new patitionetSelect_Form(this);
            m.Show();
        }

        private void askAdministrator_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_back == null)
            {
                loginForm k = new loginForm();
                k.Show();
                this.Dispose();
            }
            else { 
            _back.Show();
            }
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
