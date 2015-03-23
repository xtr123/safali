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
            administratorMain_Panle k = new administratorMain_Panle(_name);
            k.Show();
            this.Dispose();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            _back.Show();
            this.Dispose();
        }
    }
}
