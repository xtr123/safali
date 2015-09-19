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
    public partial class administratorMain_Panle : Form
    {
        string _name;
        Form _back=null;
        public administratorMain_Panle(string name,Form back)
        {
            _back = back;
            _name = name;

            InitializeComponent();
        }

        private void administratorMain_Panle_Load(object sender, EventArgs e)
        {
            string tmp = "ברוך הבא,";
            titleLable.Text = tmp +" " + _name;
        }

        private void addRemoveUser_Click(object sender, EventArgs e)
        {
            addRemoveUser_form view = new addRemoveUser_form(this);
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addRemoveUserDetail_form m = new addRemoveUserDetail_form(this);
            m.Show();
        }

        private void add_remove_Word_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            addremoveWord_form m = new addremoveWord_form(this);
            m.Show();
        }

        private void edit_word_Click(object sender, EventArgs e)
        {
            this.Hide();
            edWord_form m = new edWord_form(this);
            m.Show();
        }

        private void administratorMain_Panle_FormClosing(object sender, FormClosingEventArgs e)
        {
           _back.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            charts k = new charts(this);
            k.Show();
            this.Hide();
        }


      
    }
}
