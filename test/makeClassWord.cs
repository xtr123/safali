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
        int _userId;
        int _classNumber;
        public makeClassWord(Form back,string name,int userId,int classNumber)
        {
            _classNumber = classNumber+1;
            _back = back;
            _userName = name;
            _userId = userId;
            InitializeComponent();
            label1.Text = _userName + label1.Text;
            
        }

        private void makeClassWord_FormClosing(object sender, FormClosingEventArgs e)
        {
           patitionetSelect_Form k = new patitionetSelect_Form(null);
           k.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
             list = new List<string>[2];
             list[0] = new List<string>();
             list = m.selectWord_withWhere(_where);
             if (list[0].Count > 0)
             {
                 foreach (string element in list[0])
                 {
                     listBox1.Items.Add(element);
                 }
                
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
            
            if (this.listBox1.SelectedIndex >= 0) {
                listBox2.Items.Add(listBox1.SelectedItem);
                
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("צריך לבחור מילה מהרשימה");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);

                this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("צריך לבחור מילה מהרשימה");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count <= 0)
            {
                MessageBox.Show("חייב להיות מילים להכניס.");
            }
            else
            {
                //the insertation
                //_userid
                bool j = false ;
                foreach (string element in listBox2.Items)
                {
                    //class
                    //user id
                   //word id MessageBox.Show(list[1].ElementAt(list[0].IndexOf(element))+"");
                    db_connection m = new db_connection();
                   j = m.insert_words_to_class(0, Convert.ToInt32(list[1].ElementAt(list[0].IndexOf(element))), _userId,_classNumber);
                   
                }
                MessageBox.Show(j + "");
            }
        }
    }
}
