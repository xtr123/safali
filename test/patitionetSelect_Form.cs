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
        int _userId=-1;
       int _class=0;
        int _homework=0;
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
           
            db_connection k = new db_connection();
            list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

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
            if (_back == null)
            {
                askAdministrator_form l= new askAdministrator_form(null,"");
                l.Show();
                this.Dispose();
            }
            _back.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userId = Convert.ToInt32(list[2].ElementAt(userlist.SelectedIndex));
            _class=Convert.ToInt32(list[3].ElementAt(userlist.SelectedIndex));
            _homework = Convert.ToInt32(list[4].ElementAt(userlist.SelectedIndex));
            makeClassWord m = new makeClassWord(this,userlist.SelectedItem.ToString(),_userId,_class);
            m.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            _userId = Convert.ToInt32(list[2].ElementAt(userlist.SelectedIndex));
            game g = new game(_userId);
            g.Show();
            this.Hide();
        }
    }
}
