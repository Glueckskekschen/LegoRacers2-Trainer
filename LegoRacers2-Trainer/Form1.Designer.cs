namespace LegoRacers2_Trainer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_status = new System.Windows.Forms.Label();
            this.trackBar_Cars = new System.Windows.Forms.TrackBar();
            this.label_Cars = new System.Windows.Forms.Label();
            this.checkBox_Cars = new System.Windows.Forms.CheckBox();
            this.timer_Write = new System.Windows.Forms.Timer(this.components);
            this.timer_Process = new System.Windows.Forms.Timer(this.components);
            this.checkBox_Special = new System.Windows.Forms.CheckBox();
            this.trackBar_Car1 = new System.Windows.Forms.TrackBar();
            this.label_Special_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Special_2 = new System.Windows.Forms.Label();
            this.label_Special_3 = new System.Windows.Forms.Label();
            this.label_Special_4 = new System.Windows.Forms.Label();
            this.label_Special_5 = new System.Windows.Forms.Label();
            this.label_Special_6 = new System.Windows.Forms.Label();
            this.trackBar_Car2 = new System.Windows.Forms.TrackBar();
            this.trackBar_Car3 = new System.Windows.Forms.TrackBar();
            this.trackBar_Car5 = new System.Windows.Forms.TrackBar();
            this.trackBar_Car6 = new System.Windows.Forms.TrackBar();
            this.trackBar_Car7 = new System.Windows.Forms.TrackBar();
            this.trackBar_Car8 = new System.Windows.Forms.TrackBar();
            this.trackBar_Car4 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_Special_7 = new System.Windows.Forms.Label();
            this.label_Special_8 = new System.Windows.Forms.Label();
            this.groupBox_Cars = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label_Laps = new System.Windows.Forms.Label();
            this.checkBox_Laps = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Laps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car4)).BeginInit();
            this.groupBox_Cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Laps)).BeginInit();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(14, 9);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(156, 20);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "Wait for the Game";
            // 
            // trackBar_Cars
            // 
            this.trackBar_Cars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Cars.Location = new System.Drawing.Point(69, 43);
            this.trackBar_Cars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Cars.Maximum = 8;
            this.trackBar_Cars.Minimum = 1;
            this.trackBar_Cars.Name = "trackBar_Cars";
            this.trackBar_Cars.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Cars.TabIndex = 2;
            this.trackBar_Cars.Value = 1;
            this.trackBar_Cars.Scroll += new System.EventHandler(this.trackBar_Cars_Scroll);
            // 
            // label_Cars
            // 
            this.label_Cars.AutoSize = true;
            this.label_Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cars.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Cars.Location = new System.Drawing.Point(15, 54);
            this.label_Cars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cars.Name = "label_Cars";
            this.label_Cars.Size = new System.Drawing.Size(43, 13);
            this.label_Cars.TabIndex = 3;
            this.label_Cars.Text = "Cars 1";
            // 
            // checkBox_Cars
            // 
            this.checkBox_Cars.AutoSize = true;
            this.checkBox_Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Cars.ForeColor = System.Drawing.Color.YellowGreen;
            this.checkBox_Cars.Location = new System.Drawing.Point(270, 50);
            this.checkBox_Cars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_Cars.Name = "checkBox_Cars";
            this.checkBox_Cars.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Cars.TabIndex = 5;
            this.checkBox_Cars.Text = "Select";
            this.checkBox_Cars.UseVisualStyleBackColor = true;
            this.checkBox_Cars.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // timer_Write
            // 
            this.timer_Write.Interval = 10;
            this.timer_Write.Tick += new System.EventHandler(this.timer_Write_Tick);
            // 
            // timer_Process
            // 
            this.timer_Process.Interval = 300;
            this.timer_Process.Tick += new System.EventHandler(this.timer_Process_Tick);
            // 
            // checkBox_Special
            // 
            this.checkBox_Special.AutoSize = true;
            this.checkBox_Special.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Special.ForeColor = System.Drawing.Color.YellowGreen;
            this.checkBox_Special.Location = new System.Drawing.Point(10, 407);
            this.checkBox_Special.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_Special.Name = "checkBox_Special";
            this.checkBox_Special.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Special.TabIndex = 6;
            this.checkBox_Special.Text = "Select";
            this.checkBox_Special.UseVisualStyleBackColor = true;
            this.checkBox_Special.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // trackBar_Car1
            // 
            this.trackBar_Car1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car1.Location = new System.Drawing.Point(151, 22);
            this.trackBar_Car1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car1.Maximum = 5;
            this.trackBar_Car1.Minimum = 1;
            this.trackBar_Car1.Name = "trackBar_Car1";
            this.trackBar_Car1.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car1.TabIndex = 92;
            this.trackBar_Car1.Tag = "1";
            this.trackBar_Car1.Value = 1;
            this.trackBar_Car1.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // label_Special_1
            // 
            this.label_Special_1.AutoSize = true;
            this.label_Special_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_1.Location = new System.Drawing.Point(55, 26);
            this.label_Special_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_1.Name = "label_Special_1";
            this.label_Special_1.Size = new System.Drawing.Size(46, 13);
            this.label_Special_1.TabIndex = 8;
            this.label_Special_1.Text = "Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Car 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Car 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Car 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(7, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Car 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Car 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(7, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Car 6:";
            // 
            // label_Special_2
            // 
            this.label_Special_2.AutoSize = true;
            this.label_Special_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_2.Location = new System.Drawing.Point(55, 73);
            this.label_Special_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_2.Name = "label_Special_2";
            this.label_Special_2.Size = new System.Drawing.Size(46, 13);
            this.label_Special_2.TabIndex = 15;
            this.label_Special_2.Text = "Normal";
            // 
            // label_Special_3
            // 
            this.label_Special_3.AutoSize = true;
            this.label_Special_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_3.Location = new System.Drawing.Point(55, 124);
            this.label_Special_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_3.Name = "label_Special_3";
            this.label_Special_3.Size = new System.Drawing.Size(46, 13);
            this.label_Special_3.TabIndex = 16;
            this.label_Special_3.Text = "Normal";
            // 
            // label_Special_4
            // 
            this.label_Special_4.AutoSize = true;
            this.label_Special_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_4.Location = new System.Drawing.Point(55, 175);
            this.label_Special_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_4.Name = "label_Special_4";
            this.label_Special_4.Size = new System.Drawing.Size(46, 13);
            this.label_Special_4.TabIndex = 17;
            this.label_Special_4.Text = "Normal";
            // 
            // label_Special_5
            // 
            this.label_Special_5.AutoSize = true;
            this.label_Special_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_5.Location = new System.Drawing.Point(55, 226);
            this.label_Special_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_5.Name = "label_Special_5";
            this.label_Special_5.Size = new System.Drawing.Size(46, 13);
            this.label_Special_5.TabIndex = 18;
            this.label_Special_5.Text = "Normal";
            // 
            // label_Special_6
            // 
            this.label_Special_6.AutoSize = true;
            this.label_Special_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_6.Location = new System.Drawing.Point(55, 277);
            this.label_Special_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_6.Name = "label_Special_6";
            this.label_Special_6.Size = new System.Drawing.Size(46, 13);
            this.label_Special_6.TabIndex = 19;
            this.label_Special_6.Text = "Normal";
            // 
            // trackBar_Car2
            // 
            this.trackBar_Car2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car2.Location = new System.Drawing.Point(151, 73);
            this.trackBar_Car2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car2.Maximum = 5;
            this.trackBar_Car2.Minimum = 1;
            this.trackBar_Car2.Name = "trackBar_Car2";
            this.trackBar_Car2.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car2.TabIndex = 93;
            this.trackBar_Car2.Tag = "2";
            this.trackBar_Car2.Value = 1;
            this.trackBar_Car2.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // trackBar_Car3
            // 
            this.trackBar_Car3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car3.Location = new System.Drawing.Point(151, 124);
            this.trackBar_Car3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car3.Maximum = 5;
            this.trackBar_Car3.Minimum = 1;
            this.trackBar_Car3.Name = "trackBar_Car3";
            this.trackBar_Car3.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car3.TabIndex = 94;
            this.trackBar_Car3.Tag = "3";
            this.trackBar_Car3.Value = 1;
            this.trackBar_Car3.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // trackBar_Car5
            // 
            this.trackBar_Car5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car5.Location = new System.Drawing.Point(151, 226);
            this.trackBar_Car5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car5.Maximum = 5;
            this.trackBar_Car5.Minimum = 1;
            this.trackBar_Car5.Name = "trackBar_Car5";
            this.trackBar_Car5.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car5.TabIndex = 96;
            this.trackBar_Car5.Tag = "5";
            this.trackBar_Car5.Value = 1;
            this.trackBar_Car5.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // trackBar_Car6
            // 
            this.trackBar_Car6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car6.Location = new System.Drawing.Point(151, 277);
            this.trackBar_Car6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car6.Maximum = 5;
            this.trackBar_Car6.Minimum = 1;
            this.trackBar_Car6.Name = "trackBar_Car6";
            this.trackBar_Car6.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car6.TabIndex = 97;
            this.trackBar_Car6.Tag = "6";
            this.trackBar_Car6.Value = 1;
            this.trackBar_Car6.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // trackBar_Car7
            // 
            this.trackBar_Car7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car7.Location = new System.Drawing.Point(151, 328);
            this.trackBar_Car7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car7.Maximum = 5;
            this.trackBar_Car7.Minimum = 1;
            this.trackBar_Car7.Name = "trackBar_Car7";
            this.trackBar_Car7.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car7.TabIndex = 98;
            this.trackBar_Car7.Tag = "7";
            this.trackBar_Car7.Value = 1;
            this.trackBar_Car7.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // trackBar_Car8
            // 
            this.trackBar_Car8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car8.Location = new System.Drawing.Point(151, 379);
            this.trackBar_Car8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car8.Maximum = 5;
            this.trackBar_Car8.Minimum = 1;
            this.trackBar_Car8.Name = "trackBar_Car8";
            this.trackBar_Car8.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car8.TabIndex = 99;
            this.trackBar_Car8.Tag = "8";
            this.trackBar_Car8.Value = 1;
            this.trackBar_Car8.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // trackBar_Car4
            // 
            this.trackBar_Car4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_Car4.Location = new System.Drawing.Point(151, 175);
            this.trackBar_Car4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_Car4.Maximum = 5;
            this.trackBar_Car4.Minimum = 1;
            this.trackBar_Car4.Name = "trackBar_Car4";
            this.trackBar_Car4.Size = new System.Drawing.Size(194, 45);
            this.trackBar_Car4.TabIndex = 95;
            this.trackBar_Car4.Tag = "4";
            this.trackBar_Car4.Value = 1;
            this.trackBar_Car4.Scroll += new System.EventHandler(this.trackBar_Special_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(7, 328);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Car 7:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(7, 379);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Car 8:";
            // 
            // label_Special_7
            // 
            this.label_Special_7.AutoSize = true;
            this.label_Special_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_7.Location = new System.Drawing.Point(55, 328);
            this.label_Special_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_7.Name = "label_Special_7";
            this.label_Special_7.Size = new System.Drawing.Size(46, 13);
            this.label_Special_7.TabIndex = 29;
            this.label_Special_7.Text = "Normal";
            // 
            // label_Special_8
            // 
            this.label_Special_8.AutoSize = true;
            this.label_Special_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Special_8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Special_8.Location = new System.Drawing.Point(55, 379);
            this.label_Special_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Special_8.Name = "label_Special_8";
            this.label_Special_8.Size = new System.Drawing.Size(46, 13);
            this.label_Special_8.TabIndex = 30;
            this.label_Special_8.Text = "Normal";
            // 
            // groupBox_Cars
            // 
            this.groupBox_Cars.Controls.Add(this.numericUpDown8);
            this.groupBox_Cars.Controls.Add(this.numericUpDown7);
            this.groupBox_Cars.Controls.Add(this.numericUpDown6);
            this.groupBox_Cars.Controls.Add(this.numericUpDown5);
            this.groupBox_Cars.Controls.Add(this.numericUpDown4);
            this.groupBox_Cars.Controls.Add(this.numericUpDown3);
            this.groupBox_Cars.Controls.Add(this.numericUpDown2);
            this.groupBox_Cars.Controls.Add(this.numericUpDown1);
            this.groupBox_Cars.Controls.Add(this.label1);
            this.groupBox_Cars.Controls.Add(this.label_Special_8);
            this.groupBox_Cars.Controls.Add(this.checkBox_Special);
            this.groupBox_Cars.Controls.Add(this.label_Special_7);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car1);
            this.groupBox_Cars.Controls.Add(this.label13);
            this.groupBox_Cars.Controls.Add(this.label_Special_1);
            this.groupBox_Cars.Controls.Add(this.label12);
            this.groupBox_Cars.Controls.Add(this.label2);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car4);
            this.groupBox_Cars.Controls.Add(this.label3);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car8);
            this.groupBox_Cars.Controls.Add(this.label4);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car7);
            this.groupBox_Cars.Controls.Add(this.label5);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car6);
            this.groupBox_Cars.Controls.Add(this.label6);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car5);
            this.groupBox_Cars.Controls.Add(this.label_Special_2);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car3);
            this.groupBox_Cars.Controls.Add(this.label_Special_3);
            this.groupBox_Cars.Controls.Add(this.trackBar_Car2);
            this.groupBox_Cars.Controls.Add(this.label_Special_4);
            this.groupBox_Cars.Controls.Add(this.label_Special_6);
            this.groupBox_Cars.Controls.Add(this.label_Special_5);
            this.groupBox_Cars.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Cars.Location = new System.Drawing.Point(14, 122);
            this.groupBox_Cars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_Cars.Name = "groupBox_Cars";
            this.groupBox_Cars.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_Cars.Size = new System.Drawing.Size(421, 434);
            this.groupBox_Cars.TabIndex = 31;
            this.groupBox_Cars.TabStop = false;
            this.groupBox_Cars.Text = "Cars Special";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 24);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 100;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(352, 73);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown2.TabIndex = 101;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(352, 124);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown3.TabIndex = 102;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(352, 175);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown4.TabIndex = 103;
            this.numericUpDown4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(352, 226);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown5.TabIndex = 104;
            this.numericUpDown5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(352, 277);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown6.TabIndex = 105;
            this.numericUpDown6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(352, 328);
            this.numericUpDown7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown7.TabIndex = 106;
            this.numericUpDown7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(352, 379);
            this.numericUpDown8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown8.TabIndex = 107;
            this.numericUpDown8.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label_Laps
            // 
            this.label_Laps.AutoSize = true;
            this.label_Laps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Laps.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Laps.Location = new System.Drawing.Point(15, 96);
            this.label_Laps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Laps.Name = "label_Laps";
            this.label_Laps.Size = new System.Drawing.Size(38, 13);
            this.label_Laps.TabIndex = 32;
            this.label_Laps.Text = "Laps:";
            // 
            // checkBox_Laps
            // 
            this.checkBox_Laps.AutoSize = true;
            this.checkBox_Laps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Laps.ForeColor = System.Drawing.Color.YellowGreen;
            this.checkBox_Laps.Location = new System.Drawing.Point(270, 96);
            this.checkBox_Laps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_Laps.Name = "checkBox_Laps";
            this.checkBox_Laps.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Laps.TabIndex = 33;
            this.checkBox_Laps.Text = "Select";
            this.checkBox_Laps.UseVisualStyleBackColor = true;
            this.checkBox_Laps.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // numericUpDown_Laps
            // 
            this.numericUpDown_Laps.Location = new System.Drawing.Point(66, 92);
            this.numericUpDown_Laps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Laps.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Laps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Laps.Name = "numericUpDown_Laps";
            this.numericUpDown_Laps.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_Laps.TabIndex = 108;
            this.numericUpDown_Laps.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(448, 564);
            this.Controls.Add(this.numericUpDown_Laps);
            this.Controls.Add(this.checkBox_Laps);
            this.Controls.Add(this.label_Laps);
            this.Controls.Add(this.groupBox_Cars);
            this.Controls.Add(this.checkBox_Cars);
            this.Controls.Add(this.label_Cars);
            this.Controls.Add(this.trackBar_Cars);
            this.Controls.Add(this.label_status);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Lego Racers 2 - Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Car4)).EndInit();
            this.groupBox_Cars.ResumeLayout(false);
            this.groupBox_Cars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Laps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TrackBar trackBar_Cars;
        private System.Windows.Forms.Label label_Cars;
        private System.Windows.Forms.CheckBox checkBox_Cars;
        private System.Windows.Forms.Timer timer_Write;
        private System.Windows.Forms.Timer timer_Process;
        private System.Windows.Forms.CheckBox checkBox_Special;
        private System.Windows.Forms.TrackBar trackBar_Car1;
        private System.Windows.Forms.Label label_Special_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Special_2;
        private System.Windows.Forms.Label label_Special_3;
        private System.Windows.Forms.Label label_Special_4;
        private System.Windows.Forms.Label label_Special_5;
        private System.Windows.Forms.Label label_Special_6;
        private System.Windows.Forms.TrackBar trackBar_Car2;
        private System.Windows.Forms.TrackBar trackBar_Car3;
        private System.Windows.Forms.TrackBar trackBar_Car5;
        private System.Windows.Forms.TrackBar trackBar_Car6;
        private System.Windows.Forms.TrackBar trackBar_Car7;
        private System.Windows.Forms.TrackBar trackBar_Car8;
        private System.Windows.Forms.TrackBar trackBar_Car4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_Special_7;
        private System.Windows.Forms.Label label_Special_8;
        private System.Windows.Forms.GroupBox groupBox_Cars;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_Laps;
        private System.Windows.Forms.CheckBox checkBox_Laps;
        private System.Windows.Forms.NumericUpDown numericUpDown_Laps;
    }
}

