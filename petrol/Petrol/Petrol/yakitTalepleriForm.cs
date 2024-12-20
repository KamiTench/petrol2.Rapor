using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class yakitTalepleriForm : Form
    {
        public yakitTalepleriForm()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False";

        private void yakitTalepleriForm_Load(object sender, EventArgs e)
        {
            this.yakitTalepleriTableAdapter.Fill(this.petrolSatisSistemiDataSet5.YakitTalepleri);
            
        }

     
        private void listelebuton_Click(object sender, EventArgs e)
        {
            int taleplerID;
            if (int.TryParse(talepidtxt.Text, out taleplerID))
            {
              
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT YakitTuru, Miktar, SubeID, Tarih FROM YakitTalepleri WHERE TaleplerID = @TaleplerID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@TaleplerID", taleplerID);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

              
                    if (dt.Rows.Count > 0)
                    {
                     
                        yakıttürütxt.Text = dt.Rows[0]["YakitTuru"].ToString();
                        textBoxMiktar.Text = dt.Rows[0]["Miktar"].ToString();
                        şubetxt.Text = dt.Rows[0]["SubeID"].ToString();
                        tarihtxt.Text = dt.Rows[0]["Tarih"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Talep ID bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz Talep ID.");
            }
        }

       
        private void Gönderbutton_Click(object sender, EventArgs e)
        {
            int taleplerID;
            decimal miktar;

            if (!int.TryParse(talepidtxt.Text, out taleplerID))
            {
                MessageBox.Show("Geçerli bir Talep ID giriniz.");
                return;
            }

            if (!decimal.TryParse(textBoxMiktar.Text, out miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir miktar giriniz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

             
                string updateQuery = "UPDATE AnaRezerv SET Miktar = Miktar - @Miktar WHERE YakitTuru = (SELECT YakitTuru FROM YakitTalepleri WHERE TaleplerID = @TaleplerID)";
                SqlCommand cmd1 = new SqlCommand(updateQuery, conn);
                cmd1.Parameters.AddWithValue("@Miktar", miktar);
                cmd1.Parameters.AddWithValue("@TaleplerID", taleplerID);
                cmd1.ExecuteNonQuery();

               
                string statusUpdateQuery = "UPDATE YakitTalepleri SET Durum = 'Onaylandı' WHERE TaleplerID = @TaleplerID";
                SqlCommand cmd2 = new SqlCommand(statusUpdateQuery, conn);
                cmd2.Parameters.AddWithValue("@TaleplerID", taleplerID);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Talep onaylandı.");
                DataGridViewYenile();
            }
        }

        private void Reddetbutton_Click(object sender, EventArgs e)
        {
            int taleplerID;

            if (!int.TryParse(talepidtxt.Text, out taleplerID))
            {
                MessageBox.Show("Geçerli bir Talep ID giriniz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

              
                string updateQuery = "UPDATE YakitTalepleri SET Durum = 'Reddedildi' WHERE TaleplerID = @TaleplerID";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@TaleplerID", taleplerID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Talep reddedildi.");
                DataGridViewYenile(); 
            }
        }

        private void TalepSilButton_Click(object sender, EventArgs e)
        {
            int taleplerID;

            if (!int.TryParse(talepidtxt.Text, out taleplerID))
            {
                MessageBox.Show("Geçerli bir Talep ID giriniz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

           
                string deleteQuery = "DELETE FROM YakitTalepleri WHERE TaleplerID = @TaleplerID";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@TaleplerID", taleplerID);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Talep silindi.");
                }
                else
                {
                    MessageBox.Show("Talep bulunamadı.");
                }

                DataGridViewYenile(); 
            }
        }

       
        private void DataGridViewYenile()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM YakitTalepleri";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewTalepler.DataSource = dt; 
            }
        }

    }
}
