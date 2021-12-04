namespace Store
{
    partial class LoginForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.labelAlertNoUsersInFile = new DarkUI.Controls.DarkLabel();
            this.buttonSignUp = new DarkUI.Controls.DarkButton();
            this.buttonSignIn = new DarkUI.Controls.DarkButton();
            this.labelPassword = new DarkUI.Controls.DarkLabel();
            this.textboxPassword = new DarkUI.Controls.DarkTextBox();
            this.labelLogin = new DarkUI.Controls.DarkLabel();
            this.textboxLogin = new DarkUI.Controls.DarkTextBox();
            this.panelLogin.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.darkSectionPanel1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Padding = new System.Windows.Forms.Padding(10);
            this.panelLogin.Size = new System.Drawing.Size(684, 461);
            this.panelLogin.TabIndex = 0;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.labelAlertNoUsersInFile);
            this.darkSectionPanel1.Controls.Add(this.buttonSignUp);
            this.darkSectionPanel1.Controls.Add(this.buttonSignIn);
            this.darkSectionPanel1.Controls.Add(this.labelPassword);
            this.darkSectionPanel1.Controls.Add(this.textboxPassword);
            this.darkSectionPanel1.Controls.Add(this.labelLogin);
            this.darkSectionPanel1.Controls.Add(this.textboxLogin);
            this.darkSectionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkSectionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel1.Location = new System.Drawing.Point(10, 10);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Login";
            this.darkSectionPanel1.Size = new System.Drawing.Size(664, 441);
            this.darkSectionPanel1.TabIndex = 0;
            // 
            // labelAlertNoUsersInFile
            // 
            this.labelAlertNoUsersInFile.AutoSize = true;
            this.labelAlertNoUsersInFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelAlertNoUsersInFile.Location = new System.Drawing.Point(95, 330);
            this.labelAlertNoUsersInFile.Name = "labelAlertNoUsersInFile";
            this.labelAlertNoUsersInFile.Size = new System.Drawing.Size(479, 24);
            this.labelAlertNoUsersInFile.TabIndex = 6;
            this.labelAlertNoUsersInFile.Text = "There are currently no users, please sign up to continue";
            this.labelAlertNoUsersInFile.Visible = false;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(374, 242);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Padding = new System.Windows.Forms.Padding(5);
            this.buttonSignUp.Size = new System.Drawing.Size(200, 40);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Enabled = false;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(82, 242);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Padding = new System.Windows.Forms.Padding(5);
            this.buttonSignIn.Size = new System.Drawing.Size(200, 40);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelPassword.Location = new System.Drawing.Point(6, 129);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(114, 26);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textboxPassword.Location = new System.Drawing.Point(143, 129);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(197, 32);
            this.textboxPassword.TabIndex = 2;
            this.textboxPassword.UseSystemPasswordChar = true;
            this.textboxPassword.TextChanged += new System.EventHandler(this.textboxPassword_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelLogin.Location = new System.Drawing.Point(4, 69);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(133, 26);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login/Email:";
            // 
            // textboxLogin
            // 
            this.textboxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textboxLogin.Location = new System.Drawing.Point(143, 69);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(197, 32);
            this.textboxLogin.TabIndex = 0;
            this.textboxLogin.TextChanged += new System.EventHandler(this.textboxLogin_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(700, 1000);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "LoginForm";
            this.Text = "Dark Store";
            this.panelLogin.ResumeLayout(false);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkButton buttonSignUp;
        private DarkUI.Controls.DarkButton buttonSignIn;
        private DarkUI.Controls.DarkLabel labelPassword;
        private DarkUI.Controls.DarkTextBox textboxPassword;
        private DarkUI.Controls.DarkLabel labelLogin;
        private DarkUI.Controls.DarkTextBox textboxLogin;
        private DarkUI.Controls.DarkLabel labelAlertNoUsersInFile;
    }
}

