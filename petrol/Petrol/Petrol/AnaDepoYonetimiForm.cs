using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class AnaDepoYonetimiForm : Form
    {
        public AnaDepoYonetimiForm()
        {
            InitializeComponent();
        }

 
        private void LoadDataFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM AnaRezerv";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewAnaRezerv.DataSource = table;
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRezervID.Text))
            {
                MessageBox.Show("Lütfen bir RezervID girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "UPDATE AnaRezerv SET YakitTuru = @YakitTuru, Miktar = @Miktar, MinimumSeviye = @MinimumSeviye, SonGuncellemeTarihi = @SonGuncellemeTarihi WHERE RezervID = @RezervID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RezervID", txtRezervID.Text);
                    command.Parameters.AddWithValue("@YakitTuru", txtYakitTuru.Text);
                    command.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                    command.Parameters.AddWithValue("@MinimumSeviye", txtMinimumSeviye.Text);
                    command.Parameters.AddWithValue("@SonGuncellemeTarihi", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

       
            LoadDataFromDatabase();
            MessageBox.Show("Veri başarıyla güncellendi!");
        }

   
        private void btnYeniYakitEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "INSERT INTO AnaRezerv (YakitTuru, Miktar, MinimumSeviye, SonGuncellemeTarihi) VALUES (@YakitTuru, @Miktar, @MinimumSeviye, @SonGuncellemeTarihi)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@YakitTuru", txtYakitTuru.Text);
                    command.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                    command.Parameters.AddWithValue("@MinimumSeviye", txtMinimumSeviye.Text);
                    command.Parameters.AddWithValue("@SonGuncellemeTarihi", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

   
            LoadDataFromDatabase();
            MessageBox.Show("Yeni yakıt türü başarıyla eklendi!");
        }

 
        private void AnaDepoYonetimiForm_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

    
        private void btnListele_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRezervID.Text))
            {
                MessageBox.Show("Lütfen bir RezervID girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM AnaRezerv WHERE RezervID = @RezervID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RezervID", txtRezervID.Text);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtYakitTuru.Text = reader["YakitTuru"].ToString();
                            txtMiktar.Text = reader["Miktar"].ToString();
                            txtMinimumSeviye.Text = reader["MinimumSeviye"].ToString();
                            txtSonGuncellemeTarihi.Text = reader["SonGuncellemeTarihi"].ToString();

                   
                            int minimumSeviye = Convert.ToInt32(reader["MinimumSeviye"]);
                            int mevcutMiktar = Convert.ToInt32(reader["Miktar"]);

                            if (mevcutMiktar < minimumSeviye)
                            {
                                lblDurum.Text = "Uyarı: Minimum seviyenin altı!";
                                lblDurum.ForeColor = System.Drawing.Color.Red;
                            }
                            else
                            {
                                lblDurum.Text = "Normal";
                                lblDurum.ForeColor = System.Drawing.Color.Green;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu RezervID'ye sahip bir kayıt bulunamadı!");
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            if (string.IsNullOrEmpty(txtRezervID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz yakıtın RezervID'sini girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "DELETE FROM AnaRezerv WHERE RezervID = @RezervID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RezervID", txtRezervID.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Yakıt başarıyla silindi!");
                    }
                    else
                    {
                        MessageBox.Show("Silmek istediğiniz RezervID bulunamadı!");
                    }
                }
            }

   
            LoadDataFromDatabase();
        }

    }
}
