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
    public partial class selectWord : Form
    {
        
        string _id;
        List<string>[] list = new List<string>[3];
        string _where;
        public selectWord(string where)
        {
            _where = where;
            InitializeComponent();
        }

        private void selectWord_Load(object sender, EventArgs e)
        {
            db_connection m = new db_connection();
            list = new List<string>[1];
            list[0] = new List<string>();
            list = m.selectWord_withWhere(_where);
            if (list[0].Count > 0)
            {
                checkedListBox1.DataSource = list[0];
            }

        }

        private void selectWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
