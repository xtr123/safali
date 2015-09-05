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
        int _class;
        public makeClassWord(Form back,string name,int userId,int classNumber,int classHome)
        {
            _class = classHome;
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
            //openClose1
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem != "")
            {
                 
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " openClose1='" + comboBox1.SelectedItem + "'";
                 f = 1;
            }
            //p_cut1
             if (comboBox2.SelectedItem != null && comboBox2.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " p_cut1='" + comboBox2.SelectedItem + "'";
                 f = 1;
             }
            //agaia1
             if (comboBox3.SelectedItem != null && comboBox3.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " agaia1='" + comboBox3.SelectedItem + "'";
                 f = 1;
             }
            
            //koliut1
             if (comboBox4.SelectedItem != null && comboBox4.SelectedItem != "'")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " koliut1='" + comboBox4.SelectedItem + "'";
                 f = 1;
             }
             //openClose2
             if (comboBox5.SelectedItem != null && comboBox5.SelectedItem != "")
             {

                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " openClose2='" + comboBox5.SelectedItem + "'";
                 f = 1;
             }
             //p_cut2
             if (comboBox6.SelectedItem != null && comboBox6.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " p_cut2='" + comboBox6.SelectedItem + "'";
                 f = 1;
             }
             //agaia2
             if (comboBox7.SelectedItem != null && comboBox7.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " agaia2='" + comboBox7.SelectedItem + "'";
                 f = 1;
             }

             //koliut2
             if (comboBox8.SelectedItem != null && comboBox8.SelectedItem != "'")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " koliut2='" + comboBox8.SelectedItem + "'";
                 f = 1;
             }
             //openClose3
             if (comboBox13.SelectedItem != null && comboBox13.SelectedItem != "")
             {

                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " openClose3='" + comboBox13.SelectedItem + "'";
                 f = 1;
             }
             //p_cut3
             if (comboBox14.SelectedItem != null && comboBox14.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " p_cut3='" + comboBox14.SelectedItem + "'";
                 f = 1;
             }
             //agaia3
             if (comboBox21.SelectedItem != null && comboBox21.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " agaia3='" + comboBox21.SelectedItem + "'";
                 f = 1;
             }

             //koliut3
             if (comboBox22.SelectedItem != null && comboBox22.SelectedItem != "'")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " koliut3='" + comboBox22.SelectedItem + "'";
                 f = 1;
             }
             //openClose4
             if (comboBox9.SelectedItem != null && comboBox9.SelectedItem != "")
             {

                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " openClose4='" + comboBox9.SelectedItem + "'";
                 f = 1;
             }
             //p_cut4
             if (comboBox10.SelectedItem != null && comboBox10.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " p_cut4='" + comboBox10.SelectedItem + "'";
                 f = 1;
             }
             //agaia4
             if (comboBox11.SelectedItem != null && comboBox11.SelectedItem != "")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " agaia4='" + comboBox11.SelectedItem + "'";
                 f = 1;
             }

             //koliut4
             if (comboBox12.SelectedItem != null && comboBox12.SelectedItem != "'")
             {
                 if (f == 1)
                 {
                     _where = _where + " AND";
                 }
                 _where = _where + " koliut4='" + comboBox12.SelectedItem + "'";
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
                   j = m.insert_words_to_class(_class, Convert.ToInt32(list[1].ElementAt(list[0].IndexOf(element))), _userId,_classNumber);
                   
                }
                MessageBox.Show(j + "");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
