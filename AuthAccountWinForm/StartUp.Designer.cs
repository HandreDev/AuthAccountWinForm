
namespace AuthAccountWinForm
{
    partial class StartUp
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
            this.components = new System.ComponentModel.Container();
            this.tabLoginAndRegister = new System.Windows.Forms.TabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.lblSurnameException = new System.Windows.Forms.Label();
            this.lblNameException = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmailException = new System.Windows.Forms.Label();
            this.lblPasswordException = new System.Windows.Forms.Label();
            this.lblConfirmPasswordException = new System.Windows.Forms.Label();
            this.lblLoginPasswordException = new System.Windows.Forms.Label();
            this.lblLoginEmailException = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabLoginAndRegister.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLoginAndRegister
            // 
            this.tabLoginAndRegister.Controls.Add(this.tpLogin);
            this.tabLoginAndRegister.Controls.Add(this.tpRegister);
            this.tabLoginAndRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLoginAndRegister.Location = new System.Drawing.Point(0, 0);
            this.tabLoginAndRegister.Multiline = true;
            this.tabLoginAndRegister.Name = "tabLoginAndRegister";
            this.tabLoginAndRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabLoginAndRegister.SelectedIndex = 0;
            this.tabLoginAndRegister.Size = new System.Drawing.Size(588, 273);
            this.tabLoginAndRegister.TabIndex = 0;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.lblLoginEmailException);
            this.tpLogin.Controls.Add(this.lblLoginPasswordException);
            this.tpLogin.Controls.Add(this.label7);
            this.tpLogin.Controls.Add(this.label6);
            this.tpLogin.Controls.Add(this.txtLoginEmail);
            this.tpLogin.Controls.Add(this.txtLoginPassword);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(580, 247);
            this.tpLogin.TabIndex = 0;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.txtLoginEmail.Location = new System.Drawing.Point(137, 75);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(143, 20);
            this.txtLoginEmail.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(137, 101);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(143, 20);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(137, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tpRegister
            // 
            this.tpRegister.Controls.Add(this.lblConfirmPasswordException);
            this.tpRegister.Controls.Add(this.lblPasswordException);
            this.tpRegister.Controls.Add(this.lblEmailException);
            this.tpRegister.Controls.Add(this.lblSurnameException);
            this.tpRegister.Controls.Add(this.lblNameException);
            this.tpRegister.Controls.Add(this.label8);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Controls.Add(this.label5);
            this.tpRegister.Controls.Add(this.label4);
            this.tpRegister.Controls.Add(this.label3);
            this.tpRegister.Controls.Add(this.label2);
            this.tpRegister.Controls.Add(this.label1);
            this.tpRegister.Controls.Add(this.dtpDOB);
            this.tpRegister.Controls.Add(this.txtConfirmPassword);
            this.tpRegister.Controls.Add(this.txtPassword);
            this.tpRegister.Controls.Add(this.txtEmail);
            this.tpRegister.Controls.Add(this.txtSurname);
            this.tpRegister.Controls.Add(this.txtName);
            this.tpRegister.Location = new System.Drawing.Point(4, 22);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(365, 232);
            this.tpRegister.TabIndex = 1;
            this.tpRegister.Text = "Register";
            this.tpRegister.UseVisualStyleBackColor = true;
            // 
            // lblSurnameException
            // 
            this.lblSurnameException.AutoSize = true;
            this.lblSurnameException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSurnameException.Location = new System.Drawing.Point(320, 61);
            this.lblSurnameException.Name = "lblSurnameException";
            this.lblSurnameException.Size = new System.Drawing.Size(0, 13);
            this.lblSurnameException.TabIndex = 14;
            // 
            // lblNameException
            // 
            this.lblNameException.AutoSize = true;
            this.lblNameException.BackColor = System.Drawing.Color.Transparent;
            this.lblNameException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNameException.Location = new System.Drawing.Point(320, 34);
            this.lblNameException.Name = "lblNameException";
            this.lblNameException.Size = new System.Drawing.Size(0, 13);
            this.lblNameException.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(114, 188);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(114, 84);
            this.dtpDOB.MaxDate = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(114, 162);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.TextChangedConfirmPassword);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.TextChangedPassword);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.TextChangedEmail);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 58);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.TextChangedSurname);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.TextChangedName);
            // 
            // lblEmailException
            // 
            this.lblEmailException.AutoSize = true;
            this.lblEmailException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailException.Location = new System.Drawing.Point(320, 113);
            this.lblEmailException.Name = "lblEmailException";
            this.lblEmailException.Size = new System.Drawing.Size(0, 13);
            this.lblEmailException.TabIndex = 15;
            // 
            // lblPasswordException
            // 
            this.lblPasswordException.AutoSize = true;
            this.lblPasswordException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasswordException.Location = new System.Drawing.Point(320, 139);
            this.lblPasswordException.Name = "lblPasswordException";
            this.lblPasswordException.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordException.TabIndex = 16;
            // 
            // lblConfirmPasswordException
            // 
            this.lblConfirmPasswordException.AutoSize = true;
            this.lblConfirmPasswordException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblConfirmPasswordException.Location = new System.Drawing.Point(320, 165);
            this.lblConfirmPasswordException.Name = "lblConfirmPasswordException";
            this.lblConfirmPasswordException.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmPasswordException.TabIndex = 17;
            // 
            // lblLoginPasswordException
            // 
            this.lblLoginPasswordException.AutoSize = true;
            this.lblLoginPasswordException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLoginPasswordException.Location = new System.Drawing.Point(286, 104);
            this.lblLoginPasswordException.Name = "lblLoginPasswordException";
            this.lblLoginPasswordException.Size = new System.Drawing.Size(0, 13);
            this.lblLoginPasswordException.TabIndex = 9;
            // 
            // lblLoginEmailException
            // 
            this.lblLoginEmailException.AutoSize = true;
            this.lblLoginEmailException.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLoginEmailException.Location = new System.Drawing.Point(286, 78);
            this.lblLoginEmailException.Name = "lblLoginEmailException";
            this.lblLoginEmailException.Size = new System.Drawing.Size(0, 13);
            this.lblLoginEmailException.TabIndex = 10;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AuthAccountWinForm.App_code.User);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(588, 273);
            this.Controls.Add(this.tabLoginAndRegister);
            this.Name = "StartUp";
            this.Text = "Form2";
            this.tabLoginAndRegister.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLoginAndRegister;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameException;
        private System.Windows.Forms.Label lblSurnameException;
        private System.Windows.Forms.Label lblConfirmPasswordException;
        private System.Windows.Forms.Label lblPasswordException;
        private System.Windows.Forms.Label lblEmailException;
        private System.Windows.Forms.Label lblLoginPasswordException;
        private System.Windows.Forms.Label lblLoginEmailException;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}