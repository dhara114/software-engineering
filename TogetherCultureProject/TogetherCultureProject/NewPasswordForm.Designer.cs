
namespace TogetherCultureProject
{
    partial class NewPasswordForm
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
            this.NewPassText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmNewPassText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmNewPassButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewPassText
            // 
            this.NewPassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.NewPassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPassText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassText.Location = new System.Drawing.Point(314, 184);
            this.NewPassText.Multiline = true;
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.Size = new System.Drawing.Size(216, 28);
            this.NewPassText.TabIndex = 18;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(311, 164);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(66, 17);
            this.PasswordLabel.TabIndex = 17;
            this.PasswordLabel.Text = "Password";
            // 
            // ConfirmNewPassText
            // 
            this.ConfirmNewPassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ConfirmNewPassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmNewPassText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPassText.Location = new System.Drawing.Point(314, 264);
            this.ConfirmNewPassText.Multiline = true;
            this.ConfirmNewPassText.Name = "ConfirmNewPassText";
            this.ConfirmNewPassText.Size = new System.Drawing.Size(216, 28);
            this.ConfirmNewPassText.TabIndex = 20;
            this.ConfirmNewPassText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Confirm Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmNewPassButton
            // 
            this.ConfirmNewPassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ConfirmNewPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmNewPassButton.FlatAppearance.BorderSize = 0;
            this.ConfirmNewPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmNewPassButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmNewPassButton.Location = new System.Drawing.Point(314, 337);
            this.ConfirmNewPassButton.Name = "ConfirmNewPassButton";
            this.ConfirmNewPassButton.Size = new System.Drawing.Size(216, 35);
            this.ConfirmNewPassButton.TabIndex = 21;
            this.ConfirmNewPassButton.Text = "CONFIRM";
            this.ConfirmNewPassButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enter your new password. It cannot be your last used password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmNewPassButton);
            this.Controls.Add(this.ConfirmNewPassText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassText);
            this.Controls.Add(this.PasswordLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewPasswordForm";
            this.Text = "NewPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPassText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox ConfirmNewPassText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmNewPassButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}