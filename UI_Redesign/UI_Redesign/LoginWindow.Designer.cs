namespace UI_Redesign
{
    partial class LoginWindow
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(68, 179);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 1;
            this.userBox.Text = "Username";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(68, 205);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 2;
            this.passBox.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loginButton.Location = new System.Drawing.Point(81, 231);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // profilePic
            // 
            this.profilePic.BackgroundImage = global::UI_Redesign.Properties.Resources.pic;
            this.profilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePic.Location = new System.Drawing.Point(58, 26);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(120, 147);
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 289);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.profilePic);
            this.Name = "LoginWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button loginButton;
    }
}

