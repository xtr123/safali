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
    public partial class addRemoveUserDetail_form : Form
    {
        string _id;

        List<string>[] list= new List<string>[3];
        Form _back;
        public addRemoveUserDetail_form(Form t)
        {
            _back = t;
            InitializeComponent();

            //set all disable
            gender.Enabled = false;
            cellPhone.Enabled = false;
            homePhone.Enabled = false;
            street.Enabled = false;
            city.Enabled = false;
            nameAndFamily.Enabled = false;
            idNumber.Enabled = false;
            age.Enabled = false;

        }

        private void addRemoveUserDetail_form_Load(object sender, EventArgs e)
        {
            gender.Items.Add ( "נקבה");
            gender.Items.Add("זכר");
            
            db_connection k = new db_connection();
            list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list=k.SelectUser();
            if (list[0].Count > 0)
            {
                userList.DataSource = list[0];
            }
        }
        //INSERT INTO `safali`.`userdetails` (`id`, `idNumber`, `userName`, `userGender`, `userAge`, `userCity`, `userStreet`, `userHouseNumber`, `userCellPhone`) VALUES ('1', '301467726', 'גיל בראון', 'זכר', '25', 'בני עטרות', 'משק 82', '077777', '099999');
        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx=userList.SelectedIndex;
            _id = list[2].ElementAt(indx);
            gender.Enabled = false;
            cellPhone.Enabled = false;
            homePhone.Enabled = false;
            street.Enabled = false;
            city.Enabled = false;
            nameAndFamily.Enabled = false;
            idNumber.Enabled = false;
            age.Enabled = false;
            //MessageBox.Show("id " + _id  + "");  
            db_connection m = new db_connection();
            string[] arr = m.getUserData(_id);

            gender.SelectedIndex=gender.FindString(arr[3]);
           // gender.Text = arr[3];
            cellPhone.Text = arr[8];
            homePhone.Text =  arr[7];
            street.Text = arr[6];
            city.Text =  arr[5];
            nameAndFamily.Text = arr[2];
            idNumber.Text = arr[1];
            age.Text =  arr[4];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gender.Enabled =true;
            cellPhone.Enabled = true;
            homePhone.Enabled = true;
            street.Enabled = true;
            city.Enabled = true;
            nameAndFamily.Enabled = true;
            idNumber.Enabled = true;
            age.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            db_connection k = new db_connection();

            bool ans = k.inser_user_details(_id,idNumber.Text,nameAndFamily.Text,gender.Text,age.Text,city.Text,street.Text,homePhone.Text,cellPhone.Text);
            MessageBox.Show(ans+"");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _back.Show();
            this.Dispose();
        }

        private void addRemoveUserDetail_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }
    }
}
