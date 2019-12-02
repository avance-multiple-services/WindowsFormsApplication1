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
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing.Printing;
namespace WindowsFormsApplication1
{
    

    public partial class Extraction : Form
    {
        public Extraction()
        {
            InitializeComponent();
        }

        private void Extraction_Load(object sender, EventArgs e)
        {
           
           try
           {
               SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
               conn.Open();
               SqlDataAdapter da = new SqlDataAdapter("select * from stuck", conn);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "stuck");
                if (ds.Tables["stuck"].Rows.Count > 0)
                {

                    dataGridExt.DataSource = ds.Tables["stuck"];
                    
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

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridExt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (rec_name.Text == "")
            {
                MessageBox.Show("PLESS FILL THE RECEIVER NAME FILED");
                rec_name.Focus();
            }
            else if (stone_name.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE NAME FILED");
                stone_name.Focus();
            }
            else if (stone_size.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE SIZE FILED");
                stone_size.Focus();
            }
            else if (stone_weight_per_one.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE WEIGHT FILED");
                stone_weight_per_one.Focus();
            }
            else if (stone_weigh.Text == "")
            {
                MessageBox.Show("PLESS FILL THE TOTAL STONES WEIGHT FILED");
                stone_weigh.Focus();
            }
             else if (stone_pieces.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE PIECES FILED");
                stone_pieces.Focus();
            }
            else if (stone_prise.Text == "")
            {
                MessageBox.Show("PLESS FILL THE STONE PRISE FILED");
                stone_prise.Focus();
            }
             if (rec_name.Text != "" && stone_name.Text != "" && stone_size.Text != "" && stone_weight_per_one.Text != "" && stone_weigh.Text != "" && stone_weigh.Text != "" && stone_pieces.Text != "")
             {
                 try
                 {
                     float x, y, z, j;

                     SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                     conn.Open();
                     SqlCommand Comm1 = new SqlCommand("select * from stuck where stone_name ='" + stone_name.Text + "' and stone_weight ='" + stone_weight_per_one.Text + "' and stone_size='" + stone_size.Text + "'", conn);


                     SqlDataReader DR1 = Comm1.ExecuteReader();
                     if (DR1.Read())
                     {
                         //reading name and size and weight and peices if the data it's same it will apdate
                         string sname = DR1.GetValue(1).ToString();
                         string ssize = DR1.GetValue(2).ToString();
                         string swright = DR1.GetValue(3).ToString();
                         string stuck_peices = DR1.GetValue(4).ToString();
                         string total_weight = DR1.GetValue(5).ToString();
                         string stuck_weight = stone_weigh.Text;
                         string Ext_peices = stone_pieces.Text;
                         x = float.Parse(stuck_peices);
                         y = float.Parse(Ext_peices);
                         z = float.Parse(total_weight);
                         j = float.Parse(stuck_weight);
                         float result = x - y;
                         float result2 = z - j;

                         Math.Round(result2, 3);

                         if (x >= y && z >= j)
                         {
                             DR1.Close();
                             SqlCommand cmd = new SqlCommand("UPDATE stuck SET stone_total_pieces=@stone_total_pieces,stone_total_weight=@stone_total_weight" + " WHERE stone_name ='" + sname + "'and stone_weight ='" + swright + "' and stone_size='" + ssize + "'", conn);
                             {
                                 cmd.Parameters.AddWithValue("@stone_total_pieces", result);
                                 cmd.Parameters.AddWithValue("@stone_total_weight", result2);
                                 cmd.ExecuteNonQuery();
                                // MessageBox.Show("UPDATED");
                             }
                             string query = "insert into extract (date,receiver_name,stone_name,stone_size,stone_weight,stone_total_weight,stone_total_pieces,stone_prise) values (@date,@receiver_name,@stone_name,@stone_size,@stone_weight,@stone_total_weight,@stone_total_pieces,@stone_prise)";
                             SqlCommand cmd2 = new SqlCommand(query, conn);                  
                             //cmd.Parameters.AddWithValue("@date", this.date.Text);
                             cmd2.Parameters.AddWithValue("@date",this.dateEx.Text );
                             cmd2.Parameters.AddWithValue("@receiver_name",rec_name.Text );
                             cmd2.Parameters.AddWithValue("@stone_name",stone_name.Text);
                             cmd2.Parameters.AddWithValue("@stone_size", stone_size.Text);
                             cmd2.Parameters.AddWithValue("@stone_weight",stone_weight_per_one.Text);
                             cmd2.Parameters.AddWithValue("@stone_total_weight", stone_weigh.Text );
                             cmd2.Parameters.AddWithValue("@stone_total_pieces", stone_pieces.Text);
                             cmd2.Parameters.AddWithValue("@stone_prise",stone_pieces.Text);
                             cmd2.ExecuteNonQuery();                          
                             MessageBox.Show("PROCESSOR DONE");
                             SqlDataAdapter da = new SqlDataAdapter("select * from extract", conn);
                             SqlCommandBuilder cm = new SqlCommandBuilder(da);
                             DataSet ds = new DataSet();
                             da.Fill(ds, "extract");
                             if (ds.Tables["extract"].Rows.Count > 0)
                             {

                                 dataGridExt.DataSource = ds.Tables["extract"];

                             }

                         }
                         else
                         {
                             MessageBox.Show("THERE IS NO ENUGH AMOUNT FROME THIS STONE");
                         }
                     }
                     else
                     {
                         MessageBox.Show("STONE DETAILS ISN'T EXISTE");
                     }

                     conn.Close();
                 }


                 catch (Exception ex)
                 {
                     MessageBox.Show("ERORR:" + ex.ToString());

                 }
             }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"  Data Source=HP-PC;Initial Catalog=Stones;User ID=sa;Password=123aA123;Integrated Security=True");
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from extract", conn);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "extract");
                if (ds.Tables["extract"].Rows.Count > 0)
                {

                    dataGridExt.DataSource = ds.Tables["extract"];

                }
                  conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
           PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "pill.docx";
                printDocument1.Print();
            }
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Document document = new Document();
            document.LoadFromFile("C:\\Users\\HP\\Desktop\\pill.docx");
            
            //get strings to replace  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }

            PrintDialog dialog = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            printPrvDlg.ShowDialog();

            dialog.AllowPrintToFile = true;
            dialog.AllowCurrentPage = true;
            dialog.AllowSomePages = true;
            dialog.UseEXDialog = true;
            document.PrintDialog = dialog;
            PrintDocument printDoc = document.PrintDocument;           
            printPrvDlg.Document = printDoc;            
            //Background printing 
            printDoc.Print();
            //Interaction printing 
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                printDoc.Print();
            }         
           
             MessageBox.Show("All tasks are finished.", "doc processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Document document = new Document();
            document.LoadFromFile("C:\\Users\\HP\\Desktop\\pill.docx");
            
            //get strings to replace  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }

           // PrintDialog dialog = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();         
            PrintDocument printDoc = document.PrintDocument;                      
            printPrvDlg.Document = printDoc;
            printPrvDlg.ShowDialog();           
            document.Close();

        }
        

        Dictionary<string, string> GetReplaceDictionary()
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();
            replaceDict.Add("#DATE#", this.dateEx.Text);
            replaceDict.Add("#RECEIVER#", rec_name.Text);
            replaceDict.Add("#STONENAME#", stone_name.Text);
            replaceDict.Add("#SIZE#", stone_size.Text);
            replaceDict.Add("#WEIGHT#", stone_weight_per_one.Text);
            replaceDict.Add("#TWEIGHT#",stone_weigh.Text);
            replaceDict.Add("#PIECES#", stone_pieces.Text);
            replaceDict.Add("#PRISE#", stone_prise.Text);
            

            return replaceDict;
        }  
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    }
}
