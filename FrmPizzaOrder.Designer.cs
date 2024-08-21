namespace Pizza_Order
{
    partial class FrmPizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaOrder));
            this.Comb_Size = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Lab_MainLabel = new System.Windows.Forms.Label();
            this.Lab_Size = new System.Windows.Forms.Label();
            this.Lab_WhichSize = new System.Windows.Forms.Label();
            this.Lab_Toppings = new System.Windows.Forms.Label();
            this.Lab_WhichToppings = new System.Windows.Forms.Label();
            this.Lab_CrustType = new System.Windows.Forms.Label();
            this.Lab_WhichCrust = new System.Windows.Forms.Label();
            this.Lab_Eat = new System.Windows.Forms.Label();
            this.Lab_WhichEat = new System.Windows.Forms.Label();
            this.Lab_Price = new System.Windows.Forms.Label();
            this.Lab_WhichPrice = new System.Windows.Forms.Label();
            this.Btn_OrderPizza = new System.Windows.Forms.Button();
            this.Btn_ResetForm = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pan_Size = new System.Windows.Forms.Panel();
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rdb_Think = new System.Windows.Forms.RadioButton();
            this.Rdb_Thin = new System.Windows.Forms.RadioButton();
            this.Lab_Place = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab_ToopingsPanel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pan_Toppings = new System.Windows.Forms.Panel();
            this.Ckb_Green = new System.Windows.Forms.CheckBox();
            this.Ckb_ExtraCheese = new System.Windows.Forms.CheckBox();
            this.Ckb_Tematoes = new System.Windows.Forms.CheckBox();
            this.Ckb_Onion = new System.Windows.Forms.CheckBox();
            this.Ckb_Mushrooms = new System.Windows.Forms.CheckBox();
            this.Ckb_Olives = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rdb_EatIn = new System.Windows.Forms.RadioButton();
            this.Rdb_TakeAway = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pan_Summary = new System.Windows.Forms.Panel();
            this.Lab_Summary = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Pan_Size.SuspendLayout();
            this.Pan_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pan_Toppings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Pan_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Comb_Size
            // 
            this.Comb_Size.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Comb_Size.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comb_Size.FormattingEnabled = true;
            this.Comb_Size.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Comb_Size.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.Comb_Size.Location = new System.Drawing.Point(3, 35);
            this.Comb_Size.Name = "Comb_Size";
            this.Comb_Size.Size = new System.Drawing.Size(143, 24);
            this.Comb_Size.TabIndex = 4;
            this.Comb_Size.SelectedIndexChanged += new System.EventHandler(this.Comb_Size_SelectedIndexChanged);
            // 
            // Lab_MainLabel
            // 
            this.Lab_MainLabel.AutoSize = true;
            this.Lab_MainLabel.BackColor = System.Drawing.Color.Orange;
            this.Lab_MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lab_MainLabel.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_MainLabel.ForeColor = System.Drawing.Color.Red;
            this.Lab_MainLabel.Location = new System.Drawing.Point(417, 0);
            this.Lab_MainLabel.Name = "Lab_MainLabel";
            this.Lab_MainLabel.Size = new System.Drawing.Size(572, 74);
            this.Lab_MainLabel.TabIndex = 1;
            this.Lab_MainLabel.Text = "Make Your Pizza";
            // 
            // Lab_Size
            // 
            this.Lab_Size.AutoSize = true;
            this.Lab_Size.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Size.ForeColor = System.Drawing.Color.Snow;
            this.Lab_Size.Location = new System.Drawing.Point(92, 48);
            this.Lab_Size.Name = "Lab_Size";
            this.Lab_Size.Size = new System.Drawing.Size(54, 24);
            this.Lab_Size.TabIndex = 2;
            this.Lab_Size.Text = "Size :";
            // 
            // Lab_WhichSize
            // 
            this.Lab_WhichSize.AutoSize = true;
            this.Lab_WhichSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_WhichSize.ForeColor = System.Drawing.Color.Snow;
            this.Lab_WhichSize.Location = new System.Drawing.Point(183, 48);
            this.Lab_WhichSize.Name = "Lab_WhichSize";
            this.Lab_WhichSize.Size = new System.Drawing.Size(0, 24);
            this.Lab_WhichSize.TabIndex = 3;
            this.Lab_WhichSize.TextChanged += new System.EventHandler(this.Lab_WhichSize_TextChanged);
            // 
            // Lab_Toppings
            // 
            this.Lab_Toppings.AutoSize = true;
            this.Lab_Toppings.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Toppings.ForeColor = System.Drawing.Color.Snow;
            this.Lab_Toppings.Location = new System.Drawing.Point(76, 90);
            this.Lab_Toppings.Name = "Lab_Toppings";
            this.Lab_Toppings.Size = new System.Drawing.Size(99, 24);
            this.Lab_Toppings.TabIndex = 4;
            this.Lab_Toppings.Text = "Toppings :";
            // 
            // Lab_WhichToppings
            // 
            this.Lab_WhichToppings.AutoSize = true;
            this.Lab_WhichToppings.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_WhichToppings.ForeColor = System.Drawing.Color.Snow;
            this.Lab_WhichToppings.Location = new System.Drawing.Point(64, 128);
            this.Lab_WhichToppings.Margin = new System.Windows.Forms.Padding(40);
            this.Lab_WhichToppings.MaximumSize = new System.Drawing.Size(400, 200);
            this.Lab_WhichToppings.MinimumSize = new System.Drawing.Size(90, 90);
            this.Lab_WhichToppings.Name = "Lab_WhichToppings";
            this.Lab_WhichToppings.Size = new System.Drawing.Size(119, 90);
            this.Lab_WhichToppings.TabIndex = 5;
            this.Lab_WhichToppings.Text = "No Toppings";
            this.Lab_WhichToppings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lab_WhichToppings.TextChanged += new System.EventHandler(this.Lab_WhichToppings_TextChanged);
            // 
            // Lab_CrustType
            // 
            this.Lab_CrustType.AutoSize = true;
            this.Lab_CrustType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_CrustType.ForeColor = System.Drawing.Color.Snow;
            this.Lab_CrustType.Location = new System.Drawing.Point(64, 226);
            this.Lab_CrustType.Name = "Lab_CrustType";
            this.Lab_CrustType.Size = new System.Drawing.Size(111, 24);
            this.Lab_CrustType.TabIndex = 6;
            this.Lab_CrustType.Text = "Crust Type :";
            // 
            // Lab_WhichCrust
            // 
            this.Lab_WhichCrust.AutoSize = true;
            this.Lab_WhichCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_WhichCrust.ForeColor = System.Drawing.Color.Snow;
            this.Lab_WhichCrust.Location = new System.Drawing.Point(228, 230);
            this.Lab_WhichCrust.Name = "Lab_WhichCrust";
            this.Lab_WhichCrust.Size = new System.Drawing.Size(0, 29);
            this.Lab_WhichCrust.TabIndex = 7;
            this.Lab_WhichCrust.TextChanged += new System.EventHandler(this.Lab_WhichCrust_TextChanged);
            // 
            // Lab_Eat
            // 
            this.Lab_Eat.AutoSize = true;
            this.Lab_Eat.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Eat.ForeColor = System.Drawing.Color.Snow;
            this.Lab_Eat.Location = new System.Drawing.Point(51, 276);
            this.Lab_Eat.Name = "Lab_Eat";
            this.Lab_Eat.Size = new System.Drawing.Size(135, 24);
            this.Lab_Eat.TabIndex = 8;
            this.Lab_Eat.Text = "Where To Eat :";
            // 
            // Lab_WhichEat
            // 
            this.Lab_WhichEat.AutoSize = true;
            this.Lab_WhichEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_WhichEat.ForeColor = System.Drawing.Color.Snow;
            this.Lab_WhichEat.Location = new System.Drawing.Point(217, 276);
            this.Lab_WhichEat.Name = "Lab_WhichEat";
            this.Lab_WhichEat.Size = new System.Drawing.Size(0, 29);
            this.Lab_WhichEat.TabIndex = 9;
            this.Lab_WhichEat.TextChanged += new System.EventHandler(this.Lab_WhichEat_TextChanged);
            // 
            // Lab_Price
            // 
            this.Lab_Price.AutoSize = true;
            this.Lab_Price.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Price.ForeColor = System.Drawing.Color.White;
            this.Lab_Price.Location = new System.Drawing.Point(1022, 551);
            this.Lab_Price.Name = "Lab_Price";
            this.Lab_Price.Size = new System.Drawing.Size(158, 50);
            this.Lab_Price.TabIndex = 10;
            this.Lab_Price.Text = "Price :";
            this.Lab_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_WhichPrice
            // 
            this.Lab_WhichPrice.AutoSize = true;
            this.Lab_WhichPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_WhichPrice.ForeColor = System.Drawing.Color.White;
            this.Lab_WhichPrice.Location = new System.Drawing.Point(1186, 561);
            this.Lab_WhichPrice.Name = "Lab_WhichPrice";
            this.Lab_WhichPrice.Size = new System.Drawing.Size(55, 40);
            this.Lab_WhichPrice.TabIndex = 11;
            this.Lab_WhichPrice.Text = "0$";
            this.Lab_WhichPrice.TextChanged += new System.EventHandler(this.Lab_WhichPrice_TextChanged);
            // 
            // Btn_OrderPizza
            // 
            this.Btn_OrderPizza.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_OrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.Btn_OrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_OrderPizza.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderPizza.Location = new System.Drawing.Point(459, 621);
            this.Btn_OrderPizza.Name = "Btn_OrderPizza";
            this.Btn_OrderPizza.Size = new System.Drawing.Size(207, 44);
            this.Btn_OrderPizza.TabIndex = 12;
            this.Btn_OrderPizza.Text = "Order Pizza";
            this.Btn_OrderPizza.UseVisualStyleBackColor = false;
            this.Btn_OrderPizza.Click += new System.EventHandler(this.Btn_OrderPizza_Click);
            // 
            // Btn_ResetForm
            // 
            this.Btn_ResetForm.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_ResetForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.Btn_ResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ResetForm.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetForm.Location = new System.Drawing.Point(796, 621);
            this.Btn_ResetForm.Name = "Btn_ResetForm";
            this.Btn_ResetForm.Size = new System.Drawing.Size(207, 44);
            this.Btn_ResetForm.TabIndex = 13;
            this.Btn_ResetForm.Text = "Reset Form";
            this.Btn_ResetForm.UseVisualStyleBackColor = false;
            this.Btn_ResetForm.Click += new System.EventHandler(this.Btn_ResetForm_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Green Pepper.jpeg");
            this.imageList1.Images.SetKeyName(1, "Cheese.jpeg");
            this.imageList1.Images.SetKeyName(2, "Onion.jpeg");
            this.imageList1.Images.SetKeyName(3, "Mushroom.jpeg");
            this.imageList1.Images.SetKeyName(4, "Olives.jpeg");
            this.imageList1.Images.SetKeyName(5, "Tematoes.jpeg");
            this.imageList1.Images.SetKeyName(6, "Provolone.jpg");
            this.imageList1.Images.SetKeyName(7, "mozzarella.jpg");
            this.imageList1.Images.SetKeyName(8, "Gruyere.jpg");
            this.imageList1.Images.SetKeyName(9, "Gouda.jpg");
            this.imageList1.Images.SetKeyName(10, "Parmesan.jpg");
            this.imageList1.Images.SetKeyName(11, "cheddar.jpg");
            this.imageList1.Images.SetKeyName(12, "Vega.jpeg");
            // 
            // Pan_Size
            // 
            this.Pan_Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pan_Size.Controls.Add(this.Comb_Size);
            this.Pan_Size.Location = new System.Drawing.Point(14, 69);
            this.Pan_Size.Name = "Pan_Size";
            this.Pan_Size.Size = new System.Drawing.Size(162, 156);
            this.Pan_Size.TabIndex = 17;
            // 
            // Pan_Main
            // 
            this.Pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pan_Main.Controls.Add(this.panel2);
            this.Pan_Main.Controls.Add(this.Lab_Place);
            this.Pan_Main.Controls.Add(this.label1);
            this.Pan_Main.Controls.Add(this.Lab_ToopingsPanel);
            this.Pan_Main.Controls.Add(this.label2);
            this.Pan_Main.Controls.Add(this.Pan_Toppings);
            this.Pan_Main.Controls.Add(this.Pan_Size);
            this.Pan_Main.Controls.Add(this.panel1);
            this.Pan_Main.Location = new System.Drawing.Point(360, 83);
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.Size = new System.Drawing.Size(631, 455);
            this.Pan_Main.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Rdb_Think);
            this.panel2.Controls.Add(this.Rdb_Thin);
            this.panel2.Location = new System.Drawing.Point(23, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 115);
            this.panel2.TabIndex = 26;
            // 
            // Rdb_Think
            // 
            this.Rdb_Think.AutoSize = true;
            this.Rdb_Think.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Think.Location = new System.Drawing.Point(14, 62);
            this.Rdb_Think.Name = "Rdb_Think";
            this.Rdb_Think.Size = new System.Drawing.Size(128, 28);
            this.Rdb_Think.TabIndex = 1;
            this.Rdb_Think.TabStop = true;
            this.Rdb_Think.Text = "Think Crust";
            this.Rdb_Think.UseVisualStyleBackColor = true;
            this.Rdb_Think.CheckedChanged += new System.EventHandler(this.Rdb_Think_CheckedChanged);
            // 
            // Rdb_Thin
            // 
            this.Rdb_Thin.AutoSize = true;
            this.Rdb_Thin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Thin.Location = new System.Drawing.Point(14, 12);
            this.Rdb_Thin.Name = "Rdb_Thin";
            this.Rdb_Thin.Size = new System.Drawing.Size(118, 28);
            this.Rdb_Thin.TabIndex = 0;
            this.Rdb_Thin.TabStop = true;
            this.Rdb_Thin.Text = "Thin Crust";
            this.Rdb_Thin.UseVisualStyleBackColor = true;
            this.Rdb_Thin.CheckedChanged += new System.EventHandler(this.Rdb_Thin_CheckedChanged);
            // 
            // Lab_Place
            // 
            this.Lab_Place.AutoSize = true;
            this.Lab_Place.BackColor = System.Drawing.Color.OrangeRed;
            this.Lab_Place.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Place.Location = new System.Drawing.Point(266, 303);
            this.Lab_Place.Name = "Lab_Place";
            this.Lab_Place.Size = new System.Drawing.Size(74, 31);
            this.Lab_Place.TabIndex = 25;
            this.Lab_Place.Text = "Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Crust";
            // 
            // Lab_ToopingsPanel
            // 
            this.Lab_ToopingsPanel.AutoSize = true;
            this.Lab_ToopingsPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.Lab_ToopingsPanel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_ToopingsPanel.Location = new System.Drawing.Point(233, 34);
            this.Lab_ToopingsPanel.Name = "Lab_ToopingsPanel";
            this.Lab_ToopingsPanel.Size = new System.Drawing.Size(106, 27);
            this.Lab_ToopingsPanel.TabIndex = 23;
            this.Lab_ToopingsPanel.Text = "Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Size";
            // 
            // Pan_Toppings
            // 
            this.Pan_Toppings.Controls.Add(this.Ckb_Green);
            this.Pan_Toppings.Controls.Add(this.Ckb_ExtraCheese);
            this.Pan_Toppings.Controls.Add(this.Ckb_Tematoes);
            this.Pan_Toppings.Controls.Add(this.Ckb_Onion);
            this.Pan_Toppings.Controls.Add(this.Ckb_Mushrooms);
            this.Pan_Toppings.Controls.Add(this.Ckb_Olives);
            this.Pan_Toppings.Location = new System.Drawing.Point(236, 69);
            this.Pan_Toppings.Name = "Pan_Toppings";
            this.Pan_Toppings.Size = new System.Drawing.Size(346, 185);
            this.Pan_Toppings.TabIndex = 22;
            // 
            // Ckb_Green
            // 
            this.Ckb_Green.AutoSize = true;
            this.Ckb_Green.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckb_Green.Location = new System.Drawing.Point(183, 121);
            this.Ckb_Green.Name = "Ckb_Green";
            this.Ckb_Green.Size = new System.Drawing.Size(156, 28);
            this.Ckb_Green.TabIndex = 5;
            this.Ckb_Green.Text = "Green Peppers";
            this.Ckb_Green.UseVisualStyleBackColor = true;
            this.Ckb_Green.CheckedChanged += new System.EventHandler(this.Ckb_Green_CheckedChanged);
            // 
            // Ckb_ExtraCheese
            // 
            this.Ckb_ExtraCheese.AutoSize = true;
            this.Ckb_ExtraCheese.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckb_ExtraCheese.Location = new System.Drawing.Point(33, 38);
            this.Ckb_ExtraCheese.Name = "Ckb_ExtraCheese";
            this.Ckb_ExtraCheese.Size = new System.Drawing.Size(141, 28);
            this.Ckb_ExtraCheese.TabIndex = 0;
            this.Ckb_ExtraCheese.Text = "Extra Cheese";
            this.Ckb_ExtraCheese.UseVisualStyleBackColor = true;
            this.Ckb_ExtraCheese.CheckedChanged += new System.EventHandler(this.Ckb_ExtraCheese_CheckedChanged);
            // 
            // Ckb_Tematoes
            // 
            this.Ckb_Tematoes.AutoSize = true;
            this.Ckb_Tematoes.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckb_Tematoes.Location = new System.Drawing.Point(33, 121);
            this.Ckb_Tematoes.Name = "Ckb_Tematoes";
            this.Ckb_Tematoes.Size = new System.Drawing.Size(117, 28);
            this.Ckb_Tematoes.TabIndex = 4;
            this.Ckb_Tematoes.Text = "Tomatoes";
            this.Ckb_Tematoes.UseVisualStyleBackColor = true;
            this.Ckb_Tematoes.CheckedChanged += new System.EventHandler(this.Ckb_Tematoes_CheckedChanged);
            // 
            // Ckb_Onion
            // 
            this.Ckb_Onion.AutoSize = true;
            this.Ckb_Onion.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckb_Onion.Location = new System.Drawing.Point(183, 38);
            this.Ckb_Onion.Name = "Ckb_Onion";
            this.Ckb_Onion.Size = new System.Drawing.Size(84, 28);
            this.Ckb_Onion.TabIndex = 1;
            this.Ckb_Onion.Text = "Onion";
            this.Ckb_Onion.UseVisualStyleBackColor = true;
            this.Ckb_Onion.CheckedChanged += new System.EventHandler(this.Ckb_Onion_CheckedChanged);
            // 
            // Ckb_Mushrooms
            // 
            this.Ckb_Mushrooms.AutoSize = true;
            this.Ckb_Mushrooms.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckb_Mushrooms.Location = new System.Drawing.Point(33, 80);
            this.Ckb_Mushrooms.Name = "Ckb_Mushrooms";
            this.Ckb_Mushrooms.Size = new System.Drawing.Size(133, 28);
            this.Ckb_Mushrooms.TabIndex = 3;
            this.Ckb_Mushrooms.Text = "Mushrooms";
            this.Ckb_Mushrooms.UseVisualStyleBackColor = true;
            this.Ckb_Mushrooms.CheckedChanged += new System.EventHandler(this.Ckb_Mushrooms_CheckedChanged);
            // 
            // Ckb_Olives
            // 
            this.Ckb_Olives.AutoSize = true;
            this.Ckb_Olives.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckb_Olives.Location = new System.Drawing.Point(183, 80);
            this.Ckb_Olives.Name = "Ckb_Olives";
            this.Ckb_Olives.Size = new System.Drawing.Size(84, 28);
            this.Ckb_Olives.TabIndex = 2;
            this.Ckb_Olives.Text = "Olives";
            this.Ckb_Olives.UseVisualStyleBackColor = true;
            this.Ckb_Olives.CheckedChanged += new System.EventHandler(this.Ckb_Olives_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rdb_EatIn);
            this.panel1.Controls.Add(this.Rdb_TakeAway);
            this.panel1.Location = new System.Drawing.Point(269, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 69);
            this.panel1.TabIndex = 22;
            // 
            // Rdb_EatIn
            // 
            this.Rdb_EatIn.AutoSize = true;
            this.Rdb_EatIn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_EatIn.Location = new System.Drawing.Point(219, 18);
            this.Rdb_EatIn.Name = "Rdb_EatIn";
            this.Rdb_EatIn.Size = new System.Drawing.Size(79, 28);
            this.Rdb_EatIn.TabIndex = 1;
            this.Rdb_EatIn.TabStop = true;
            this.Rdb_EatIn.Text = "Eat in";
            this.Rdb_EatIn.UseVisualStyleBackColor = true;
            this.Rdb_EatIn.CheckedChanged += new System.EventHandler(this.Rdb_EatIn_CheckedChanged);
            // 
            // Rdb_TakeAway
            // 
            this.Rdb_TakeAway.AutoSize = true;
            this.Rdb_TakeAway.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_TakeAway.Location = new System.Drawing.Point(50, 18);
            this.Rdb_TakeAway.Name = "Rdb_TakeAway";
            this.Rdb_TakeAway.Size = new System.Drawing.Size(124, 28);
            this.Rdb_TakeAway.TabIndex = 0;
            this.Rdb_TakeAway.TabStop = true;
            this.Rdb_TakeAway.Text = "Take Away";
            this.Rdb_TakeAway.UseVisualStyleBackColor = true;
            this.Rdb_TakeAway.CheckedChanged += new System.EventHandler(this.Rdb_TakeAway_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.whiteModeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 52);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.darkModeToolStripMenuItem.Text = "&DarkMode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // whiteModeToolStripMenuItem
            // 
            this.whiteModeToolStripMenuItem.Name = "whiteModeToolStripMenuItem";
            this.whiteModeToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.whiteModeToolStripMenuItem.Text = "&WhiteMode";
            this.whiteModeToolStripMenuItem.Click += new System.EventHandler(this.whiteModeToolStripMenuItem_Click);
            // 
            // Pan_Summary
            // 
            this.Pan_Summary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pan_Summary.Controls.Add(this.Lab_Toppings);
            this.Pan_Summary.Controls.Add(this.Lab_Size);
            this.Pan_Summary.Controls.Add(this.Lab_Eat);
            this.Pan_Summary.Controls.Add(this.Lab_WhichCrust);
            this.Pan_Summary.Controls.Add(this.Lab_CrustType);
            this.Pan_Summary.Controls.Add(this.Lab_WhichEat);
            this.Pan_Summary.Controls.Add(this.Lab_WhichSize);
            this.Pan_Summary.Controls.Add(this.Lab_WhichToppings);
            this.Pan_Summary.Location = new System.Drawing.Point(997, 124);
            this.Pan_Summary.Name = "Pan_Summary";
            this.Pan_Summary.Size = new System.Drawing.Size(410, 346);
            this.Pan_Summary.TabIndex = 10;
            // 
            // Lab_Summary
            // 
            this.Lab_Summary.AutoSize = true;
            this.Lab_Summary.BackColor = System.Drawing.Color.OrangeRed;
            this.Lab_Summary.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Summary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lab_Summary.Location = new System.Drawing.Point(997, 83);
            this.Lab_Summary.Name = "Lab_Summary";
            this.Lab_Summary.Size = new System.Drawing.Size(199, 31);
            this.Lab_Summary.TabIndex = 18;
            this.Lab_Summary.Text = "Summary Order";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pizza_Order.Properties.Resources.Supreme_pizza;
            this.pictureBox2.Location = new System.Drawing.Point(67, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Order.Properties.Resources.Pizza2;
            this.pictureBox1.Location = new System.Drawing.Point(67, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Orange;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1417, 77);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Orange;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(1, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 609);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // FrmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1419, 687);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Lab_WhichPrice);
            this.Controls.Add(this.Lab_Price);
            this.Controls.Add(this.Lab_MainLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Lab_Summary);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pan_Summary);
            this.Controls.Add(this.Pan_Main);
            this.Controls.Add(this.Btn_ResetForm);
            this.Controls.Add(this.Btn_OrderPizza);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPizzaOrder";
            this.Text = "Pizza Order";
            this.Pan_Size.ResumeLayout(false);
            this.Pan_Main.ResumeLayout(false);
            this.Pan_Main.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pan_Toppings.ResumeLayout(false);
            this.Pan_Toppings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Pan_Summary.ResumeLayout(false);
            this.Pan_Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Lab_MainLabel;
        private System.Windows.Forms.Label Lab_Size;
        private System.Windows.Forms.Label Lab_WhichSize;
        private System.Windows.Forms.Label Lab_Toppings;
        private System.Windows.Forms.Label Lab_WhichToppings;
        private System.Windows.Forms.Label Lab_CrustType;
        private System.Windows.Forms.Label Lab_WhichCrust;
        private System.Windows.Forms.Label Lab_Eat;
        private System.Windows.Forms.Label Lab_WhichEat;
        private System.Windows.Forms.Label Lab_Price;
        private System.Windows.Forms.Label Lab_WhichPrice;
        private System.Windows.Forms.Button Btn_OrderPizza;
        private System.Windows.Forms.Button Btn_ResetForm;
        private System.Windows.Forms.ComboBox Comb_Size;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pan_Size;
        private System.Windows.Forms.Panel Pan_Main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rdb_Think;
        private System.Windows.Forms.RadioButton Rdb_Thin;
        private System.Windows.Forms.CheckBox Ckb_Green;
        private System.Windows.Forms.CheckBox Ckb_Tematoes;
        private System.Windows.Forms.CheckBox Ckb_Mushrooms;
        private System.Windows.Forms.CheckBox Ckb_Olives;
        private System.Windows.Forms.CheckBox Ckb_Onion;
        private System.Windows.Forms.CheckBox Ckb_ExtraCheese;
        private System.Windows.Forms.RadioButton Rdb_EatIn;
        private System.Windows.Forms.RadioButton Rdb_TakeAway;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteModeToolStripMenuItem;
        private System.Windows.Forms.Panel Pan_Summary;
        private System.Windows.Forms.Label Lab_Summary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Pan_Toppings;
        private System.Windows.Forms.Label Lab_ToopingsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lab_Place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}