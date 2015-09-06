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
    public partial class sylOptions : Form
    {
        Form _back;
        sylOptionsClass _syl;
        public sylOptions(Form back,int i)
        {
            
            _back = back;
            InitializeComponent();
            label2.Text = label2.Text + " " + i;
        }
        public sylOptions(Form back, int i,sylOptionsClass t)
        {

            _back = back;
            InitializeComponent();
            label2.Text = label2.Text + " " + i;
            comboBox15.Text = t._p_cut;
            comboBox16.Text = t._agia;
            comboBox17.Text = t._koliot;
            comboBox1.Text = t._openClose;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public sylOptionsClass Foo()
        {
           return _syl; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _syl = new sylOptionsClass(comboBox1.Text, comboBox15.Text, comboBox16.Text, comboBox17.Text);
            _back.Show();
           this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void sylOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
