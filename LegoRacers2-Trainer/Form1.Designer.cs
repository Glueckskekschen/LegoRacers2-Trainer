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
            this.label_status = new System.Windows.Forms.Label();
            this.bn_Start = new System.Windows.Forms.Button();
            this.trackBar_Cars = new System.Windows.Forms.TrackBar();
            this.label_Cars = new System.Windows.Forms.Label();
            this.bn_Stop = new System.Windows.Forms.Button();
            this.checkBox_Cars = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(156, 13);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "Wait for the Game .. Press Start";
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(15, 25);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(75, 23);
            this.bn_Start.TabIndex = 1;
            this.bn_Start.Text = "Start";
            this.bn_Start.UseVisualStyleBackColor = true;
            this.bn_Start.Click += new System.EventHandler(this.bn_Start_Click);
            // 
            // trackBar_Cars
            // 
            this.trackBar_Cars.Location = new System.Drawing.Point(58, 54);
            this.trackBar_Cars.Maximum = 8;
            this.trackBar_Cars.Minimum = 1;
            this.trackBar_Cars.Name = "trackBar_Cars";
            this.trackBar_Cars.Size = new System.Drawing.Size(166, 45);
            this.trackBar_Cars.TabIndex = 2;
            this.trackBar_Cars.Value = 1;
            this.trackBar_Cars.Scroll += new System.EventHandler(this.trackBar_Cars_Scroll);
            // 
            // label_Cars
            // 
            this.label_Cars.AutoSize = true;
            this.label_Cars.Location = new System.Drawing.Point(12, 63);
            this.label_Cars.Name = "label_Cars";
            this.label_Cars.Size = new System.Drawing.Size(40, 13);
            this.label_Cars.TabIndex = 3;
            this.label_Cars.Text = "Cars: 1";
            // 
            // bn_Stop
            // 
            this.bn_Stop.Location = new System.Drawing.Point(96, 25);
            this.bn_Stop.Name = "bn_Stop";
            this.bn_Stop.Size = new System.Drawing.Size(75, 23);
            this.bn_Stop.TabIndex = 4;
            this.bn_Stop.Text = "Stop";
            this.bn_Stop.UseVisualStyleBackColor = true;
            this.bn_Stop.Click += new System.EventHandler(this.bn_Stop_Click);
            // 
            // checkBox_Cars
            // 
            this.checkBox_Cars.AutoSize = true;
            this.checkBox_Cars.Location = new System.Drawing.Point(239, 63);
            this.checkBox_Cars.Name = "checkBox_Cars";
            this.checkBox_Cars.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Cars.TabIndex = 5;
            this.checkBox_Cars.Text = "Select";
            this.checkBox_Cars.UseVisualStyleBackColor = true;
            this.checkBox_Cars.CheckedChanged += new System.EventHandler(this.checkBox_Cars_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 429);
            this.Controls.Add(this.checkBox_Cars);
            this.Controls.Add(this.bn_Stop);
            this.Controls.Add(this.label_Cars);
            this.Controls.Add(this.trackBar_Cars);
            this.Controls.Add(this.bn_Start);
            this.Controls.Add(this.label_status);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button bn_Start;
        private System.Windows.Forms.TrackBar trackBar_Cars;
        private System.Windows.Forms.Label label_Cars;
        private System.Windows.Forms.Button bn_Stop;
        private System.Windows.Forms.CheckBox checkBox_Cars;
    }
}

