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

namespace test
{
    public partial class addremoveWord_form : Form
    {
        Form _back;
        string[] nikud = { "", "\u05B0", "\u05B1", "\u05B2", "\u05B3", "\u05B4", "\u05B5", "\u05B6", "\u05B7", "\u05B8", "\u05B9", "\u05BB", "\u05BC", "ש\u05C1", "ש\u05C2" };
        string word = "";
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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool ans;
            byte[] imageBT = null;
                FileStream fstream = new FileStream(picpath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);
            try
            {
                milaAlgo m = new milaAlgo(word);
                string nos = "" + m.MisparHavarot();
                string oc = "";
                if (m._havaraPtuha.Equals("") && !m._havaraSgura.Equals(""))
                {
                    oc = "Open";
                }
                else oc = "Close";
                db_connection k = new db_connection();
                    ans = k.insert_word(word, nos, oc, comboBox15.Text, comboBox16.Text, comboBox17.Text, comboBox18.Text, comboBox19.Text, comboBox20.Text, im);

                if (ans)
                {
                    MessageBox.Show("Insert");
                }
                else
                {
                    MessageBox.Show("Not insert");
                }
            }
            catch { }
            DialogResult dialogResult = MessageBox.Show("להכניס מילה נוספת?", "הוספת מילה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NumOfSyl.ResetText();
                ClodeSyl.ResetText();
                openSyl.ResetText();
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
                comboBox15.ResetText();
                comboBox16.ResetText();
                comboBox17.ResetText();
                comboBox18.ResetText();
                comboBox19.ResetText();
                comboBox20.ResetText();

            }
            else if (dialogResult == DialogResult.No)
            {
                _back.Show();
                this.Dispose();
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

        private void numOfSyllable_Button_Click(object sender, EventArgs e)
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
    }
}
