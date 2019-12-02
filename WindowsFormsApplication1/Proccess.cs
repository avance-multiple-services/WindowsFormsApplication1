using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Proccess : Form
    {
        public Proccess()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Proccess_Load(object sender, EventArgs e)
        {
          
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Extraction ext = new Extraction();
            ext.ShowDialog();

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculation cal = new Calculation();
            cal.ShowDialog();
        }
    }
}
