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
    
    public partial class Insert : Form
    {
       
        SqlConnection cnn = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123");
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                conn.Open();
                // FOR DISPLAY IN THE DATAGRIDE VIEW 
                SqlDataAdapter da = new SqlDataAdapter("select * from enter", conn);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "enter");
                if (ds.Tables["enter"].Rows.Count >= 0)
                {

                    displayInsert.DataSource = ds.Tables["enter"];

                }
                else
                    MessageBox.Show("No Deitels");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
       
        

        private void Ssize_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        void insert_quantity()
        {
                try
            {
                float x, y, z, j;
                SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                conn.Open();
                SqlCommand Comm1 = new SqlCommand("select * from stuck where stone_name='" + Sname.Text + "' and stone_size='" + Ssize.Text + "' and stone_weight='" + stone_weight_per_one.Text + "'", conn);
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                    //reading name and size and weight and peices and if the data it's same it will apdate
                    string sname = DR1.GetValue(1).ToString();
                    string ssize = DR1.GetValue(2).ToString();
                    string swright = DR1.GetValue(3).ToString();
                    string ins_peices = DR1.GetValue(4).ToString();
                    string total_weight = DR1.GetValue(5).ToString();
                    string stuck_weight = stoneTotalWeight.Text;
                    string stuck_peices = stoneTotalPieces.Text;
                    x = float.Parse(ins_peices);
                    y = float.Parse(stuck_peices);
                    z = float.Parse(total_weight);
                    j = float.Parse(stuck_weight);
                    float result = x + y;
                    float result2 = z + j;
                    
                    Math.Round(result2, 3);
                    if (sname == Sname.Text && ssize == Ssize.Text && swright == stone_weight_per_one.Text)
                    {  
                       DR1.Close();
                       SqlCommand cmd = new SqlCommand("UPDATE stuck SET stone_total_pieces=@stone_total_pieces,stone_total_weight=@stone_total_weight" + " WHERE stone_name ='" + sname + "'and stone_weight ='" + swright + "' and stone_size='" + ssize + "'", conn);
                        {
                            cmd.Parameters.AddWithValue("@stone_total_pieces", result);
                            cmd.Parameters.AddWithValue("@stone_total_weight", result2);
                            cmd.ExecuteNonQuery();
                        }

                        SqlCommand cmd2 = new SqlCommand("UPDATE full_stock SET stone_total_pieces=@stone_total_pieces,stone_total_weight=@stone_total_weight" + " WHERE stone_name ='" + sname + "'and stone_weight ='" + swright + "' and stone_size='" + ssize + "'", conn);
                        {
                            cmd2.Parameters.AddWithValue("@stone_total_pieces", result);
                            cmd2.Parameters.AddWithValue("@stone_total_weight", result2);                           
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("STONE RECORD UPDATED IN STONE STOCK");                           
                        }
                    }
                    else
                    {
                        DR1.Close();
                        string query = "insert into stuck (resource_name,stone_name,stone_size,stone_weight,stone_total_pieces,stone_total_weight,stone_prise) values (@resource_name,@stone_name,@stone_size,@stone_weight,@stone_total_pieces,@stone_total_weight,@stone_prise)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        string query2 = "insert into full_stock (resource_name,stone_name,stone_size,stone_weight,stone_total_pieces,stone_total_weight,stone_prise) values (@resource_name,@stone_name,@stone_size,@stone_weight,@stone_total_pieces,@stone_total_weight,@stone_prise)";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        //cmd.Parameters.AddWithValue("@date", this.date.Text);
                        cmd.Parameters.AddWithValue("@resource_name", Rname.Text);
                        cmd.Parameters.AddWithValue("@stone_name", Sname.Text);
                        cmd.Parameters.AddWithValue("@stone_size", Ssize.Text);
                        cmd.Parameters.AddWithValue("@stone_weight", stone_weight_per_one.Text);
                        cmd.Parameters.AddWithValue("@stone_total_pieces", stoneTotalPieces.Text);
                        cmd.Parameters.AddWithValue("@stone_total_weight", stoneTotalWeight.Text);
                        cmd.Parameters.AddWithValue("@stone_prise", Sprise.Text);
                        cmd2.Parameters.AddWithValue("@resource_name", Rname.Text);
                        cmd2.Parameters.AddWithValue("@stone_name", Sname.Text);
                        cmd2.Parameters.AddWithValue("@stone_size", Ssize.Text);
                        cmd2.Parameters.AddWithValue("@stone_weight", stone_weight_per_one.Text);
                        cmd2.Parameters.AddWithValue("@stone_total_pieces", stoneTotalPieces.Text);
                        cmd2.Parameters.AddWithValue("@stone_total_weight", stoneTotalWeight.Text);
                        cmd2.Parameters.AddWithValue("@stone_prise", Sprise.Text);
                        //cmd.Parameters.AddWithValue("@stones_wait", stoneallw.Text);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("STONE RECORD ENTERED");                      
                    }
                }
                else
                {
                    DR1.Close();
                    string query = "insert into stuck (resource_name,stone_name,stone_size,stone_weight,stone_total_pieces,stone_total_weight,stone_prise) values (@resource_name,@stone_name,@stone_size,@stone_weight,@stone_total_pieces,@stone_total_weight,@stone_prise)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    string query2 = "insert into full_stock (resource_name,stone_name,stone_size,stone_weight,stone_total_pieces,stone_total_weight,stone_prise) values (@resource_name,@stone_name,@stone_size,@stone_weight,@stone_total_pieces,@stone_total_weight,@stone_prise)";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    //cmd.Parameters.AddWithValue("@date", this.date.Text);
                    cmd.Parameters.AddWithValue("@resource_name", Rname.Text);
                    cmd.Parameters.AddWithValue("@stone_name", Sname.Text);
                    cmd.Parameters.AddWithValue("@stone_size", Ssize.Text);
                    cmd.Parameters.AddWithValue("@stone_weight", stone_weight_per_one.Text);
                    cmd.Parameters.AddWithValue("@stone_total_pieces", stoneTotalPieces.Text);
                    cmd.Parameters.AddWithValue("@stone_total_weight", stoneTotalWeight.Text);
                    cmd.Parameters.AddWithValue("@stone_prise", Sprise.Text);
                    cmd2.Parameters.AddWithValue("@resource_name", Rname.Text);
                    cmd2.Parameters.AddWithValue("@stone_name", Sname.Text);
                    cmd2.Parameters.AddWithValue("@stone_size", Ssize.Text);
                    cmd2.Parameters.AddWithValue("@stone_weight", stone_weight_per_one.Text);
                    cmd2.Parameters.AddWithValue("@stone_total_pieces", stoneTotalPieces.Text);
                    cmd2.Parameters.AddWithValue("@stone_total_weight", stoneTotalWeight.Text);
                    cmd2.Parameters.AddWithValue("@stone_prise", Sprise.Text);
                    //cmd.Parameters.AddWithValue("@stones_wait", stoneallw.Text);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("STONE RECORD ENTERED");                   
                }

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
       }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                conn.Open();
                string sqlStatement = "DELETE FROM extract";
                SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
        }

        private void Rname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Rname.Text == "")
            {
                MessageBox.Show("PLESS FILL THE RESSOURS NAME FILED");
                Rname.Focus();
            }
            else if (Sname.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE NAME FILED");
                Sname.Focus();
            }
            else if (Ssize.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE SIZE FILED");
                Ssize.Focus();
            }
            else if (stoneTotalPieces.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE WEIGHT FILED");
                stoneTotalPieces.Focus();
            }
            else if (stoneTotalWeight.Text == "")
            {
                MessageBox.Show("PLESS FILL THE TOTAL STONES WEIGHT FILED");
                stoneTotalWeight.Focus();
            }
            else if (stone_weight_per_one.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE PRISE FILED");
                stone_weight_per_one.Focus();
            }
            if (Rname.Text != "" && Sname.Text != "" && Ssize.Text != "" && stoneTotalPieces.Text != "" && stoneTotalWeight.Text != "" && stone_weight_per_one.Text != "")
            {
                try
                {

                    SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                    conn.Open();
                    string insert_query = "insert into enter (date,resource_name,stone_name,stone_size,stone_weight,stone_total_pieces,stone_total_weight,stone_prise) values (@date,@resource_name,@stone_name,@stone_size,@stone_weight,@stone_total_pieces,@stone_total_weight,@stone_prise)";
                    SqlCommand cmd = new SqlCommand(insert_query, conn);
                    cmd.Parameters.AddWithValue("@date", this.date.Text);
                    cmd.Parameters.AddWithValue("@resource_name", Rname.Text);
                    cmd.Parameters.AddWithValue("@stone_name", Sname.Text);
                    cmd.Parameters.AddWithValue("@stone_size", Ssize.Text);
                    cmd.Parameters.AddWithValue("@stone_weight", stone_weight_per_one.Text);
                    cmd.Parameters.AddWithValue("@stone_total_pieces", stoneTotalPieces.Text);
                    cmd.Parameters.AddWithValue("@stone_total_weight", stoneTotalWeight.Text);
                    cmd.Parameters.AddWithValue("@stone_prise", Sprise.Text);
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("STONE RECORD ENTERED");
                    insert_quantity();
                    // FOR DISPLAY IN THE DATAGRIDE VIEW 
                    SqlDataAdapter da = new SqlDataAdapter("select * from enter", conn);
                    SqlCommandBuilder cm = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "enter");
                    if (ds.Tables["enter"].Rows.Count > 0)
                    {

                        displayInsert.DataSource = ds.Tables["enter"];

                    }

                    else
                        MessageBox.Show("No Deitels");

                    conn.Close();
                    Rname.Clear();
                    Sname.Clear();
                    Ssize.Clear();
                    stone_weight_per_one.Clear();
                    stoneTotalPieces.Clear();
                    stoneTotalWeight.Clear();
                    Sprise.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERORR:" + ex.ToString());

                }
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
