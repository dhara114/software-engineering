
namespace LoginAndRegistration
{
    partial class ForgotPasswordForm
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
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VeriCodeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmCodeButton = new System.Windows.Forms.Button();
            this.SendCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(275, 122);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(308, 28);
            this.EmailText.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(272, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(272, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "A verification code will be sent to this email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VeriCodeText
            // 
            this.VeriCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.VeriCodeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VeriCodeText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeriCodeText.Location = new System.Drawing.Point(275, 272);
            this.VeriCodeText.Multiline = true;
            this.VeriCodeText.Name = "VeriCodeText";
            this.VeriCodeText.Size = new System.Drawing.Size(308, 28);
            this.VeriCodeText.TabIndex = 20;
            this.VeriCodeText.TextChanged += new System.EventHandler(this.VeriCodeText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(272, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Your Verification Code";
            // 
            // ConfirmCodeButton
            // 
            this.ConfirmCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ConfirmCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmCodeButton.FlatAppearance.BorderSize = 0;
            this.ConfirmCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmCodeButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmCodeButton.Location = new System.Drawing.Point(324, 319);
            this.ConfirmCodeButton.Name = "ConfirmCodeButton";
            this.ConfirmCodeButton.Size = new System.Drawing.Size(216, 35);
            this.ConfirmCodeButton.TabIndex = 21;
            this.ConfirmCodeButton.Text = "CONFIRM";
            this.ConfirmCodeButton.UseVisualStyleBackColor = false;
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.SendCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCodeButton.FlatAppearance.BorderSize = 0;
            this.SendCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendCodeButton.ForeColor = System.Drawing.Color.White;
            this.SendCodeButton.Location = new System.Drawing.Point(324, 195);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(216, 35);
            this.SendCodeButton.TabIndex = 22;
            this.SendCodeButton.Text = "SEND CODE";
            this.SendCodeButton.UseVisualStyleBackColor = false;
            this.SendCodeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.SendCodeButton);
            this.Controls.Add(this.ConfirmCodeButton);
            this.Controls.Add(this.VeriCodeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VeriCodeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmCodeButton;
        private System.Windows.Forms.Button SendCodeButton;
    }
}