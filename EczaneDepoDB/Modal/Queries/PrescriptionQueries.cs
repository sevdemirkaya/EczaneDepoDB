using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modules.Prescription;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EczaneDepoDB.Modal.Queries
{
    internal class PrescriptionQueries
    {
        private readonly string connectionString = @"Data Source=DESKTOP-D2T030R\SQLEXPRESS;Initial Catalog=EczaneDepoDB;Integrated Security=True;";

        internal DataAccess.Prescription GetByNationalId(string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TOP(1) * FROM Prescriptions WHERE NationalId = @id AND Status = 0 ORDER BY CreatedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string drugListJson = reader["DrugList"]?.ToString();


                                var prescription = new DataAccess.Prescription()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    NationalId = reader["NationalId"].ToString(),
                                    Status = Convert.ToInt32(reader["Status"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                    DrugList = !string.IsNullOrWhiteSpace(drugListJson)
                                        ? JsonConvert.DeserializeObject<List<Drug>>(drugListJson)
                                        : new List<Drug>()
                                };

                                return prescription;
                            }
                        }
                    }
                }

                return null; 
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal bool Insert(DataAccess.Prescription prescription)
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

        internal bool Delete(int id)
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

        internal bool Update(DataAccess.Prescription prescription)
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
