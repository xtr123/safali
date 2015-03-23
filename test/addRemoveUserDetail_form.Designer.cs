namespace test
{
    partial class addRemoveUserDetail_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameAndFamily = new System.Windows.Forms.TextBox();
            this.idNumber = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.homePhone = new System.Windows.Forms.TextBox();
            this.cellPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(355, 12);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(121, 21);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ":שם ושם משפחה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":תעודת זהות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":גיל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = ":עיר מגורים";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = ":רחוב";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = ":טלפון נייד";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = ":טלפון בבית";
            // 
            // nameAndFamily
            // 
            this.nameAndFamily.Location = new System.Drawing.Point(143, 79);
            this.nameAndFamily.Name = "nameAndFamily";
            this.nameAndFamily.Size = new System.Drawing.Size(236, 20);
            this.nameAndFamily.TabIndex = 8;
            // 
            // idNumber
            // 
            this.idNumber.Location = new System.Drawing.Point(143, 120);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(236, 20);
            this.idNumber.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(143, 153);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(236, 20);
            this.age.TabIndex = 10;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(143, 184);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(236, 20);
            this.city.TabIndex = 11;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(143, 211);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(236, 20);
            this.street.TabIndex = 12;
            // 
            // homePhone
            // 
            this.homePhone.Location = new System.Drawing.Point(143, 242);
            this.homePhone.Name = "homePhone";
            this.homePhone.Size = new System.Drawing.Size(236, 20);
            this.homePhone.TabIndex = 13;
            // 
            // cellPhone
            // 
            this.cellPhone.Location = new System.Drawing.Point(143, 277);
            this.cellPhone.Name = "cellPhone";
            this.cellPhone.Size = new System.Drawing.Size(236, 20);
            this.cellPhone.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "מין";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(317, 313);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(61, 21);
            this.gender.TabIndex = 16;
            this.gender.Text = "זכר";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(262, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 17;
            this.edit.Text = "ערוך";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(30, 331);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "ביטול";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addRemoveUserDetail_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 375);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cellPhone);
            this.Controls.Add(this.homePhone);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.age);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.nameAndFamily);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userList);
            this.Name = "addRemoveUserDetail_form";
            this.Text = "addRemoveUserDetail_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addRemoveUserDetail_form_FormClosing);
            this.Load += new System.EventHandler(this.addRemoveUserDetail_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameAndFamily;
        private System.Windows.Forms.TextBox idNumber;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox homePhone;
        private System.Windows.Forms.TextBox cellPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
    }
}