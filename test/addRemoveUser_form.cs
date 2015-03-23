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
    public partial class addRemoveUser_form : Form
    {
        Form _back;
        public addRemoveUser_form(Form back)
        {
            _back = back;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string chek = "no";
            if (adminCheckBox.Checked) {
                chek = "yes";
            }
            string username = userNameTextbox.Text;
            string Password = passwordTextbox.Text;
            try
            {
                db_connection k=new db_connection();
                bool m = k.same_user(username);
               
                if (m)
                {
                    DialogResult dialogResult = MessageBox.Show(" למחוק משתמש?", "מחיקה", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //k = new db_connection();
                        bool ans = k.remove_user(username);
                        MessageBox.Show((ans ? ("הוסר") : ("לא הוסר")));
                    }
                    else
                    {
                        DialogResult dialogResult2 = MessageBox.Show(" לדרוס משתמש?", "לדרוס משתמש", MessageBoxButtons.YesNo);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            //overwrites user
                            bool ans = k.remove_user(username);
                            k = new db_connection();
                            ans = k.insert_user(username, Password, chek);
                            MessageBox.Show((ans ? ("נדרס") : ("לא נדרס")));
                
                
                        }
                    }
                    
                }
                else
                {
                    //insert the user!
                   
                    bool ans= k.insert_user(username, Password, chek);
                    MessageBox.Show((ans ? ("הוכנס") : ("לא הוכנס")));
                }
            }
            catch { }
               
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _back.Show();
            this.Dispose();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void userNameTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
             string username = userNameTextbox.Text;
             try
             {
                 db_connection k = new db_connection();
                 bool m = k.same_user(username);

                 if (m)
                 {
                     bool ans=k.remove_user(username);
                     if (ans)
                         MessageBox.Show(ans?"נמחק":"לא נמחק");
                     
                 }
             }
            catch {}
        }

        private void addRemoveUser_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }
    }
}
