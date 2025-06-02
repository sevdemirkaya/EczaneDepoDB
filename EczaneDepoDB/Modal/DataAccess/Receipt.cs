using System;
using EczaneDepoDB.Modules.Prescription;

namespace EczaneDepoDB.Modal.DataAccess
{
    internal class Receipt
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public decimal Price { get; set; }
        public long PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; }

        public Receipt(int id, int prescriptionId, decimal price, long phoneNumber)
        {
            Id = id;
            PrescriptionId = prescriptionId;
            Price = price;
            PhoneNumber = phoneNumber;
        }
        public Receipt(int prescriptionId, decimal price, long phoneNumber)
        {
            PrescriptionId = prescriptionId;
            Price = price;
            PhoneNumber = phoneNumber;
        }
    }
}
