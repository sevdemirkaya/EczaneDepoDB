using EczaneDepoDB.Modal.DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EczaneDepoDB.Modal.Queries
{
    internal class PrescriptionQueries
    {
        private string connectionString = @"Data Source=DESKTOP-D2T030R\SQLEXPRESS;Initial Catalog=EczaneDepoDB;Integrated Security=True;";

        internal DataTable GetPrescriptionData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Prescriptions";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        internal bool InsertPrescription(Prescription prescription)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Prescriptions (NationalId, DrugList, Status, CreatedAt) " +
                                   "VALUES (@NationalId, @DrugList, @Status, @CreatedAt)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NationalId", prescription.NationalId);
                        cmd.Parameters.AddWithValue("@DrugList", prescription.DrugList);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        internal bool DeletePrescription(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Prescriptions WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        internal bool UpdatePrescription(Prescription prescription)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Prescriptions SET NationalId = @NationalId, " +
                                   "DrugList = @DrugList WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", prescription.Id);
                    cmd.Parameters.AddWithValue("@NationalId", prescription.NationalId);
                    cmd.Parameters.AddWithValue("@DrugList", prescription.DrugList);
                    //cmd.Parameters.AddWithValue("@CreatedAt", prescription.CreatedAt);
                    cmd.Parameters.AddWithValue("@Status", prescription.Status);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
