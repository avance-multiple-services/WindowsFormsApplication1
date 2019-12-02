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
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (month.Checked == true || year.Checked == true || day.Checked == true)
            {
                try
                {
                    float x, y, z, j, k,xdr2,ydr2,zdr2,jdr2,kdr2;
                 //   string sname, ssize, swright, enter_peices, total_weight, stone_prise;
                    float sum_stone_prise = 0, sum_peices = 0, sum_total_weight = 0, sum_stone_prise2 = 0, sum_peices2 = 0, sum_total_weight2 = 0;
                    SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                    conn.Open();
                    SqlCommand Comm1 = new SqlCommand("select * from enter where date Between '" + this.From.Text.ToString() + "' and '" + this.To.Text.ToString() + "' and stone_name ='" + stone_name.Text + "' and stone_weight ='" + stone_weight.Text + "' and stone_size='" + stone_size.Text + "' ", conn);
                    SqlCommand Comm2 = new SqlCommand("select * from extract where date Between '" + this.From.Text.ToString() + "' and '" + this.To.Text.ToString() + "' and stone_name ='" + stone_name.Text + "' and stone_weight ='" + stone_weight.Text + "' and stone_size='" + stone_size.Text + "' ", conn);

                    SqlDataReader DR1 = Comm1.ExecuteReader();
                    
                    while (DR1.Read())
                    {
                        //reading name and size and weight and peices if the data it's same it will claculate
                        string sname = DR1.GetValue(2).ToString();
                        string ssize = DR1.GetValue(3).ToString();
                        string swright = DR1.GetValue(4).ToString();
                        string enter_peices = DR1.GetValue(5).ToString();
                        string total_weight = DR1.GetValue(6).ToString();
                        string stone_prise = DR1.GetValue(7).ToString();

                        x = float.Parse(ssize);   // only show
                        y = float.Parse(swright); // only show
                        z = float.Parse(enter_peices);
                        j = float.Parse(total_weight);
                        k = float.Parse(stone_prise);  //only show
                        sum_peices = sum_peices + z;
                        sum_total_weight = sum_total_weight + j;
                        sum_stone_prise = sum_stone_prise + k;
                        
                    }
                    DR1.Close();
                    SqlDataReader DR2 = Comm2.ExecuteReader();
                    while (DR2.Read())
                    {
                        //reading name and size and weight and peices if the data it's same it will claculate
                        string sname = DR2.GetValue(2).ToString();
                        string ssize = DR2.GetValue(3).ToString();
                        string swright = DR2.GetValue(4).ToString();
                        string enter_peices = DR2.GetValue(6).ToString();
                        string total_weight = DR2.GetValue(5).ToString();
                        string stone_prise = DR2.GetValue(7).ToString();

                        xdr2 = float.Parse(ssize);   // only show
                        ydr2 = float.Parse(swright); // only show
                        zdr2 = float.Parse(enter_peices);
                        jdr2 = float.Parse(total_weight);
                        kdr2 = float.Parse(stone_prise);  //only show
                        sum_peices2 = sum_peices2 + zdr2;
                        sum_total_weight2 = sum_total_weight2 + jdr2;
                        sum_stone_prise2 = sum_stone_prise2 + kdr2;
                        
                    }
                  DR2.Close();
                   
                    float result = sum_stone_prise2 - sum_stone_prise;
                    if (day.Checked == true)
                    {
                        DR1.Close();
                            DR1.Close();
                        string insert_query = "insert into Daily (date,todate,stone_name,stone_size,stone_weight,stone_total_weightIN,stone_total_weightOUT,stone_total_piecesIN,stone_total_piecesOUT,stone_total_priseIN,stone_total_priseOUT,Earning) values (@date,@todate,@stone_name,@stone_size,@stone_weight,@stone_total_weightIN,@stone_total_weightOUT,@stone_total_piecesIN,@stone_total_piecesOUT,@stone_total_priseIN,@stone_total_priseOUT,@Earning)";
                         SqlCommand cmd = new SqlCommand(insert_query, conn);
                         cmd.Parameters.AddWithValue("@date", this.From.Text);
                         cmd.Parameters.AddWithValue("@todate", this.To.Text);
                         cmd.Parameters.AddWithValue("@stone_name", stone_name.Text);
                         cmd.Parameters.AddWithValue("@stone_size", stone_size.Text);
                         cmd.Parameters.AddWithValue("@stone_weight", stone_weight.Text);
                         cmd.Parameters.AddWithValue("@stone_total_weightIN", sum_total_weight);
                         cmd.Parameters.AddWithValue("@stone_total_weightOUT", sum_total_weight2);
                         cmd.Parameters.AddWithValue("@stone_total_piecesIN", sum_peices);
                         cmd.Parameters.AddWithValue("@stone_total_piecesOUT", sum_peices2);
                         cmd.Parameters.AddWithValue("@stone_total_priseIN", sum_stone_prise);
                         cmd.Parameters.AddWithValue("@stone_total_priseOUT", sum_stone_prise2);
                         cmd.Parameters.AddWithValue("@Earning", result);
                         cmd.ExecuteNonQuery();
                         SqlDataAdapter da = new SqlDataAdapter("select * from Daily", conn);
                         SqlCommandBuilder cm = new SqlCommandBuilder(da);
                         DataSet ds = new DataSet();
                         da.Fill(ds, "Daily");
                         if (ds.Tables["Daily"].Rows.Count > 0)
                         {

                             dataGridView1.DataSource = ds.Tables["Daily"];

                         }
                        MessageBox.Show("THE PROCESOR DONE");
                    }
                    else
                    {
                        MessageBox.Show("dldkklkla;k;lklk;skdsak");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERORR:" + ex.ToString());

                }
            }
            else
            {
                MessageBox.Show("CHOOSE ONE OF THE OPTION");
            }
        }
        
        private void Calculation_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Daily", conn);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "Daily");
                if (ds.Tables["Daily"].Rows.Count > 0)
                {

                    dataGridView1.DataSource = ds.Tables["Daily"];

                }
                
                SqlDataReader dr;

                //Check whether the Drop Down has existing items. If YES, empty it.
                if (stone_name.Items.Count > 0)
                    stone_name.Items.Clear();

                SqlCommand cmd = new SqlCommand("select stone_name from stuck", conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                    stone_name.Items.Add(dr[0].ToString());

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
