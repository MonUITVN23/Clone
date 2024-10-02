namespace NT106.P13_Exercise2
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblReUsername = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblReConfirmPassword = new System.Windows.Forms.Label();
            this.lblReEmail = new System.Windows.Forms.Label();
            this.lblReThumnail = new System.Windows.Forms.Label();
            this.textReUsername = new System.Windows.Forms.TextBox();
            this.textReEmail = new System.Windows.Forms.TextBox();
            this.textRePassword = new System.Windows.Forms.TextBox();
            this.textReConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReUsername
            // 
            this.lblReUsername.AutoSize = true;
            this.lblReUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblReUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReUsername.Location = new System.Drawing.Point(117, 162);
            this.lblReUsername.Name = "lblReUsername";
            this.lblReUsername.Size = new System.Drawing.Size(100, 20);
            this.lblReUsername.TabIndex = 0;
            this.lblReUsername.Text = "Username:";
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePassword.Location = new System.Drawing.Point(117, 252);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(97, 20);
            this.lblRePassword.TabIndex = 1;
            this.lblRePassword.Text = "Password:";
            // 
            // lblReConfirmPassword
            // 
            this.lblReConfirmPassword.AutoSize = true;
            this.lblReConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblReConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReConfirmPassword.Location = new System.Drawing.Point(117, 296);
            this.lblReConfirmPassword.Name = "lblReConfirmPassword";
            this.lblReConfirmPassword.Size = new System.Drawing.Size(169, 20);
            this.lblReConfirmPassword.TabIndex = 2;
            this.lblReConfirmPassword.Text = "Confirm Password:";
            // 
            // lblReEmail
            // 
            this.lblReEmail.AutoSize = true;
            this.lblReEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblReEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEmail.Location = new System.Drawing.Point(117, 206);
            this.lblReEmail.Name = "lblReEmail";
            this.lblReEmail.Size = new System.Drawing.Size(62, 20);
            this.lblReEmail.TabIndex = 3;
            this.lblReEmail.Text = "Email:";
            // 
            // lblReThumnail
            // 
            this.lblReThumnail.AutoSize = true;
            this.lblReThumnail.BackColor = System.Drawing.Color.Transparent;
            this.lblReThumnail.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReThumnail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReThumnail.Location = new System.Drawing.Point(212, 89);
            this.lblReThumnail.Name = "lblReThumnail";
            this.lblReThumnail.Size = new System.Drawing.Size(366, 54);
            this.lblReThumnail.TabIndex = 4;
            this.lblReThumnail.Text = "Đăng ký tài khoản";
            // 
            // textReUsername
            // 
            this.textReUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReUsername.Location = new System.Drawing.Point(300, 162);
            this.textReUsername.Name = "textReUsername";
            this.textReUsername.Size = new System.Drawing.Size(297, 24);
            this.textReUsername.TabIndex = 5;
            this.textReUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textReEmail
            // 
            this.textReEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReEmail.Location = new System.Drawing.Point(300, 206);
            this.textReEmail.Name = "textReEmail";
            this.textReEmail.Size = new System.Drawing.Size(297, 24);
            this.textReEmail.TabIndex = 6;
            this.textReEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textRePassword
            // 
            this.textRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRePassword.Location = new System.Drawing.Point(300, 250);
            this.textRePassword.Name = "textRePassword";
            this.textRePassword.PasswordChar = '*';
            this.textRePassword.Size = new System.Drawing.Size(297, 24);
            this.textRePassword.TabIndex = 7;
            this.textRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textReConfirmPassword
            // 
            this.textReConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReConfirmPassword.Location = new System.Drawing.Point(300, 296);
            this.textReConfirmPassword.Name = "textReConfirmPassword";
            this.textReConfirmPassword.PasswordChar = '*';
            this.textReConfirmPassword.Size = new System.Drawing.Size(297, 24);
            this.textReConfirmPassword.TabIndex = 8;
            this.textReConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRegister.Location = new System.Drawing.Point(647, 195);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(91, 79);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Đăng ký";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textReConfirmPassword);
            this.Controls.Add(this.textRePassword);
            this.Controls.Add(this.textReEmail);
            this.Controls.Add(this.textReUsername);
            this.Controls.Add(this.lblReThumnail);
            this.Controls.Add(this.lblReEmail);
            this.Controls.Add(this.lblReConfirmPassword);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblReUsername);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReUsername;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblReConfirmPassword;
        private System.Windows.Forms.Label lblReEmail;
        private System.Windows.Forms.Label lblReThumnail;
        private System.Windows.Forms.TextBox textReUsername;
        private System.Windows.Forms.TextBox textReEmail;
        private System.Windows.Forms.TextBox textRePassword;
        private System.Windows.Forms.TextBox textReConfirmPassword;
        private System.Windows.Forms.Button buttonRegister;
    }
}