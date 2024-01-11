namespace dataBase
{
    partial class loginWindow
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
            this.LoginFieldLP = new System.Windows.Forms.TextBox();
            this.PasswordFieldLP = new System.Windows.Forms.TextBox();
            this.SignInButtonLP = new System.Windows.Forms.Button();
            this.LabelLoginLP = new System.Windows.Forms.Label();
            this.LabelPasswordLP = new System.Windows.Forms.Label();
            this.ExitButtonLP = new System.Windows.Forms.Button();
            this.LabelWarningLoginFieldLP = new System.Windows.Forms.Label();
            this.LabelWarningPasswordFieldLP = new System.Windows.Forms.Label();
            this.SignUpButtonLP = new System.Windows.Forms.Button();
            this.RegisterUserPanel = new System.Windows.Forms.Panel();
            this.BackButtonRP = new System.Windows.Forms.Button();
            this.ExitButtonRP = new System.Windows.Forms.Button();
            this.SignUpButtonRP = new System.Windows.Forms.Button();
            this.LabelWarningConfirmPasswordFieldRP = new System.Windows.Forms.Label();
            this.LabelWarningPasswordFieldRP = new System.Windows.Forms.Label();
            this.LabelWarningLoginFieldRP = new System.Windows.Forms.Label();
            this.LabelConfirmPasswordRP = new System.Windows.Forms.Label();
            this.LabelLoginRP = new System.Windows.Forms.Label();
            this.LabelPasswordRP = new System.Windows.Forms.Label();
            this.ConfirmPasswordFieldRP = new System.Windows.Forms.TextBox();
            this.PasswordFieldRP = new System.Windows.Forms.TextBox();
            this.LoginFieldRP = new System.Windows.Forms.TextBox();
            this.LoginUserPanel = new System.Windows.Forms.Panel();
            this.RegisterUserPanel.SuspendLayout();
            this.LoginUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginFieldLP
            // 
            this.LoginFieldLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginFieldLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginFieldLP.Location = new System.Drawing.Point(67, 232);
            this.LoginFieldLP.Name = "LoginFieldLP";
            this.LoginFieldLP.Size = new System.Drawing.Size(200, 20);
            this.LoginFieldLP.TabIndex = 0;
            // 
            // PasswordFieldLP
            // 
            this.PasswordFieldLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordFieldLP.Location = new System.Drawing.Point(67, 331);
            this.PasswordFieldLP.Name = "PasswordFieldLP";
            this.PasswordFieldLP.Size = new System.Drawing.Size(200, 20);
            this.PasswordFieldLP.TabIndex = 1;
            this.PasswordFieldLP.UseSystemPasswordChar = true;
            // 
            // SignInButtonLP
            // 
            this.SignInButtonLP.Location = new System.Drawing.Point(109, 396);
            this.SignInButtonLP.Name = "SignInButtonLP";
            this.SignInButtonLP.Size = new System.Drawing.Size(125, 40);
            this.SignInButtonLP.TabIndex = 2;
            this.SignInButtonLP.Text = "Sign in";
            this.SignInButtonLP.UseVisualStyleBackColor = true;
            this.SignInButtonLP.Click += new System.EventHandler(this.SignInButtonLP_Click);
            // 
            // LabelLoginLP
            // 
            this.LabelLoginLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLoginLP.AutoSize = true;
            this.LabelLoginLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginLP.Location = new System.Drawing.Point(136, 204);
            this.LabelLoginLP.Name = "LabelLoginLP";
            this.LabelLoginLP.Size = new System.Drawing.Size(60, 25);
            this.LabelLoginLP.TabIndex = 3;
            this.LabelLoginLP.Text = "Login";
            this.LabelLoginLP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPasswordLP
            // 
            this.LabelPasswordLP.AutoSize = true;
            this.LabelPasswordLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelPasswordLP.Location = new System.Drawing.Point(120, 303);
            this.LabelPasswordLP.Name = "LabelPasswordLP";
            this.LabelPasswordLP.Size = new System.Drawing.Size(98, 25);
            this.LabelPasswordLP.TabIndex = 4;
            this.LabelPasswordLP.Text = "Password";
            // 
            // ExitButtonLP
            // 
            this.ExitButtonLP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButtonLP.Location = new System.Drawing.Point(109, 488);
            this.ExitButtonLP.Name = "ExitButtonLP";
            this.ExitButtonLP.Size = new System.Drawing.Size(125, 40);
            this.ExitButtonLP.TabIndex = 5;
            this.ExitButtonLP.Text = "Exit";
            this.ExitButtonLP.UseVisualStyleBackColor = true;
            // 
            // LabelWarningLoginFieldLP
            // 
            this.LabelWarningLoginFieldLP.ForeColor = System.Drawing.Color.Red;
            this.LabelWarningLoginFieldLP.Location = new System.Drawing.Point(106, 255);
            this.LabelWarningLoginFieldLP.Name = "LabelWarningLoginFieldLP";
            this.LabelWarningLoginFieldLP.Size = new System.Drawing.Size(130, 13);
            this.LabelWarningLoginFieldLP.TabIndex = 6;
            this.LabelWarningLoginFieldLP.Text = "The field cannot be empty";
            this.LabelWarningLoginFieldLP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWarningLoginFieldLP.Visible = false;
            // 
            // LabelWarningPasswordFieldLP
            // 
            this.LabelWarningPasswordFieldLP.ForeColor = System.Drawing.Color.Red;
            this.LabelWarningPasswordFieldLP.Location = new System.Drawing.Point(106, 354);
            this.LabelWarningPasswordFieldLP.Name = "LabelWarningPasswordFieldLP";
            this.LabelWarningPasswordFieldLP.Size = new System.Drawing.Size(130, 13);
            this.LabelWarningPasswordFieldLP.TabIndex = 7;
            this.LabelWarningPasswordFieldLP.Text = "The field cannot be empty";
            this.LabelWarningPasswordFieldLP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWarningPasswordFieldLP.Visible = false;
            // 
            // SignUpButtonLP
            // 
            this.SignUpButtonLP.Location = new System.Drawing.Point(109, 442);
            this.SignUpButtonLP.Name = "SignUpButtonLP";
            this.SignUpButtonLP.Size = new System.Drawing.Size(125, 40);
            this.SignUpButtonLP.TabIndex = 8;
            this.SignUpButtonLP.Text = "Sign up";
            this.SignUpButtonLP.UseVisualStyleBackColor = true;
            this.SignUpButtonLP.Click += new System.EventHandler(this.SignUpButtonLP_Click);
            // 
            // RegisterUserPanel
            // 
            this.RegisterUserPanel.AutoSize = true;
            this.RegisterUserPanel.Controls.Add(this.BackButtonRP);
            this.RegisterUserPanel.Controls.Add(this.ExitButtonRP);
            this.RegisterUserPanel.Controls.Add(this.SignUpButtonRP);
            this.RegisterUserPanel.Controls.Add(this.LabelWarningConfirmPasswordFieldRP);
            this.RegisterUserPanel.Controls.Add(this.LabelWarningPasswordFieldRP);
            this.RegisterUserPanel.Controls.Add(this.LabelWarningLoginFieldRP);
            this.RegisterUserPanel.Controls.Add(this.LabelConfirmPasswordRP);
            this.RegisterUserPanel.Controls.Add(this.LabelLoginRP);
            this.RegisterUserPanel.Controls.Add(this.LabelPasswordRP);
            this.RegisterUserPanel.Controls.Add(this.ConfirmPasswordFieldRP);
            this.RegisterUserPanel.Controls.Add(this.PasswordFieldRP);
            this.RegisterUserPanel.Controls.Add(this.LoginFieldRP);
            this.RegisterUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterUserPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterUserPanel.Name = "RegisterUserPanel";
            this.RegisterUserPanel.Size = new System.Drawing.Size(334, 561);
            this.RegisterUserPanel.TabIndex = 9;
            this.RegisterUserPanel.Visible = false;
            // 
            // BackButtonRP
            // 
            this.BackButtonRP.Location = new System.Drawing.Point(109, 442);
            this.BackButtonRP.Name = "BackButtonRP";
            this.BackButtonRP.Size = new System.Drawing.Size(125, 40);
            this.BackButtonRP.TabIndex = 13;
            this.BackButtonRP.Text = "Back";
            this.BackButtonRP.UseVisualStyleBackColor = true;
            this.BackButtonRP.Click += new System.EventHandler(this.BackButtonRP_Click);
            // 
            // ExitButtonRP
            // 
            this.ExitButtonRP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButtonRP.Location = new System.Drawing.Point(109, 488);
            this.ExitButtonRP.Name = "ExitButtonRP";
            this.ExitButtonRP.Size = new System.Drawing.Size(125, 40);
            this.ExitButtonRP.TabIndex = 12;
            this.ExitButtonRP.Text = "Exit";
            this.ExitButtonRP.UseVisualStyleBackColor = true;
            // 
            // SignUpButtonRP
            // 
            this.SignUpButtonRP.Location = new System.Drawing.Point(109, 396);
            this.SignUpButtonRP.Name = "SignUpButtonRP";
            this.SignUpButtonRP.Size = new System.Drawing.Size(125, 40);
            this.SignUpButtonRP.TabIndex = 11;
            this.SignUpButtonRP.Text = "Sign up";
            this.SignUpButtonRP.UseVisualStyleBackColor = true;
            this.SignUpButtonRP.Click += new System.EventHandler(this.SignUpButtonRP_Click);
            // 
            // LabelWarningConfirmPasswordFieldRP
            // 
            this.LabelWarningConfirmPasswordFieldRP.ForeColor = System.Drawing.Color.Red;
            this.LabelWarningConfirmPasswordFieldRP.Location = new System.Drawing.Point(106, 354);
            this.LabelWarningConfirmPasswordFieldRP.Name = "LabelWarningConfirmPasswordFieldRP";
            this.LabelWarningConfirmPasswordFieldRP.Size = new System.Drawing.Size(130, 13);
            this.LabelWarningConfirmPasswordFieldRP.TabIndex = 9;
            this.LabelWarningConfirmPasswordFieldRP.Text = "The field cannot be empty";
            this.LabelWarningConfirmPasswordFieldRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWarningConfirmPasswordFieldRP.Visible = false;
            // 
            // LabelWarningPasswordFieldRP
            // 
            this.LabelWarningPasswordFieldRP.ForeColor = System.Drawing.Color.Red;
            this.LabelWarningPasswordFieldRP.Location = new System.Drawing.Point(106, 255);
            this.LabelWarningPasswordFieldRP.Name = "LabelWarningPasswordFieldRP";
            this.LabelWarningPasswordFieldRP.Size = new System.Drawing.Size(130, 13);
            this.LabelWarningPasswordFieldRP.TabIndex = 8;
            this.LabelWarningPasswordFieldRP.Text = "The field cannot be empty";
            this.LabelWarningPasswordFieldRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWarningPasswordFieldRP.Visible = false;
            // 
            // LabelWarningLoginFieldRP
            // 
            this.LabelWarningLoginFieldRP.ForeColor = System.Drawing.Color.Red;
            this.LabelWarningLoginFieldRP.Location = new System.Drawing.Point(106, 156);
            this.LabelWarningLoginFieldRP.Name = "LabelWarningLoginFieldRP";
            this.LabelWarningLoginFieldRP.Size = new System.Drawing.Size(130, 13);
            this.LabelWarningLoginFieldRP.TabIndex = 7;
            this.LabelWarningLoginFieldRP.Text = "The field cannot be empty";
            this.LabelWarningLoginFieldRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWarningLoginFieldRP.Visible = false;
            // 
            // LabelConfirmPasswordRP
            // 
            this.LabelConfirmPasswordRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConfirmPasswordRP.AutoSize = true;
            this.LabelConfirmPasswordRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelConfirmPasswordRP.Location = new System.Drawing.Point(86, 303);
            this.LabelConfirmPasswordRP.Name = "LabelConfirmPasswordRP";
            this.LabelConfirmPasswordRP.Size = new System.Drawing.Size(171, 25);
            this.LabelConfirmPasswordRP.TabIndex = 6;
            this.LabelConfirmPasswordRP.Text = "Confirm Password";
            this.LabelConfirmPasswordRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLoginRP
            // 
            this.LabelLoginRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLoginRP.AutoSize = true;
            this.LabelLoginRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelLoginRP.Location = new System.Drawing.Point(140, 105);
            this.LabelLoginRP.Name = "LabelLoginRP";
            this.LabelLoginRP.Size = new System.Drawing.Size(60, 25);
            this.LabelLoginRP.TabIndex = 5;
            this.LabelLoginRP.Text = "Login";
            this.LabelLoginRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPasswordRP
            // 
            this.LabelPasswordRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPasswordRP.AutoSize = true;
            this.LabelPasswordRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelPasswordRP.Location = new System.Drawing.Point(123, 204);
            this.LabelPasswordRP.Name = "LabelPasswordRP";
            this.LabelPasswordRP.Size = new System.Drawing.Size(98, 25);
            this.LabelPasswordRP.TabIndex = 4;
            this.LabelPasswordRP.Text = "Password";
            this.LabelPasswordRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmPasswordFieldRP
            // 
            this.ConfirmPasswordFieldRP.Location = new System.Drawing.Point(67, 331);
            this.ConfirmPasswordFieldRP.Name = "ConfirmPasswordFieldRP";
            this.ConfirmPasswordFieldRP.Size = new System.Drawing.Size(200, 20);
            this.ConfirmPasswordFieldRP.TabIndex = 3;
            // 
            // PasswordFieldRP
            // 
            this.PasswordFieldRP.Location = new System.Drawing.Point(67, 232);
            this.PasswordFieldRP.Name = "PasswordFieldRP";
            this.PasswordFieldRP.Size = new System.Drawing.Size(200, 20);
            this.PasswordFieldRP.TabIndex = 2;
            // 
            // LoginFieldRP
            // 
            this.LoginFieldRP.Location = new System.Drawing.Point(67, 133);
            this.LoginFieldRP.Name = "LoginFieldRP";
            this.LoginFieldRP.Size = new System.Drawing.Size(200, 20);
            this.LoginFieldRP.TabIndex = 1;
            // 
            // LoginUserPanel
            // 
            this.LoginUserPanel.AutoSize = true;
            this.LoginUserPanel.Controls.Add(this.LoginFieldLP);
            this.LoginUserPanel.Controls.Add(this.LabelLoginLP);
            this.LoginUserPanel.Controls.Add(this.ExitButtonLP);
            this.LoginUserPanel.Controls.Add(this.SignUpButtonLP);
            this.LoginUserPanel.Controls.Add(this.LabelWarningLoginFieldLP);
            this.LoginUserPanel.Controls.Add(this.SignInButtonLP);
            this.LoginUserPanel.Controls.Add(this.LabelPasswordLP);
            this.LoginUserPanel.Controls.Add(this.LabelWarningPasswordFieldLP);
            this.LoginUserPanel.Controls.Add(this.PasswordFieldLP);
            this.LoginUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginUserPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUserPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginUserPanel.Name = "LoginUserPanel";
            this.LoginUserPanel.Size = new System.Drawing.Size(334, 561);
            this.LoginUserPanel.TabIndex = 10;
            // 
            // loginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.RegisterUserPanel);
            this.Controls.Add(this.LoginUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.RegisterUserPanel.ResumeLayout(false);
            this.RegisterUserPanel.PerformLayout();
            this.LoginUserPanel.ResumeLayout(false);
            this.LoginUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignInButtonLP;
        private System.Windows.Forms.Label LabelLoginLP;
        private System.Windows.Forms.Label LabelPasswordLP;
        private System.Windows.Forms.TextBox LoginFieldLP;
        private System.Windows.Forms.TextBox PasswordFieldLP;
        private System.Windows.Forms.Button ExitButtonLP;
        private System.Windows.Forms.Label LabelWarningLoginFieldLP;
        private System.Windows.Forms.Label LabelWarningPasswordFieldLP;
        private System.Windows.Forms.Button SignUpButtonLP;
        private System.Windows.Forms.Panel RegisterUserPanel;
        private System.Windows.Forms.Label LabelConfirmPasswordRP;
        private System.Windows.Forms.Label LabelLoginRP;
        private System.Windows.Forms.Label LabelPasswordRP;
        private System.Windows.Forms.TextBox ConfirmPasswordFieldRP;
        private System.Windows.Forms.TextBox PasswordFieldRP;
        private System.Windows.Forms.TextBox LoginFieldRP;
        private System.Windows.Forms.Panel LoginUserPanel;
        private System.Windows.Forms.Button ExitButtonRP;
        private System.Windows.Forms.Button SignUpButtonRP;
        private System.Windows.Forms.Label LabelWarningConfirmPasswordFieldRP;
        private System.Windows.Forms.Label LabelWarningPasswordFieldRP;
        private System.Windows.Forms.Label LabelWarningLoginFieldRP;
        private System.Windows.Forms.Button BackButtonRP;
    }
}