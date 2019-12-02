namespace WindowsFormsApplication1
{
    partial class Extraction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extraction));
            this.dateEx = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rec_name = new System.Windows.Forms.TextBox();
            this.stone_name = new System.Windows.Forms.ComboBox();
            this.stone_size = new System.Windows.Forms.TextBox();
            this.stone_weight_per_one = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.stone_weigh = new System.Windows.Forms.TextBox();
            this.stone_pieces = new System.Windows.Forms.TextBox();
            this.dataGridExt = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stone_prise = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button4 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEx
            // 
            this.dateEx.CustomFormat = "yyyy-MM-dd";
            this.dateEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEx.Location = new System.Drawing.Point(131, 41);
            this.dateEx.Name = "dateEx";
            this.dateEx.Size = new System.Drawing.Size(104, 20);
            this.dateEx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "RECEIVER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "STONE NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(308, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "STONE WEIGHT PER ONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(308, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "STONE SIZE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(308, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "TOTAL STONE WEIGHT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(615, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "STONE PIECES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(615, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "STONE PRISE";
            // 
            // rec_name
            // 
            this.rec_name.Location = new System.Drawing.Point(124, 86);
            this.rec_name.Name = "rec_name";
            this.rec_name.Size = new System.Drawing.Size(170, 20);
            this.rec_name.TabIndex = 38;
            // 
            // stone_name
            // 
            this.stone_name.FormattingEnabled = true;
            this.stone_name.Location = new System.Drawing.Point(126, 126);
            this.stone_name.Name = "stone_name";
            this.stone_name.Size = new System.Drawing.Size(91, 21);
            this.stone_name.TabIndex = 39;
            // 
            // stone_size
            // 
            this.stone_size.Location = new System.Drawing.Point(410, 45);
            this.stone_size.Name = "stone_size";
            this.stone_size.Size = new System.Drawing.Size(95, 20);
            this.stone_size.TabIndex = 43;
            // 
            // stone_weight_per_one
            // 
            this.stone_weight_per_one.Location = new System.Drawing.Point(511, 87);
            this.stone_weight_per_one.Name = "stone_weight_per_one";
            this.stone_weight_per_one.Size = new System.Drawing.Size(95, 20);
            this.stone_weight_per_one.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(622, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 31);
            this.button2.TabIndex = 45;
            this.button2.Text = "EXTRACT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(748, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 31);
            this.button5.TabIndex = 46;
            this.button5.Text = "PRITN";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // stone_weigh
            // 
            this.stone_weigh.Location = new System.Drawing.Point(511, 128);
            this.stone_weigh.Name = "stone_weigh";
            this.stone_weigh.Size = new System.Drawing.Size(95, 20);
            this.stone_weigh.TabIndex = 50;
            // 
            // stone_pieces
            // 
            this.stone_pieces.Location = new System.Drawing.Point(738, 38);
            this.stone_pieces.Name = "stone_pieces";
            this.stone_pieces.Size = new System.Drawing.Size(95, 20);
            this.stone_pieces.TabIndex = 51;
            // 
            // dataGridExt
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridExt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridExt.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridExt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridExt.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridExt.Location = new System.Drawing.Point(5, 207);
            this.dataGridExt.Name = "dataGridExt";
            this.dataGridExt.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExt.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dataGridExt.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridExt.Size = new System.Drawing.Size(973, 234);
            this.dataGridExt.TabIndex = 53;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.printer;
            this.pictureBox4.Location = new System.Drawing.Point(752, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.output;
            this.pictureBox2.Location = new System.Drawing.Point(624, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.backward;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(923, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 39);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // stone_prise
            // 
            this.stone_prise.Location = new System.Drawing.Point(738, 90);
            this.stone_prise.Name = "stone_prise";
            this.stone_prise.Size = new System.Drawing.Size(95, 20);
            this.stone_prise.TabIndex = 54;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.button3.Location = new System.Drawing.Point(624, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 31);
            this.button3.TabIndex = 55;
            this.button3.Text = "DISPLA EXTRACTION DATA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 56;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Extraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stone_prise);
            this.Controls.Add(this.dataGridExt);
            this.Controls.Add(this.stone_pieces);
            this.Controls.Add(this.stone_weigh);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stone_weight_per_one);
            this.Controls.Add(this.stone_size);
            this.Controls.Add(this.stone_name);
            this.Controls.Add(this.rec_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEx);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(230, 160);
            this.Name = "Extraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Extraction";
            this.Load += new System.EventHandler(this.Extraction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rec_name;
        private System.Windows.Forms.ComboBox stone_name;
        private System.Windows.Forms.TextBox stone_size;
        private System.Windows.Forms.TextBox stone_weight_per_one;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox stone_weigh;
        private System.Windows.Forms.TextBox stone_pieces;
        private System.Windows.Forms.DataGridView dataGridExt;
        private System.Windows.Forms.TextBox stone_prise;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}