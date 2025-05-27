using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneDepoDB.Modal.Queries
{
    internal class DrugStockQueries 
    {
        private string connectionString = @"Data Source=DESKTOP-D2T030R\SQLEXPRESS;Initial Catalog=EczaneDepoDB;Integrated Security=True;";

        internal DataTable GetDrugData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Drugs";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        internal void DeleteDrug(string drugId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Drugs WHERE drugId = @DrugId", conn);
                cmd.Parameters.AddWithValue("@DrugId", drugId);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    MessageBox.Show("İlaç silindi.", "Bilgi");
                else
                    MessageBox.Show("İlaç silinemedi.", "Hata");
            }
        }

        internal void UpdateDrug(string drugId, string name, string barcode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DrugStore SET  = @Name, Barcode = @Barcode WHERE drugId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@Id", drugId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("İlaç güncellendi.");
        }

        internal bool InsertDrug(string name, string barcode) //todo: decription vs eklenecek
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Drugs (Name, Barcode) VALUES (@Name, @Barcode)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Barcode", barcode);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
    }
}