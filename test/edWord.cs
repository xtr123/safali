﻿using System;
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
    public partial class edWord_form : Form
    {
        string _id;
        List<string>[] list = new List<string>[3];
        Form _back;
        string word = "";
        byte[] im;
        string picpath = "";
        string[] nikud = { "", "\u05B0", "\u05B1", "\u05B2", "\u05B3", "\u05B4", "\u05B5", "\u05B6", "\u05B7", "\u05B8", "\u05B9", "\u05BB", "\u05BC", "ש\u05C1", "ש\u05C2" };
        public edWord_form(Form back)
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
            db_connection k = new db_connection();
            list = new List<string>[1];
            list[0] = new List<string>();
            list = k.Word();
            foreach (string elemnt in list[0])
            {
                comboBox21.Items.Add(elemnt);
            }
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
            string word =
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
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (res.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(res.FileName);
                Bitmap objBitmap = new Bitmap(image, new Size(pictureBox1.Height, pictureBox1.Width));
                pictureBox1.Image = objBitmap;
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
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx = comboBox21.SelectedIndex;
            _id = list[0].ElementAt(indx);
            db_connection m = new db_connection();
            string[] arr = m.getWordData(_id, pictureBox1);
            textBox1.Text = "" + arr[1];
            string word = arr[1];
            string w = "";
            string nikud = "";
            int[] count = new int[14];
            for (int i = 0; i < 14; i++) count[i] = -1;
            int Textb = 1;
            int Comb = 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'א' && word[i] <= 'ת')
                {
                    w += word[i];
                    string mi = "TextBox" + (Textb) + "";
                    Control[] t = Controls.Find(mi, true);
                    if (t.Length >= 0 && t[0].GetType() == typeof(TextBox))
                    {
                        ((TextBox)(t[0])).Text = word[i] + "";
                        Textb++;

                    }
                    if ((i + 1) < word.Length)
                    {
                        if (word[(i + 1)] >= 'א' && word[(i + 1)] <= 'ת')
                        {

                        }
                        else
                        {
                            string cb = "ComboBox" + (Textb - 1) + "";
                            Control[] t1 = Controls.Find(cb, true);
                            if (t1.Length >= 0 && t1[0].GetType() == typeof(ComboBox))
                            {

                                //MessageBox.Show(word[i] + "");
                                ((ComboBox)(t1[0])).Text = word[i + 1] + "";

                            }
                        }
                    }
                }

            }


            NumOfSyl.Text = "" + arr[2]; openSyl.Text = arr[3];
            comboBox15.Text = arr[4]; comboBox16.Text = arr[5];
            comboBox17.Text = arr[6]; comboBox18.Text = arr[7];
            comboBox19.Text = arr[8]; comboBox20.Text = arr[9];

        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void edWord_form_Load(object sender, EventArgs e)
        {

        }

        private void edWord_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _back.Show();
            this.Dispose();
        }

        //delete word
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("בטוח שברצונך למחוק את המילה", "מחיקת מילה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    db_connection k = new db_connection();
                    k.delword(comboBox21.Text);
                    edWord_form m = new edWord_form(_back);
                    m.Show();
                    this.Dispose();
                }
                catch { }
            }
            else
            {

            }
        }
    }
}