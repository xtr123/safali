namespace test
{
    partial class administratorMain_Panle
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
            this.titleLable = new System.Windows.Forms.Label();
            this.addRemoveUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add_remove_Word_button = new System.Windows.Forms.Button();
            this.edit_word = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Location = new System.Drawing.Point(505, 21);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(0, 13);
            this.titleLable.TabIndex = 0;
            // 
            // addRemoveUser
            // 
            this.addRemoveUser.Location = new System.Drawing.Point(390, 57);
            this.addRemoveUser.Name = "addRemoveUser";
            this.addRemoveUser.Size = new System.Drawing.Size(170, 23);
            this.addRemoveUser.TabIndex = 1;
            this.addRemoveUser.Text = "הוספה\\הסרת משתמש";
            this.addRemoveUser.UseVisualStyleBackColor = true;
            this.addRemoveUser.Click += new System.EventHandler(this.addRemoveUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "הוספה\\הסרת פרטי משתמש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_remove_Word_button
            // 
            this.add_remove_Word_button.Location = new System.Drawing.Point(390, 167);
            this.add_remove_Word_button.Name = "add_remove_Word_button";
            this.add_remove_Word_button.Size = new System.Drawing.Size(170, 23);
            this.add_remove_Word_button.TabIndex = 3;
            this.add_remove_Word_button.Text = "הוספה \\ הסרה מילים";
            this.add_remove_Word_button.UseVisualStyleBackColor = true;
            this.add_remove_Word_button.Click += new System.EventHandler(this.add_remove_Word_button_Click);
            // 
            // edit_word
            // 
            this.edit_word.Location = new System.Drawing.Point(390, 221);
            this.edit_word.Name = "edit_word";
            this.edit_word.Size = new System.Drawing.Size(170, 23);
            this.edit_word.TabIndex = 4;
            this.edit_word.Text = "עריכת מילה";
            this.edit_word.UseVisualStyleBackColor = true;
            this.edit_word.Click += new System.EventHandler(this.edit_word_Click);
            // 
            // administratorMain_Panle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 316);
            this.Controls.Add(this.edit_word);
            this.Controls.Add(this.add_remove_Word_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addRemoveUser);
            this.Controls.Add(this.titleLable);
            this.Name = "administratorMain_Panle";
            this.Text = "administratorMain_Panle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.administratorMain_Panle_FormClosing);
            this.Load += new System.EventHandler(this.administratorMain_Panle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button addRemoveUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_remove_Word_button;
        private System.Windows.Forms.Button edit_word;
    }
}