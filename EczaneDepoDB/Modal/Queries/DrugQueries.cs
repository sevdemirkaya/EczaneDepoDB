using EczaneDepoDB.Modal.DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneDepoDB.Modal.Queries
{
    internal class DrugQueries
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

        internal bool DeleteDrug(int drugId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Drugs WHERE ID = @DrugId", conn);
                cmd.Parameters.AddWithValue("@DrugId", drugId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;

            }
        }

        internal bool UpdateDrug(Drug drug)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Drugs SET Name = @Name, Barcode = @Barcode, Description = @Description, Quantity = @Quantity, Price = @Price WHERE ID = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Price", drug.Price);
                    cmd.Parameters.AddWithValue("@Barcode", drug.Barcode);
                    cmd.Parameters.AddWithValue("@Quantity", drug.Quantity);
                    cmd.Parameters.AddWithValue("@Description", drug.Description);
                    cmd.Parameters.AddWithValue("@Name", drug.Name);
                    cmd.Parameters.AddWithValue("@Id", drug.Id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("İlaç güncellendi.");
                return true;
            }
            catch
            {
                return false;
            }

        }

        internal bool InsertDrug(Drug drug)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Drugs (Name, Description, Quantity, Barcode, Price) VALUES (@Name, @Description, @Quantity,  @Barcode, @Price)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Price", drug.Price);
                        cmd.Parameters.AddWithValue("@Barcode", drug.Barcode);
                        cmd.Parameters.AddWithValue("@Quantity", drug.Quantity);
                        cmd.Parameters.AddWithValue("@Description", drug.Description);
                        cmd.Parameters.AddWithValue("@Name", drug.Name);
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

        internal Drug GetDrugById(int drugId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Drugs WHERE ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", drugId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Drug
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                Barcode = Convert.ToInt64(reader["Barcode"]),
                                Price = Convert.ToDecimal(reader["Price"])
                            };
                        }
                    }
                }
            }

            return null; 
        }


    }
}