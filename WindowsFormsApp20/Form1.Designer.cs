namespace WindowsFormsApp20
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.CBFuel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FuelPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBSum = new System.Windows.Forms.TextBox();
            this.TBCount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBSum = new System.Windows.Forms.RadioButton();
            this.RBCount = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBCola = new System.Windows.Forms.CheckBox();
            this.TBPotatoCount = new System.Windows.Forms.TextBox();
            this.CBPotato = new System.Windows.Forms.CheckBox();
            this.CBHamburger = new System.Windows.Forms.CheckBox();
            this.CBHotDog = new System.Windows.Forms.CheckBox();
            this.TBHotDogPrice = new System.Windows.Forms.TextBox();
            this.TBHamburgerCount = new System.Windows.Forms.TextBox();
            this.TBHotDogCount = new System.Windows.Forms.TextBox();
            this.TBPotatoPrice = new System.Windows.Forms.TextBox();
            this.TBHamburgerPrice = new System.Windows.Forms.TextBox();
            this.TBColaPrice = new System.Windows.Forms.TextBox();
            this.TBColaCount = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CafePrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TBPrice);
            this.groupBox1.Controls.Add(this.CBFuel);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TBSum);
            this.groupBox1.Controls.Add(this.TBCount);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(195, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Грн";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(197, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Л";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(195, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Грн";
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(68, 67);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.ReadOnly = true;
            this.TBPrice.Size = new System.Drawing.Size(121, 20);
            this.TBPrice.TabIndex = 8;
            // 
            // CBFuel
            // 
            this.CBFuel.FormattingEnabled = true;
            this.CBFuel.Location = new System.Drawing.Point(68, 30);
            this.CBFuel.Name = "CBFuel";
            this.CBFuel.Size = new System.Drawing.Size(121, 21);
            this.CBFuel.TabIndex = 7;
            this.CBFuel.SelectedIndexChanged += new System.EventHandler(this.CBFuel_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.FuelPrice);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(13, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 94);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "До Оплати";
            // 
            // FuelPrice
            // 
            this.FuelPrice.AutoSize = true;
            this.FuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FuelPrice.Location = new System.Drawing.Point(16, 35);
            this.FuelPrice.Name = "FuelPrice";
            this.FuelPrice.Size = new System.Drawing.Size(39, 42);
            this.FuelPrice.TabIndex = 12;
            this.FuelPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(145, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Грн";
            // 
            // TBSum
            // 
            this.TBSum.Location = new System.Drawing.Point(116, 142);
            this.TBSum.Name = "TBSum";
            this.TBSum.Size = new System.Drawing.Size(78, 20);
            this.TBSum.TabIndex = 4;
            this.TBSum.TextChanged += new System.EventHandler(this.TBCount_TextChanged);
            // 
            // TBCount
            // 
            this.TBCount.Location = new System.Drawing.Point(116, 116);
            this.TBCount.Name = "TBCount";
            this.TBCount.Size = new System.Drawing.Size(78, 20);
            this.TBCount.TabIndex = 3;
            this.TBCount.TextChanged += new System.EventHandler(this.TBCount_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBSum);
            this.groupBox2.Controls.Add(this.RBCount);
            this.groupBox2.Location = new System.Drawing.Point(10, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // RBSum
            // 
            this.RBSum.AutoSize = true;
            this.RBSum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RBSum.Location = new System.Drawing.Point(6, 42);
            this.RBSum.Name = "RBSum";
            this.RBSum.Size = new System.Drawing.Size(51, 17);
            this.RBSum.TabIndex = 12;
            this.RBSum.TabStop = true;
            this.RBSum.Text = "Сума";
            this.RBSum.UseVisualStyleBackColor = true;
            // 
            // RBCount
            // 
            this.RBCount.AutoSize = true;
            this.RBCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RBCount.Location = new System.Drawing.Point(6, 19);
            this.RBCount.Name = "RBCount";
            this.RBCount.Size = new System.Drawing.Size(71, 17);
            this.RBCount.TabIndex = 11;
            this.RBCount.TabStop = true;
            this.RBCount.Text = "Кiлькiсть";
            this.RBCount.UseVisualStyleBackColor = true;
            this.RBCount.CheckedChanged += new System.EventHandler(this.RBCount_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цiна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(280, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 298);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Miнi-Кафе";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CBCola, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBPotatoCount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBPotato, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBHamburger, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CBHotDog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBHotDogPrice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBHamburgerCount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBHotDogCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBPotatoPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBHamburgerPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBColaPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBColaCount, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 100);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // CBCola
            // 
            this.CBCola.AutoSize = true;
            this.CBCola.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CBCola.Location = new System.Drawing.Point(3, 78);
            this.CBCola.Name = "CBCola";
            this.CBCola.Size = new System.Drawing.Size(79, 17);
            this.CBCola.TabIndex = 12;
            this.CBCola.Text = "Кока-Кола";
            this.CBCola.UseVisualStyleBackColor = true;
            this.CBCola.CheckedChanged += new System.EventHandler(this.CBHotDog_CheckedChanged);
            // 
            // TBPotatoCount
            // 
            this.TBPotatoCount.Location = new System.Drawing.Point(159, 53);
            this.TBPotatoCount.Name = "TBPotatoCount";
            this.TBPotatoCount.ReadOnly = true;
            this.TBPotatoCount.Size = new System.Drawing.Size(47, 20);
            this.TBPotatoCount.TabIndex = 20;
            this.TBPotatoCount.TextChanged += new System.EventHandler(this.TBHotDogCount_TextChanged);
            // 
            // CBPotato
            // 
            this.CBPotato.AutoSize = true;
            this.CBPotato.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CBPotato.Location = new System.Drawing.Point(3, 53);
            this.CBPotato.Name = "CBPotato";
            this.CBPotato.Size = new System.Drawing.Size(96, 17);
            this.CBPotato.TabIndex = 11;
            this.CBPotato.Text = "Картопля-Фрi";
            this.CBPotato.UseVisualStyleBackColor = true;
            this.CBPotato.CheckedChanged += new System.EventHandler(this.CBHotDog_CheckedChanged);
            // 
            // CBHamburger
            // 
            this.CBHamburger.AutoSize = true;
            this.CBHamburger.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CBHamburger.Location = new System.Drawing.Point(3, 28);
            this.CBHamburger.Name = "CBHamburger";
            this.CBHamburger.Size = new System.Drawing.Size(80, 17);
            this.CBHamburger.TabIndex = 10;
            this.CBHamburger.Text = "Гамбургер";
            this.CBHamburger.UseVisualStyleBackColor = true;
            this.CBHamburger.CheckedChanged += new System.EventHandler(this.CBHotDog_CheckedChanged);
            // 
            // CBHotDog
            // 
            this.CBHotDog.AutoSize = true;
            this.CBHotDog.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CBHotDog.Location = new System.Drawing.Point(3, 3);
            this.CBHotDog.Name = "CBHotDog";
            this.CBHotDog.Size = new System.Drawing.Size(67, 17);
            this.CBHotDog.TabIndex = 9;
            this.CBHotDog.Text = "Хот-Дог";
            this.CBHotDog.UseVisualStyleBackColor = true;
            this.CBHotDog.CheckedChanged += new System.EventHandler(this.CBHotDog_CheckedChanged);
            // 
            // TBHotDogPrice
            // 
            this.TBHotDogPrice.Location = new System.Drawing.Point(107, 3);
            this.TBHotDogPrice.Name = "TBHotDogPrice";
            this.TBHotDogPrice.ReadOnly = true;
            this.TBHotDogPrice.Size = new System.Drawing.Size(46, 20);
            this.TBHotDogPrice.TabIndex = 12;
            // 
            // TBHamburgerCount
            // 
            this.TBHamburgerCount.Location = new System.Drawing.Point(159, 28);
            this.TBHamburgerCount.Name = "TBHamburgerCount";
            this.TBHamburgerCount.ReadOnly = true;
            this.TBHamburgerCount.Size = new System.Drawing.Size(47, 20);
            this.TBHamburgerCount.TabIndex = 18;
            this.TBHamburgerCount.TextChanged += new System.EventHandler(this.TBHotDogCount_TextChanged);
            // 
            // TBHotDogCount
            // 
            this.TBHotDogCount.Location = new System.Drawing.Point(159, 3);
            this.TBHotDogCount.Name = "TBHotDogCount";
            this.TBHotDogCount.ReadOnly = true;
            this.TBHotDogCount.Size = new System.Drawing.Size(47, 20);
            this.TBHotDogCount.TabIndex = 14;
            this.TBHotDogCount.TextChanged += new System.EventHandler(this.TBHotDogCount_TextChanged);
            // 
            // TBPotatoPrice
            // 
            this.TBPotatoPrice.Location = new System.Drawing.Point(107, 53);
            this.TBPotatoPrice.Name = "TBPotatoPrice";
            this.TBPotatoPrice.ReadOnly = true;
            this.TBPotatoPrice.Size = new System.Drawing.Size(46, 20);
            this.TBPotatoPrice.TabIndex = 17;
            // 
            // TBHamburgerPrice
            // 
            this.TBHamburgerPrice.Location = new System.Drawing.Point(107, 28);
            this.TBHamburgerPrice.Name = "TBHamburgerPrice";
            this.TBHamburgerPrice.ReadOnly = true;
            this.TBHamburgerPrice.Size = new System.Drawing.Size(46, 20);
            this.TBHamburgerPrice.TabIndex = 16;
            // 
            // TBColaPrice
            // 
            this.TBColaPrice.Location = new System.Drawing.Point(107, 78);
            this.TBColaPrice.Name = "TBColaPrice";
            this.TBColaPrice.ReadOnly = true;
            this.TBColaPrice.Size = new System.Drawing.Size(46, 20);
            this.TBColaPrice.TabIndex = 15;
            // 
            // TBColaCount
            // 
            this.TBColaCount.Location = new System.Drawing.Point(159, 78);
            this.TBColaCount.Name = "TBColaCount";
            this.TBColaCount.ReadOnly = true;
            this.TBColaCount.Size = new System.Drawing.Size(47, 20);
            this.TBColaCount.TabIndex = 19;
            this.TBColaCount.TextChanged += new System.EventHandler(this.TBHotDogCount_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.CafePrice);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(6, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 94);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "До Оплати";
            // 
            // CafePrice
            // 
            this.CafePrice.AutoSize = true;
            this.CafePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CafePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CafePrice.Location = new System.Drawing.Point(27, 35);
            this.CafePrice.Name = "CafePrice";
            this.CafePrice.Size = new System.Drawing.Size(39, 42);
            this.CafePrice.TabIndex = 12;
            this.CafePrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(140, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Грн";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(171, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Кiлькiсть";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(119, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Цiна";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.CalculateBtn);
            this.groupBox6.Controls.Add(this.TotalPrice);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox6.Location = new System.Drawing.Point(27, 349);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 100);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ВСЬОГО до сплати";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(373, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Грн";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CalculateBtn.Location = new System.Drawing.Point(103, 37);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(130, 52);
            this.CalculateBtn.TabIndex = 0;
            this.CalculateBtn.Text = "Порахувати";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TotalPrice.Location = new System.Drawing.Point(257, 37);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(39, 42);
            this.TotalPrice.TabIndex = 7;
            this.TotalPrice.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.ComboBox CBFuel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label FuelPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBSum;
        private System.Windows.Forms.TextBox TBCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBSum;
        private System.Windows.Forms.RadioButton RBCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label CafePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBHotDogPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TBPotatoCount;
        private System.Windows.Forms.TextBox TBHamburgerCount;
        private System.Windows.Forms.TextBox TBHotDogCount;
        private System.Windows.Forms.TextBox TBPotatoPrice;
        private System.Windows.Forms.TextBox TBHamburgerPrice;
        private System.Windows.Forms.TextBox TBColaPrice;
        private System.Windows.Forms.TextBox TBColaCount;
        private System.Windows.Forms.CheckBox CBHotDog;
        private System.Windows.Forms.CheckBox CBCola;
        private System.Windows.Forms.CheckBox CBPotato;
        private System.Windows.Forms.CheckBox CBHamburger;
        private System.Windows.Forms.Timer timer1;
    }
}

