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
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelWarningLoginField = new System.Windows.Forms.Label();
            this.labelWarningPasswordField = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(85, 293);
            this.loginField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(265, 22);
            this.loginField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(85, 388);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(265, 22);
            this.passwordField.TabIndex = 1;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(143, 489);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(160, 49);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelLogin.Location = new System.Drawing.Point(180, 258);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(75, 29);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelPassword.Location = new System.Drawing.Point(153, 353);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(124, 29);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(143, 606);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 49);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // labelWarningLoginField
            // 
            this.labelWarningLoginField.AutoSize = true;
            this.labelWarningLoginField.ForeColor = System.Drawing.Color.Red;
            this.labelWarningLoginField.Location = new System.Drawing.Point(129, 321);
            this.labelWarningLoginField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarningLoginField.Name = "labelWarningLoginField";
            this.labelWarningLoginField.Size = new System.Drawing.Size(161, 16);
            this.labelWarningLoginField.TabIndex = 6;
            this.labelWarningLoginField.Text = "The field cannot be empty";
            this.labelWarningLoginField.Visible = false;
            // 
            // labelWarningPasswordField
            // 
            this.labelWarningPasswordField.AutoSize = true;
            this.labelWarningPasswordField.ForeColor = System.Drawing.Color.Red;
            this.labelWarningPasswordField.Location = new System.Drawing.Point(129, 416);
            this.labelWarningPasswordField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarningPasswordField.Name = "labelWarningPasswordField";
            this.labelWarningPasswordField.Size = new System.Drawing.Size(161, 16);
            this.labelWarningPasswordField.TabIndex = 7;
            this.labelWarningPasswordField.Text = "The field cannot be empty";
            this.labelWarningPasswordField.Visible = false;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(143, 549);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(160, 49);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // loginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 690);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.labelWarningPasswordField);
            this.Controls.Add(this.labelWarningLoginField);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelWarningLoginField;
        private System.Windows.Forms.Label labelWarningPasswordField;
        private System.Windows.Forms.Button signUpButton;
    }
}