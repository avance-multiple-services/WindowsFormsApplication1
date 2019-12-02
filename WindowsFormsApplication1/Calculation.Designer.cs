namespace WindowsFormsApplication1
{
    partial class Calculation
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stone_weight = new System.Windows.Forms.TextBox();
            this.stone_size = new System.Windows.Forms.TextBox();
            this.stone_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.day = new System.Windows.Forms.RadioButton();
            this.year = new System.Windows.Forms.RadioButton();
            this.month = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(458, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "DATE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.process;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.stone_weight);
            this.panel1.Controls.Add(this.stone_size);
            this.panel1.Controls.Add(this.stone_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(169, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 52);
            this.panel1.TabIndex = 28;
            // 
            // stone_weight
            // 
            this.stone_weight.Location = new System.Drawing.Point(569, 15);
            this.stone_weight.Name = "stone_weight";
            this.stone_weight.Size = new System.Drawing.Size(64, 20);
            this.stone_weight.TabIndex = 38;
            // 
            // stone_size
            // 
            this.stone_size.Location = new System.Drawing.Point(341, 15);
            this.stone_size.Name = "stone_size";
            this.stone_size.Size = new System.Drawing.Size(100, 20);
            this.stone_size.TabIndex = 37;
            // 
            // stone_name
            // 
            this.stone_name.FormattingEnabled = true;
            this.stone_name.Location = new System.Drawing.Point(116, 14);
            this.stone_name.Name = "stone_name";
            this.stone_name.Size = new System.Drawing.Size(121, 21);
            this.stone_name.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(445, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "STONE WEIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "STONE SIZE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "STONE NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(169, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 1);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.process;
            this.pictureBox2.Location = new System.Drawing.Point(748, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.button1_Click);
            // 
            // From
            // 
            this.From.CustomFormat = "yyyy-MM-dd";
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(510, 120);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(98, 20);
            this.From.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(612, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "TO";
            // 
            // To
            // 
            this.To.CustomFormat = "yyyy-MM-dd";
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(644, 120);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(98, 20);
            this.To.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.backward;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(923, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 39);
            this.button2.TabIndex = 50;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.day);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.month);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(178, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 36);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choose the type";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(188, 15);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(54, 17);
            this.day.TabIndex = 54;
            this.day.TabStop = true;
            this.day.Text = "DAILY";
            this.day.UseVisualStyleBackColor = true;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(107, 15);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(62, 17);
            this.year.TabIndex = 53;
            this.year.TabStop = true;
            this.year.Text = "YEARLY";
            this.year.UseVisualStyleBackColor = true;
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(7, 16);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(72, 17);
            this.month.TabIndex = 52;
            this.month.TabStop = true;
            this.month.Text = "MONTHLY";
            this.month.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 260);
            this.dataGridView1.TabIndex = 52;
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.From);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(230, 160);
            this.Name = "Calculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.Calculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton year;
        private System.Windows.Forms.RadioButton month;
        private System.Windows.Forms.TextBox stone_weight;
        private System.Windows.Forms.TextBox stone_size;
        private System.Windows.Forms.ComboBox stone_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton day;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}