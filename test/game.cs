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
    public partial class game : Form
    {
        int _userId;
        public game(int userId)
        {
            _userId = userId;
            InitializeComponent();
            db_connection k = new db_connection();
            int j=k.getCurrentClass(_userId);
            MessageBox.Show(j + "");
        }
    }
}
