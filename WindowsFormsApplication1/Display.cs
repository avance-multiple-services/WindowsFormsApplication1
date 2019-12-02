using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Display : Form
    {
        SqlDataAdapter da;
        SqlCommandBuilder cm;
        public Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
            
            try
            {
                conn.Open();
                if (radioButton1.Checked == true)
                {
                    
                    da = new SqlDataAdapter("select * from enter where stone_name ='" + sname.Text + "' and stone_size= '" + ssize.Text + "' and stone_weight= '" + sweight.Text + "' ", conn);
                    cm = new SqlCommandBuilder(da);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    if (ds.Rows.Count > 0)
                    {

                        dataGridView1.DataSource = ds;

                    }
                    else
                    {
                        MessageBox.Show("No Deitels");
                        da.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    
                }
                else if (radioButton2.Checked == true)
                {
                    
                    da = new SqlDataAdapter("select * from stuck where stone_name ='" + sname.Text + "' and stone_size= '" + ssize.Text + "' and stone_weight= '" + sweight.Text + "' ", conn);
                    cm = new SqlCommandBuilder(da);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    if (ds.Rows.Count > 0)
                    {

                        dataGridView1.DataSource = ds;

                    }
                    else
                    {
                        MessageBox.Show("No Deitels");
                        da.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    
                }
                conn.Close();
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }

        }

        private void Display_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                conn.Open();

                SqlDataReader dr;

                //Check whether the Drop Down has existing items. If YES, empty it.
                if (sname.Items.Count > 0)
                    sname.Items.Clear();

                SqlCommand cmd = new SqlCommand("select stone_name from stuck", conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                    sname.Items.Add(dr[0].ToString());

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
         
            try
            {
                conn.Open();
                if (radioButton1.Checked == true)
                {
                    
                SqlDataAdapter da = new SqlDataAdapter("select * from enter where date Between '" + this.From.Text.ToString() + "' and '" + this.To.Text.ToString() + "'", conn);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "enter");
                if (ds.Tables["enter"].Rows.Count > 0)
                {

                    dataGridView1.DataSource = ds.Tables["enter"];

                }
                else
                {
                    MessageBox.Show("No Deitels");
                }
              }
                else if (radioButton2.Checked == true)
                {
                     da = new SqlDataAdapter("select * from stuck ", conn);
                     cm = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "stuck");
                    if (ds.Tables["stuck"].Rows.Count > 0)
                    {

                        dataGridView1.DataSource = ds.Tables["stuck"];

                    }
                    else
                    {
                        MessageBox.Show("No Deitels");
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
         }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = true;
            }
            else
            {
                radioButton2.Checked = true;
                panel2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

           
    }
}
