using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;


namespace test
{
    public partial class addremoveWord_form : Form
    {
        sylOptionsClass havara1=new sylOptionsClass();
        sylOptionsClass havara2 = new sylOptionsClass();
        sylOptionsClass havara3 = new sylOptionsClass();
        sylOptionsClass havara4 = new sylOptionsClass();

        Form _back;
        string[] nikud = { "", "א\u05B0", "א\u05B1", "א\u05B2", "א\u05B3", "א\u05B4", "א\u05B5", "א\u05B6", "א\u05B7", "א\u05B8", "א\u05B9", "א\u05BB", "ב\u05BC", "ש\u05C1", "ש\u05C2" };
        string word = "";
        string word_no_nikud="";
        byte[] im;
        string picpath = "";
        // string im;
        public addremoveWord_form(Form back)
        {
            _back = back;
            InitializeComponent();
            comboBox1.DataSource = nikud.Clone();
            comboBox2.DataSource = nikud.Clone();
            comboBox3.DataSource = nikud.Clone();
            comboBox4.DataSource = nikud.Clone();
            comboBox5.DataSource = nikud.Clone();
            comboBox6.DataSource = nikud.Clone();
            comboBox7.DataSource = nikud.Clone();
            comboBox8.DataSource = nikud.Clone();
            comboBox9.DataSource = nikud.Clone();
            comboBox10.DataSource = nikud.Clone();
            comboBox11.DataSource = nikud.Clone();
            comboBox12.DataSource = nikud.Clone();
            comboBox13.DataSource = nikud.Clone();
            comboBox14.DataSource = nikud.Clone();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            if (textBox1.Text[0] < 'א' || textBox1.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox1.Text = "";
            } 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            if (textBox2.Text[0] < 'א' || textBox2.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox2.Text = "";
        }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            if (textBox3.Text[0] < 'א' || textBox3.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox3.Text = "";
        }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            if (textBox14.Text != "")
            if (textBox14.Text[0] < 'א' || textBox14.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox14.Text = "";
            } 
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            if (textBox12.Text[0] < 'א' || textBox12.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox12.Text = "";
            } 
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            if (textBox11.Text[0] < 'א' || textBox11.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox11.Text = "";
            } 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            if (textBox10.Text[0] < 'א' || textBox10.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox10.Text = "";
            } 
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            if (textBox9.Text[0] < 'א' || textBox9.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox9.Text = "";
        }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
             if (textBox8.Text[0] < 'א' || textBox8.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox8.Text = "";
        }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")

            if (textBox7.Text[0] < 'א' || textBox7.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox7.Text = "";
        }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")

            if (textBox6.Text[0] < 'א' || textBox6.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox6.Text = "";
        }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")

            if (textBox5.Text[0] < 'א' || textBox5.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox5.Text = "";
            } 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")

            if (textBox4.Text[0] < 'א' || textBox4.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox4.Text = "";
            } 
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "")

            if (textBox13.Text[0] < 'א' || textBox13.Text[0] > 'ת')
            {
                MessageBox.Show("רק אותיות בעברית");
                textBox13.Text = "";
            } 
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (picpath == null || picpath == "")
            {
                MessageBox.Show("לא נבחרה תמונה");
            }
            else
            {
                byte[] imageBT = null;
                FileStream fstream = new FileStream(picpath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);
                if (word == null || word.Length == 0)
                {

                    word =
                     textBox1.Text + ((comboBox1.Text != "") ? comboBox1.Text[1] + "" : "") +
                    textBox2.Text + ((comboBox2.Text != "") ? comboBox2.Text[1] + "" : "") +
                    textBox3.Text + ((comboBox3.Text != "") ? comboBox3.Text[1] + "" : "") +
                    textBox4.Text + ((comboBox4.Text != "") ? comboBox4.Text[1] + "" : "") +
                    textBox5.Text + ((comboBox5.Text != "") ? comboBox5.Text[1] + "" : "") +
                    textBox6.Text + ((comboBox6.Text != "") ? comboBox6.Text[1] + "" : "") +
                    textBox7.Text + ((comboBox7.Text != "") ? comboBox7.Text[1] + "" : "") +
                    textBox8.Text + ((comboBox8.Text != "") ? comboBox8.Text[1] + "" : "") +
                    textBox9.Text + ((comboBox9.Text != "") ? comboBox9.Text[1] + "" : "") +
                    textBox10.Text + ((comboBox10.Text != "") ? comboBox10.Text[1] + "" : "") +
                    textBox11.Text + ((comboBox11.Text != "") ? comboBox11.Text[1] + "" : "") +
                    textBox12.Text + ((comboBox12.Text != "") ? comboBox12.Text[1] + "" : "") +
                    textBox13.Text + ((comboBox13.Text != "") ? comboBox13.Text[1] + "" : "") +
                    textBox14.Text + ((comboBox14.Text != "") ? comboBox14.Text[1] + "" : "");
                    word_no_nikud =
                        textBox1.Text +
                        textBox2.Text +
                        textBox3.Text +
                        textBox4.Text +
                        textBox5.Text +
                        textBox6.Text +
                        textBox7.Text +
                        textBox8.Text +
                        textBox9.Text +
                        textBox10.Text +
                        textBox11.Text +
                        textBox12.Text +
                        textBox13.Text +
                        textBox14.Text ;
                }
                
                try
                {
                    milaAlgo m = new milaAlgo(word);
                    //string nos = "" + m.MisparHavarot();
                    string nos = NumOfSyl.Text;
                    string oc = "";
                    if (m._havaraPtuha.Equals("") && !m._havaraSgura.Equals(""))
                    {
                        oc = "Open";
                    }
                    else oc = "Close";
                    db_connection k = new db_connection();
                    
                    bool ans = k.insert_word(word, nos, havara1, havara2, havara3, havara4, comboBox18.Text, comboBox19.Text, "", im,word_no_nikud);
                    if (ans)
                    {
                        MessageBox.Show("המילה עודכנה במילון, תודה");
                    }
                    else
                    {
                        MessageBox.Show("שגיאה, עדכון המילון לא הצליח, נא לנסות שנית");
                    }
                }
                catch { }
                DialogResult dialogResult = MessageBox.Show("להכניס מילה נוספת?", "הוספת מילה", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NumOfSyl.ResetText();
                    pictureBox1.Image = null;
                    comboBox1.ResetText(); textBox1.ResetText();
                    comboBox2.ResetText(); textBox2.ResetText();
                    comboBox3.ResetText(); textBox3.ResetText();
                    comboBox4.ResetText(); textBox4.ResetText();
                    comboBox5.ResetText(); textBox5.ResetText();
                    comboBox6.ResetText(); textBox6.ResetText();
                    comboBox7.ResetText(); textBox7.ResetText();
                    comboBox8.ResetText(); textBox8.ResetText();
                    comboBox9.ResetText(); textBox9.ResetText();
                    comboBox10.ResetText(); textBox10.ResetText();
                    comboBox11.ResetText(); textBox11.ResetText();
                    comboBox12.ResetText(); textBox12.ResetText();
                    comboBox13.ResetText(); textBox13.ResetText();
                    comboBox14.ResetText(); textBox14.ResetText();
                    comboBox18.ResetText();
                    comboBox19.ResetText();
                    word = "";

                }
                else if (dialogResult == DialogResult.No)
                {
                    _back.Show();
                    this.Dispose();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            res.FilterIndex = 2;
            res.Title = "בחירת תמונה";
            
            if (res.ShowDialog() == DialogResult.OK)
            {
             
                pictureBox1.Image = Image.FromFile(res.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                im = ms.GetBuffer();
                picpath = res.FileName.ToString();
                
             
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Open_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       /* private void numOfSyllable_Button_Click(object sender, EventArgs e)
        {
            word =
                textBox1.Text + comboBox1.Text +
                textBox2.Text + comboBox2.Text +
                textBox3.Text + comboBox3.Text +
                textBox4.Text + comboBox4.Text +
                textBox5.Text + comboBox5.Text +
                textBox6.Text + comboBox6.Text +
                textBox7.Text + comboBox7.Text +
                textBox8.Text + comboBox8.Text +
                textBox9.Text + comboBox9.Text +
                textBox10.Text + comboBox10.Text +
                textBox11.Text + comboBox11.Text +
                textBox12.Text + comboBox12.Text +
                textBox13.Text + comboBox13.Text +
                textBox14.Text + comboBox14.Text;
            milaAlgo m = new milaAlgo(word);
            NumOfSyl.Text = "" + m.MisparHavarot();
            if (m._havaraPtuha.Equals("") && !m._havaraSgura.Equals(""))
            {
                ClodeSyl.Text = "כן";
                openSyl.Text = "לא";
            }
            else
            {
                ClodeSyl.Text = "לא";
                openSyl.Text = "כן";
            }
            //MessageBox.Show(m.MisparHavarot() + " Ptucha: " + m._havaraPtuha + " Sgura: " + m._havaraSgura);
        }
        */
        private void NumOfSyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       /* public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }*/
        byte[] ImageToByte(string s)
        {
            FileInfo fi = new FileInfo(s);
            long size = fi.Length;
            FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] data = br.ReadBytes((int)size);
            return data;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void addremoveWord_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            sylOptions k = new sylOptions(this,i);
            if (NumOfSyl.Text != "" && i <= Convert.ToInt32(NumOfSyl.Text))
            {
                if (k.ShowDialog(this) == DialogResult.OK)
            {
                havara1 = k.Foo();
            }
            }
            i++;
            sylOptions k2 = new sylOptions(this, i);
            if (NumOfSyl.Text != "" && i <= Convert.ToInt32(NumOfSyl.Text))
            {
                if (k2.ShowDialog(this) == DialogResult.OK)
                {
                    havara2 = k2.Foo();
                }
            }
            i++;
            sylOptions k3 = new sylOptions(this, i);
            if (NumOfSyl.Text != "" &&  i <= Convert.ToInt32(NumOfSyl.Text))
            {
                if (k3.ShowDialog(this) == DialogResult.OK)
                {
                    havara3 = k3.Foo();
                }
            }
            i++;
            sylOptions k4 = new sylOptions(this, i);
            if (NumOfSyl.Text != "" &&  i <= Convert.ToInt32(NumOfSyl.Text))
            {
                if (k4.ShowDialog(this) == DialogResult.OK)
                {
                    havara4 = k4.Foo();
                }
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            milaAlgo k = new milaAlgo(
                    textBox1.Text + ((comboBox1.Text != "") ? comboBox1.Text[1] + "" : "") +
                    textBox2.Text + ((comboBox2.Text != "") ? comboBox2.Text[1] + "" : "") +
                    textBox3.Text + ((comboBox3.Text != "") ? comboBox3.Text[1] + "" : "") +
                    textBox4.Text + ((comboBox4.Text != "") ? comboBox4.Text[1] + "" : "") +
                    textBox5.Text + ((comboBox5.Text != "") ? comboBox5.Text[1] + "" : "") +
                    textBox6.Text + ((comboBox6.Text != "") ? comboBox6.Text[1] + "" : "") +
                    textBox7.Text + ((comboBox7.Text != "") ? comboBox7.Text[1] + "" : "") +
                    textBox8.Text + ((comboBox8.Text != "") ? comboBox8.Text[1] + "" : "") +
                    textBox9.Text + ((comboBox9.Text != "") ? comboBox9.Text[1] + "" : "") +
                    textBox10.Text + ((comboBox10.Text != "") ? comboBox10.Text[1] + "" : "") +
                    textBox11.Text + ((comboBox11.Text != "") ? comboBox11.Text[1] + "" : "") +
                    textBox12.Text + ((comboBox12.Text != "") ? comboBox12.Text[1] + "" : "") +
                    textBox13.Text + ((comboBox13.Text != "") ? comboBox13.Text[1] + "" : "") +
                    textBox14.Text + ((comboBox14.Text != "") ? comboBox14.Text[1] + "" : ""));
            NumOfSyl.Text = k.MisparHavarot()+"";
        }
    }
}
