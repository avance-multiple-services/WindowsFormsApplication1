namespace WindowsFormsApplication1
{
    partial class Insert
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
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Rname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.TextBox();
            this.Ssize = new System.Windows.Forms.TextBox();
            this.stoneTotalPieces = new System.Windows.Forms.TextBox();
            this.stoneTotalWeight = new System.Windows.Forms.TextBox();
            this.stone_weight_per_one = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sprise = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.displayInsert = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATE";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(363, 25);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(115, 20);
            this.date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESOURCE NAME";
            // 
            // Rname
            // 
            this.Rname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Rname.Location = new System.Drawing.Point(363, 61);
            this.Rname.Name = "Rname";
            this.Rname.Size = new System.Drawing.Size(198, 20);
            this.Rname.TabIndex = 4;
            this.Rname.TextChanged += new System.EventHandler(this.Rname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "STONE NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(179, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL STONE PIECES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "STONE SIZE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.cvd_dimonds_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(568, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOTAL STONE WEIGHT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(553, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "STONE WEIGHT PER ONE";
            // 
            // Sname
            // 
            this.Sname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Sname.Location = new System.Drawing.Point(363, 107);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(115, 20);
            this.Sname.TabIndex = 19;
            // 
            // Ssize
            // 
            this.Ssize.Location = new System.Drawing.Point(363, 155);
            this.Ssize.Name = "Ssize";
            this.Ssize.Size = new System.Drawing.Size(115, 20);
            this.Ssize.TabIndex = 20;
            // 
            // stoneTotalPieces
            // 
            this.stoneTotalPieces.Location = new System.Drawing.Point(363, 193);
            this.stoneTotalPieces.Name = "stoneTotalPieces";
            this.stoneTotalPieces.Size = new System.Drawing.Size(115, 20);
            this.stoneTotalPieces.TabIndex = 21;
            // 
            // stoneTotalWeight
            // 
            this.stoneTotalWeight.Location = new System.Drawing.Point(754, 62);
            this.stoneTotalWeight.Name = "stoneTotalWeight";
            this.stoneTotalWeight.Size = new System.Drawing.Size(121, 20);
            this.stoneTotalWeight.TabIndex = 22;
            // 
            // stone_weight_per_one
            // 
            this.stone_weight_per_one.Location = new System.Drawing.Point(757, 102);
            this.stone_weight_per_one.Name = "stone_weight_per_one";
            this.stone_weight_per_one.Size = new System.Drawing.Size(121, 20);
            this.stone_weight_per_one.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(625, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "ENTER DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Sprise
            // 
            this.Sprise.Location = new System.Drawing.Point(757, 139);
            this.Sprise.Name = "Sprise";
            this.Sprise.Size = new System.Drawing.Size(121, 20);
            this.Sprise.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(605, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "STONE PRISE";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(887, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "ENTER DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // displayInsert
            // 
            this.displayInsert.BackgroundColor = System.Drawing.Color.Black;
            this.displayInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayInsert.Location = new System.Drawing.Point(159, 226);
            this.displayInsert.Name = "displayInsert";
            this.displayInsert.Size = new System.Drawing.Size(818, 217);
            this.displayInsert.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.backward;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(925, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 40);
            this.button4.TabIndex = 32;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.displayInsert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sprise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stone_weight_per_one);
            this.Controls.Add(this.stoneTotalWeight);
            this.Controls.Add(this.stoneTotalPieces);
            this.Controls.Add(this.Ssize);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(230, 160);
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.TextBox Ssize;
        private System.Windows.Forms.TextBox stoneTotalPieces;
        private System.Windows.Forms.TextBox stoneTotalWeight;
        private System.Windows.Forms.TextBox stone_weight_per_one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sprise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView displayInsert;
        private System.Windows.Forms.Button button4;
    }
}