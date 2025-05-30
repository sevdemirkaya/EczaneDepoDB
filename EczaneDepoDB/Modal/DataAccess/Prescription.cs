using System;
using System.Collections.Generic;

namespace EczaneDepoDB.Modal.DataAccess
{
    internal class Prescription
    {
        public int Id { get; set; }
        public string NationalId { get; set; }
        public List<Drug> DrugList { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public Prescription() { }

        public Prescription(int id, string nationalId, List<Drug> drugList, int status, DateTime createdAt)
        {
            Id = id;
            NationalId = nationalId;
            DrugList = drugList;
            Status = status;
            CreatedAt = createdAt;

        }

        public Prescription(string nationalId, List<Drug> drugList, int status, DateTime createdAt)
        {
           
            NationalId = nationalId;
            DrugList = drugList;
            Status = status;
            CreatedAt = createdAt;
        }
        
    }
}
