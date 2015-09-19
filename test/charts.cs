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
    public partial class charts : Form
    {
        List<string>[] list = new List<string>[3];
        Form _back = null;
        public charts(Form back)
        {
            InitializeComponent();
            _back = back;
          }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void charts_Load(object sender, EventArgs e)
        {
            db_connection k = new db_connection();
            list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            list = k.SelectUserNoPaitent();
            if (list[0].Count > 0)
            {
                userlist.DataSource = list[0];
            }
            int indx = userlist.SelectedIndex;

        }

        private void userlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(list[2].ElementAt(userlist.SelectedIndex));

            List<string>[] list2 = new List<string>[4];
            db_connection k = new db_connection();
            
            list2[0] = new List<string>();
            list2[1] = new List<string>();
            list2[2] = new List<string>();
            list2[3] = new List<string>();

            list2 = k.SelectUserAndGameStatus(userId);
            chart1.Series.Clear();
            chart1.Series.Add("Yes");
            chart1.Series.Add("No");
           for (int i = 0; i < list2[0].Count;i++ )
            {
                int sumYes=0,sumNo=0,f=-1;
                string clas=list2[2].ElementAt(i),classNumber=list2[3].ElementAt(i);
                while (i < list2[0].Count && clas.Equals(list2[2].ElementAt(i)) && classNumber.Equals(list2[3].ElementAt(i)))
                {
                    sumYes += Convert.ToInt32(list2[0].ElementAt(i));
                    sumNo += Convert.ToInt32(list2[1].ElementAt(i));
                    i++;
                    f = 1;

                }
                chart1.Series["Yes"].Points.AddXY(clas +"-"+classNumber+ "", sumYes);
                chart1.Series["No"].Points.AddXY(clas + "-" + classNumber + "" + "", sumNo);
                if (f == 1)
                {
                    i--;
                }
            }
        }

        private void charts_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }
        
    }
}

