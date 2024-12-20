using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class SubeYonetimiForm : Form
    {
        public SubeYonetimiForm()
        {
            InitializeComponent();
           
            LoadDataFromDatabase();
        }

 
        private void LoadDataFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM Subeler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

            
                dataGridView1.DataSource = table;
            }
        }

   
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "INSERT INTO Subeler (SubeAdi, Il, Adres, YakıtRezerv, IsletmeciFirma) VALUES (@SubeAdi, @Il, @Adres, @YakıtRezerv, @IsletmeciFirma)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeAdi", txtSubeAd.Text);
                    command.Parameters.AddWithValue("@Il", txtIl.Text);
                    command.Parameters.AddWithValue("@Adres", txtSubeAdres.Text);
                    command.Parameters.AddWithValue("@YakıtRezerv", txtYakitRezerv.Text); 
                    command.Parameters.AddWithValue("@IsletmeciFirma", txtFirmaID.Text); 

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            
            LoadDataFromDatabase();
            MessageBox.Show("Şube başarıyla eklendi!");
        }

        
        private void btnSubeDüzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubeID.Text))
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz şubenin ID'sini girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "UPDATE Subeler SET SubeAdi = @SubeAdi, Il = @Il, Adres = @Adres, YakıtRezerv = @YakıtRezerv, IsletmeciFirma = @IsletmeciFirma WHERE SubeID = @SubeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeAdi", txtSubeAd.Text);
                    command.Parameters.AddWithValue("@Il", txtIl.Text);
                    command.Parameters.AddWithValue("@Adres", txtSubeAdres.Text);
                    command.Parameters.AddWithValue("@YakıtRezerv", txtYakitRezerv.Text);
                    command.Parameters.AddWithValue("@IsletmeciFirma", txtFirmaID.Text);
                    command.Parameters.AddWithValue("@SubeID", txtSubeID.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            
            LoadDataFromDatabase();
            MessageBox.Show("Şube başarıyla düzenlendi!");
        }

     
        private void yenileme_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase(); 
            MessageBox.Show("Veriler yenilendi!");
        }

    
        private void btnSubeGetir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubeID.Text))
            {
                MessageBox.Show("Lütfen şube ID'si girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM Subeler WHERE SubeID = @SubeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeID", txtSubeID.Text);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtSubeAd.Text = reader["SubeAdi"].ToString();
                            txtIl.Text = reader["Il"].ToString();
                            txtSubeAdres.Text = reader["Adres"].ToString();
                            txtYakitRezerv.Text = reader["YakıtRezerv"].ToString();
                            txtFirmaID.Text = reader["IsletmeciFirma"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu ID'ye sahip bir şube bulunamadı!");
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void SubeYonetimiForm_Load(object sender, EventArgs e)
        {
            this.subelerTableAdapter3.Fill(this.petrolSatisSistemiDataSet4.Subeler);
            LoadDataFromDatabase();
        }

        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubeID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz şubenin ID'sini girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "DELETE FROM Subeler WHERE SubeID = @SubeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeID", txtSubeID.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Şube başarıyla silindi!");
                        LoadDataFromDatabase(); 
                    }
                    else
                    {
                        MessageBox.Show("Bu ID'ye sahip bir şube bulunamadı!");
                    }
                }
            }
        }

        private void f_Click(object sender, EventArgs e)
        {

        }
    }
}
