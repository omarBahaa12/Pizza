namespace Pizza_Order
{
    partial class FrmTimer1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Lab_Timer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Btn_OrderFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Lab_Timer
            // 
            this.Lab_Timer.AutoSize = true;
            this.Lab_Timer.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Timer.ForeColor = System.Drawing.Color.Red;
            this.Lab_Timer.Location = new System.Drawing.Point(81, 130);
            this.Lab_Timer.Name = "Lab_Timer";
            this.Lab_Timer.Size = new System.Drawing.Size(0, 60);
            this.Lab_Timer.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Btn_OrderFinished
            // 
            this.Btn_OrderFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OrderFinished.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderFinished.Location = new System.Drawing.Point(80, 234);
            this.Btn_OrderFinished.Name = "Btn_OrderFinished";
            this.Btn_OrderFinished.Size = new System.Drawing.Size(188, 57);
            this.Btn_OrderFinished.TabIndex = 1;
            this.Btn_OrderFinished.Text = "Order Finished";
            this.Btn_OrderFinished.UseVisualStyleBackColor = true;
            this.Btn_OrderFinished.Click += new System.EventHandler(this.Btn_OrderFinished_Click);
            // 
            // FrmTimer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.Controls.Add(this.Btn_OrderFinished);
            this.Controls.Add(this.Lab_Timer);
            this.Name = "FrmTimer1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Lab_Timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Btn_OrderFinished;
    }
}