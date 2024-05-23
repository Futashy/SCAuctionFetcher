namespace SCAuctionFetcher
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoBox1 = new System.Windows.Forms.TextBox();
            this.timerBox1 = new System.Windows.Forms.TextBox();
            this.priceThresholdBox = new System.Windows.Forms.TextBox();
            this.priceBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceSetBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timerSetBox1 = new System.Windows.Forms.MaskedTextBox();
            this.idSetBox1 = new System.Windows.Forms.MaskedTextBox();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBrowser = new System.Windows.Forms.CheckBox();
            this.checkBoxConsole = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveSessionButton = new System.Windows.Forms.Button();
            this.loadSessionButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textIdBox = new System.Windows.Forms.TextBox();
            this.textNameBox = new System.Windows.Forms.TextBox();
            this.editItemButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.infoBox1);
            this.panel1.Controls.Add(this.timerBox1);
            this.panel1.Controls.Add(this.priceThresholdBox);
            this.panel1.Controls.Add(this.priceBox1);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 125);
            this.panel1.TabIndex = 6;
            // 
            // infoBox1
            // 
            this.infoBox1.BackColor = System.Drawing.Color.Gray;
            this.infoBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox1.ForeColor = System.Drawing.Color.White;
            this.infoBox1.Location = new System.Drawing.Point(73, 3);
            this.infoBox1.Multiline = true;
            this.infoBox1.Name = "infoBox1";
            this.infoBox1.ReadOnly = true;
            this.infoBox1.Size = new System.Drawing.Size(133, 64);
            this.infoBox1.TabIndex = 4;
            this.infoBox1.Text = "ITEM ID";
            this.infoBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerBox1
            // 
            this.timerBox1.BackColor = System.Drawing.Color.DimGray;
            this.timerBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerBox1.ForeColor = System.Drawing.Color.White;
            this.timerBox1.Location = new System.Drawing.Point(142, 73);
            this.timerBox1.Name = "timerBox1";
            this.timerBox1.ReadOnly = true;
            this.timerBox1.Size = new System.Drawing.Size(64, 20);
            this.timerBox1.TabIndex = 3;
            this.timerBox1.Text = "Timer";
            this.timerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceThresholdBox
            // 
            this.priceThresholdBox.BackColor = System.Drawing.Color.DimGray;
            this.priceThresholdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceThresholdBox.ForeColor = System.Drawing.Color.White;
            this.priceThresholdBox.Location = new System.Drawing.Point(3, 99);
            this.priceThresholdBox.Name = "priceThresholdBox";
            this.priceThresholdBox.ReadOnly = true;
            this.priceThresholdBox.Size = new System.Drawing.Size(133, 20);
            this.priceThresholdBox.TabIndex = 2;
            this.priceThresholdBox.Text = "Price Threshold";
            this.priceThresholdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceBox1
            // 
            this.priceBox1.BackColor = System.Drawing.Color.DimGray;
            this.priceBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox1.ForeColor = System.Drawing.Color.White;
            this.priceBox1.Location = new System.Drawing.Point(3, 73);
            this.priceBox1.Name = "priceBox1";
            this.priceBox1.ReadOnly = true;
            this.priceBox1.Size = new System.Drawing.Size(133, 20);
            this.priceBox1.TabIndex = 2;
            this.priceBox1.Text = "Minimal Price";
            this.priceBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ImageLocation = "https://stalcraft-monitor.ru/db/icons/other/4k5gr.png";
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(64, 64);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time Interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item ID";
            // 
            // PriceSetBox1
            // 
            this.PriceSetBox1.BackColor = System.Drawing.Color.DimGray;
            this.PriceSetBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceSetBox1.ForeColor = System.Drawing.Color.White;
            this.PriceSetBox1.HidePromptOnLeave = true;
            this.PriceSetBox1.Location = new System.Drawing.Point(126, 76);
            this.PriceSetBox1.Name = "PriceSetBox1";
            this.PriceSetBox1.Size = new System.Drawing.Size(108, 20);
            this.PriceSetBox1.TabIndex = 7;
            this.PriceSetBox1.Text = "100000";
            this.PriceSetBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceSetBox1.ValidatingType = typeof(int);
            // 
            // timerSetBox1
            // 
            this.timerSetBox1.BackColor = System.Drawing.Color.DimGray;
            this.timerSetBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerSetBox1.ForeColor = System.Drawing.Color.White;
            this.timerSetBox1.Location = new System.Drawing.Point(126, 46);
            this.timerSetBox1.Name = "timerSetBox1";
            this.timerSetBox1.Size = new System.Drawing.Size(51, 20);
            this.timerSetBox1.TabIndex = 7;
            this.timerSetBox1.Text = "60";
            this.timerSetBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idSetBox1
            // 
            this.idSetBox1.BackColor = System.Drawing.Color.DimGray;
            this.idSetBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idSetBox1.ForeColor = System.Drawing.Color.White;
            this.idSetBox1.Location = new System.Drawing.Point(126, 17);
            this.idSetBox1.Name = "idSetBox1";
            this.idSetBox1.Size = new System.Drawing.Size(51, 20);
            this.idSetBox1.TabIndex = 7;
            this.idSetBox1.Text = "4k5gr";
            this.idSetBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteButton1
            // 
            this.deleteButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton1.ForeColor = System.Drawing.Color.Black;
            this.deleteButton1.Location = new System.Drawing.Point(157, 103);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(77, 50);
            this.deleteButton1.TabIndex = 6;
            this.deleteButton1.Text = "Remove last";
            this.deleteButton1.UseVisualStyleBackColor = false;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // secTimer
            // 
            this.secTimer.Enabled = true;
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 450);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create new";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CreatePanelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deleteButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PriceSetBox1);
            this.groupBox1.Controls.Add(this.idSetBox1);
            this.groupBox1.Controls.Add(this.timerSetBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 159);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // checkBoxBrowser
            // 
            this.checkBoxBrowser.AutoSize = true;
            this.checkBoxBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxBrowser.Location = new System.Drawing.Point(141, 14);
            this.checkBoxBrowser.Name = "checkBoxBrowser";
            this.checkBoxBrowser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxBrowser.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBrowser.TabIndex = 11;
            this.checkBoxBrowser.Text = "Open Browser";
            this.checkBoxBrowser.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsole
            // 
            this.checkBoxConsole.AutoSize = true;
            this.checkBoxConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxConsole.Location = new System.Drawing.Point(6, 14);
            this.checkBoxConsole.Name = "checkBoxConsole";
            this.checkBoxConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxConsole.Size = new System.Drawing.Size(93, 17);
            this.checkBoxConsole.TabIndex = 11;
            this.checkBoxConsole.Text = "Open Console";
            this.checkBoxConsole.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(719, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Version : 1.1.5";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(453, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 450);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox2.Controls.Add(this.saveSessionButton);
            this.groupBox2.Controls.Add(this.loadSessionButton);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session";
            // 
            // saveSessionButton
            // 
            this.saveSessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSessionButton.ForeColor = System.Drawing.Color.Black;
            this.saveSessionButton.Location = new System.Drawing.Point(11, 19);
            this.saveSessionButton.Name = "saveSessionButton";
            this.saveSessionButton.Size = new System.Drawing.Size(77, 50);
            this.saveSessionButton.TabIndex = 8;
            this.saveSessionButton.Text = "Save";
            this.saveSessionButton.UseVisualStyleBackColor = false;
            this.saveSessionButton.Click += new System.EventHandler(this.saveSessionButton_Click);
            // 
            // loadSessionButton
            // 
            this.loadSessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loadSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSessionButton.ForeColor = System.Drawing.Color.Black;
            this.loadSessionButton.Location = new System.Drawing.Point(95, 19);
            this.loadSessionButton.Name = "loadSessionButton";
            this.loadSessionButton.Size = new System.Drawing.Size(77, 50);
            this.loadSessionButton.TabIndex = 8;
            this.loadSessionButton.Text = "Load";
            this.loadSessionButton.UseVisualStyleBackColor = false;
            this.loadSessionButton.Click += new System.EventHandler(this.loadSessionButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox3.Controls.Add(this.checkBoxBrowser);
            this.groupBox3.Controls.Add(this.checkBoxConsole);
            this.groupBox3.Location = new System.Drawing.Point(6, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 38);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.textIdBox);
            this.tabPage2.Controls.Add(this.textNameBox);
            this.tabPage2.Controls.Add(this.editItemButton);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.removeItemButton);
            this.tabPage2.Controls.Add(this.addItemButton);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            // 
            // textIdBox
            // 
            this.textIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.textIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdBox.ForeColor = System.Drawing.Color.White;
            this.textIdBox.Location = new System.Drawing.Point(267, 366);
            this.textIdBox.Name = "textIdBox";
            this.textIdBox.Size = new System.Drawing.Size(66, 20);
            this.textIdBox.TabIndex = 2;
            this.textIdBox.Text = "ID";
            // 
            // textNameBox
            // 
            this.textNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.textNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNameBox.ForeColor = System.Drawing.Color.White;
            this.textNameBox.Location = new System.Drawing.Point(6, 366);
            this.textNameBox.Name = "textNameBox";
            this.textNameBox.Size = new System.Drawing.Size(255, 20);
            this.textNameBox.TabIndex = 2;
            this.textNameBox.Text = "Item Info";
            // 
            // editItemButton
            // 
            this.editItemButton.BackColor = System.Drawing.Color.LightGray;
            this.editItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemButton.Location = new System.Drawing.Point(87, 392);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(75, 23);
            this.editItemButton.TabIndex = 1;
            this.editItemButton.Text = "Set";
            this.editItemButton.UseVisualStyleBackColor = false;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(258, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.LightGray;
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Location = new System.Drawing.Point(168, 392);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 23);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.LightGray;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Location = new System.Drawing.Point(6, 392);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(339, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 263;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 40;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(339, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "StalCraft Auction Fetcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox infoBox1;
        private System.Windows.Forms.TextBox timerBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox priceBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Timer secTimer;
        private System.Windows.Forms.MaskedTextBox PriceSetBox1;
        private System.Windows.Forms.MaskedTextBox timerSetBox1;
        private System.Windows.Forms.MaskedTextBox idSetBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceThresholdBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxConsole;
        private System.Windows.Forms.CheckBox checkBoxBrowser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox textNameBox;
        private System.Windows.Forms.TextBox textIdBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveSessionButton;
        private System.Windows.Forms.Button loadSessionButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

