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
    public partial class makeClassWord : Form
    {
        List<string>[] list = new List<string>[3];

        Form _back;
        string _userName;
        string _where;
        public makeClassWord(Form back,string name)
        {
            _back = back;
            _userName = name;
            InitializeComponent();
            label1.Text = _userName + label1.Text;
            
        }

        private void makeClassWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //syllable
            int f = 0;
            _where = " where";
            if (NumOfSyl.Text != null && NumOfSyl.Text != "") {
              _where = _where + " syllable='" +NumOfSyl.Text+ "'";
              f = 1;
            }
            //openClose
             if (openSyl.Text != null && openSyl.Text != "") {
                 string b;
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 if (openSyl.Text == "כן")
                 {
                     b = "Open";
                 }
                 else
                 {
                     b = "Close";
                 }
                 _where = _where + " openClose='" + b + "'";
                 f = 1;
            }
            //p_cut
             if (comboBox15.SelectedItem != null && comboBox15.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " p_cut='" + comboBox15.SelectedItem + "'";
                 f = 1;
             }
            //agaia
             if (comboBox16.SelectedItem != null && comboBox16.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " agaia='" + comboBox16.SelectedItem + "'";
                 f = 1;
             }
            
            //koliut
             if (comboBox17.SelectedItem != null && comboBox17.SelectedItem != "'")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " koliut='" + comboBox17.SelectedItem + "'";
                 f = 1;
             }
            //atama
             if (comboBox18.SelectedItem != null && comboBox18.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " atama='" + comboBox18.SelectedItem + "'";
                 f = 1;
             }
            
            //diber
             if (comboBox19.SelectedItem != null && comboBox19.SelectedItem != "")
                {
                    if (f == 1)
                    {
                        _where = _where + " AND";
                    }
                 _where = _where + " diber='" + comboBox19.SelectedItem + "'";
                 f = 1;
             }
            
            //tzlil_place
             if (comboBox20.SelectedItem != null && comboBox20.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " tzlil_place='" + comboBox20.SelectedItem + "'";
             }
             _where = _where + ";";

            //selectWord m = new selectWord(_where);
            //m.Show();
             db_connection m = new db_connection();
             list = new List<string>[1];
             list[0] = new List<string>();
             list = m.selectWord_withWhere(_where);
             if (list[0].Count > 0)
             {
                 checkedListBox1.DataSource = list[0];
             }

        }

        private void NumOfSyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void openSyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makeClassWord_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var items = new System.Collections.ArrayList(checkedListBox1.CheckedItems);

             foreach (var item in items)
            {
                checkedListBox2.Items.Add(item);
                
             }

        }
    }
}
