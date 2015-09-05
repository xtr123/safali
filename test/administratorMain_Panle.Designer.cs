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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administratorMain_Panle));
            this.titleLable = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.edit_word = new System.Windows.Forms.Button();
            this.add_remove_Word_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addRemoveUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            resources.ApplyResources(this.titleLable, "titleLable");
            this.titleLable.Name = "titleLable";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::test.Properties.Resources.admin_icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // edit_word
            // 
            this.edit_word.BackgroundImage = global::test.Properties.Resources.edit_word;
            resources.ApplyResources(this.edit_word, "edit_word");
            this.edit_word.Name = "edit_word";
            this.edit_word.UseVisualStyleBackColor = true;
            this.edit_word.Click += new System.EventHandler(this.edit_word_Click);
            // 
            // add_remove_Word_button
            // 
            this.add_remove_Word_button.BackgroundImage = global::test.Properties.Resources.penguine1;
            resources.ApplyResources(this.add_remove_Word_button, "add_remove_Word_button");
            this.add_remove_Word_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_remove_Word_button.Name = "add_remove_Word_button";
            this.add_remove_Word_button.UseVisualStyleBackColor = true;
            this.add_remove_Word_button.Click += new System.EventHandler(this.add_remove_Word_button_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::test.Properties.Resources.details;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addRemoveUser
            // 
            this.addRemoveUser.BackgroundImage = global::test.Properties.Resources.add_remove_user;
            resources.ApplyResources(this.addRemoveUser, "addRemoveUser");
            this.addRemoveUser.Name = "addRemoveUser";
            this.addRemoveUser.UseVisualStyleBackColor = true;
            this.addRemoveUser.Click += new System.EventHandler(this.addRemoveUser_Click);
            // 
            // administratorMain_Panle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.edit_word);
            this.Controls.Add(this.add_remove_Word_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addRemoveUser);
            this.Controls.Add(this.titleLable);
            this.HelpButton = true;
            this.Name = "administratorMain_Panle";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.administratorMain_Panle_FormClosing);
            this.Load += new System.EventHandler(this.administratorMain_Panle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button addRemoveUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_remove_Word_button;
        private System.Windows.Forms.Button edit_word;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}