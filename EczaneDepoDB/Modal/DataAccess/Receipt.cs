using System;
using EczaneDepoDB.Modules.Prescription;

namespace EczaneDepoDB.Modal.DataAccess
{
    internal class Receipt
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public int Price { get; set; }
        public int PhoneNumber { get; set; }


        public Receipt(int id, int prescriptionId, int price, int phoneNumber)
        {
            Id = id;
            PrescriptionId = prescriptionId;
            Price = price;
            PhoneNumber = phoneNumber;
        }
        public Receipt(int prescriptionId, int price, int phoneNumber)
        {
            PrescriptionId = prescriptionId;
            Price = price;
            PhoneNumber = phoneNumber;
        }
    }
}
