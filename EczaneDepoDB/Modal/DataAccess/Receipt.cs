using System;
using EczaneDepoDB.Modules.Prescription;

namespace EczaneDepoDB.Modal.DataAccess
{
    internal class Receipt
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public decimal Price { get; set; }
        public int PhoneNumber { get; set; }

        public Receipt(int id, int prescriptionId, decimal price, int phoneNumber)
        {
            Id = id;
            PrescriptionId = prescriptionId;
            Price = price;
            PhoneNumber = phoneNumber;
        }
        public Receipt(int prescriptionId, decimal price, int phoneNumber)
        {
            PrescriptionId = prescriptionId;
            Price = price;
            PhoneNumber = phoneNumber;
        }
    }
}
