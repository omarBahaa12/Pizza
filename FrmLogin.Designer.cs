namespace Pizza_Order
{
    partial class FrmLogin
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
            this.Lab_UserName = new System.Windows.Forms.Label();
            this.Lab_Password = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lab_LoginScreen = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Lab_UserName
            // 
            this.Lab_UserName.AutoSize = true;
            this.Lab_UserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lab_UserName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_UserName.Location = new System.Drawing.Point(123, 318);
            this.Lab_UserName.Name = "Lab_UserName";
            this.Lab_UserName.Size = new System.Drawing.Size(122, 23);
            this.Lab_UserName.TabIndex = 0;
            this.Lab_UserName.Text = "User Name";
            // 
            // Lab_Password
            // 
            this.Lab_Password.AutoSize = true;
            this.Lab_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lab_Password.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Password.Location = new System.Drawing.Point(123, 385);
            this.Lab_Password.Name = "Lab_Password";
            this.Lab_Password.Size = new System.Drawing.Size(109, 23);
            this.Lab_Password.TabIndex = 1;
            this.Lab_Password.Text = "Password";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserName.Location = new System.Drawing.Point(321, 318);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(288, 27);
            this.Txt_UserName.TabIndex = 2;
            this.Txt_UserName.Tag = "Admin";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(321, 381);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(288, 27);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.Tag = "1234";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(101, 449);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(171, 60);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(438, 449);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(171, 60);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lab_LoginScreen
            // 
            this.Lab_LoginScreen.AutoSize = true;
            this.Lab_LoginScreen.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_LoginScreen.Location = new System.Drawing.Point(250, 28);
            this.Lab_LoginScreen.Name = "Lab_LoginScreen";
            this.Lab_LoginScreen.Size = new System.Drawing.Size(124, 53);
            this.Lab_LoginScreen.TabIndex = 6;
            this.Lab_LoginScreen.Text = "Login";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(347, 90);
            this.monthCalendar1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 569);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Lab_LoginScreen);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lab_Password);
            this.Controls.Add(this.Lab_UserName);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_UserName;
        private System.Windows.Forms.Label Lab_Password;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lab_LoginScreen;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

