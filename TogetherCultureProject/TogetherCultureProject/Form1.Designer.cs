
namespace LoginAndRegistration
{
    partial class RegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordText = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ShowPasswordChkbx = new System.Windows.Forms.CheckBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.AlreadyAccountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TownCityText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PostcodeText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MailListSub = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(30, 118);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 17);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "First Name";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // FirstNameText
            // 
            this.FirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.FirstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText.Location = new System.Drawing.Point(33, 138);
            this.FirstNameText.Multiline = true;
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(192, 28);
            this.FirstNameText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(33, 341);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(192, 28);
            this.PasswordText.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(30, 321);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(66, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ConfirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordText.Location = new System.Drawing.Point(255, 341);
            this.ConfirmPasswordText.Multiline = true;
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(192, 28);
            this.ConfirmPasswordText.TabIndex = 6;
            this.ConfirmPasswordText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(252, 321);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(120, 17);
            this.ConfirmPasswordLabel.TabIndex = 5;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            this.ConfirmPasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShowPasswordChkbx
            // 
            this.ShowPasswordChkbx.AutoSize = true;
            this.ShowPasswordChkbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordChkbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordChkbx.Location = new System.Drawing.Point(328, 375);
            this.ShowPasswordChkbx.Name = "ShowPasswordChkbx";
            this.ShowPasswordChkbx.Size = new System.Drawing.Size(119, 21);
            this.ShowPasswordChkbx.TabIndex = 7;
            this.ShowPasswordChkbx.Text = "Show Password";
            this.ShowPasswordChkbx.UseVisualStyleBackColor = true;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.ForeColor = System.Drawing.Color.White;
            this.RegButton.Location = new System.Drawing.Point(33, 411);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(216, 35);
            this.RegButton.TabIndex = 8;
            this.RegButton.Text = "REGISTER";
            this.RegButton.UseVisualStyleBackColor = false;
            // 
            // AlreadyAccountLabel
            // 
            this.AlreadyAccountLabel.AutoSize = true;
            this.AlreadyAccountLabel.Location = new System.Drawing.Point(30, 479);
            this.AlreadyAccountLabel.Name = "AlreadyAccountLabel";
            this.AlreadyAccountLabel.Size = new System.Drawing.Size(169, 17);
            this.AlreadyAccountLabel.TabIndex = 10;
            this.AlreadyAccountLabel.Text = "Already Have an Account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(30, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Back to Login";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LastNameText
            // 
            this.LastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.LastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.Location = new System.Drawing.Point(255, 138);
            this.LastNameText.Multiline = true;
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(192, 28);
            this.LastNameText.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(255, 204);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(308, 28);
            this.EmailText.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // PhoneNumText
            // 
            this.PhoneNumText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.PhoneNumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumText.Location = new System.Drawing.Point(33, 204);
            this.PhoneNumText.Multiline = true;
            this.PhoneNumText.Name = "PhoneNumText";
            this.PhoneNumText.Size = new System.Drawing.Size(192, 28);
            this.PhoneNumText.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone Number";
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(33, 262);
            this.AddressText.Multiline = true;
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(192, 28);
            this.AddressText.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address";
            // 
            // TownCityText
            // 
            this.TownCityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.TownCityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TownCityText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownCityText.Location = new System.Drawing.Point(255, 262);
            this.TownCityText.Multiline = true;
            this.TownCityText.Name = "TownCityText";
            this.TownCityText.Size = new System.Drawing.Size(192, 28);
            this.TownCityText.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Town/City";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PostcodeText
            // 
            this.PostcodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.PostcodeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostcodeText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostcodeText.Location = new System.Drawing.Point(473, 262);
            this.PostcodeText.Multiline = true;
            this.PostcodeText.Name = "PostcodeText";
            this.PostcodeText.Size = new System.Drawing.Size(192, 28);
            this.PostcodeText.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Postcode";
            // 
            // MailListSub
            // 
            this.MailListSub.AutoSize = true;
            this.MailListSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MailListSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MailListSub.Location = new System.Drawing.Point(589, 211);
            this.MailListSub.Name = "MailListSub";
            this.MailListSub.Size = new System.Drawing.Size(177, 21);
            this.MailListSub.TabIndex = 24;
            this.MailListSub.Text = "Subscribe to Mailing List";
            this.MailListSub.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.MailListSub);
            this.Controls.Add(this.PostcodeText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TownCityText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneNumText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlreadyAccountLabel);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ShowPasswordChkbx);
            this.Controls.Add(this.ConfirmPasswordText);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordText;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.CheckBox ShowPasswordChkbx;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label AlreadyAccountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TownCityText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PostcodeText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox MailListSub;
    }
}

