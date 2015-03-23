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
    public partial class patitionetSelect_Form : Form
    {
        List<string>[] list = new List<string>[3];
        askAdministrator_form _back;
        public patitionetSelect_Form(askAdministrator_form back)
        {
            InitializeComponent();
            _back = back;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void patitionetSelect_Form_Load(object sender, EventArgs e)
        {
            List<string>[] list = new List<string>[3];
            db_connection k = new db_connection();
            list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<String>();
            list = k.SelectUser();
            if (list[0].Count > 0)
            {
                userlist.DataSource = list[0];
            }
            int indx = userlist.SelectedIndex;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _back.Show();
            this.Dispose();
        }

        private void patitionetSelect_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeClassWord m = new makeClassWord(this,userlist.SelectedItem.ToString());
            m.Show();
            this.Hide();
        }
    }
}
