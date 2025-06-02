using EczaneDepoDB.Modal.DataAccess;
using System;
using System.Data.SqlClient;

namespace EczaneDepoDB.Modal.Queries
{
    internal class ReceiptQueries
    {
        private readonly string connectionString = @"Data Source=DESKTOP-D2T030R\SQLEXPRESS;Initial Catalog=EczaneDepoDB;Integrated Security=True;";

        internal bool InsertReceipt(Receipt receipt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Receipts (PrescriptionId, Price, PhoneNumber, CreatedAt) VALUES (@PrescriptionId, @Price, @PhoneNumber, @CreatedAt)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PrescriptionId", receipt.PrescriptionId);
                        cmd.Parameters.AddWithValue("@Price", receipt.Price);
                        cmd.Parameters.AddWithValue("@PhoneNumber", receipt.PhoneNumber);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
