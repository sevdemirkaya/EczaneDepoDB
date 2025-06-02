
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneDepoDB.Modal.DataAccess
{
    internal class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public long Barcode{ get; set; }
        public decimal Price{ get; set; }
        public Drug() { }
        public Drug(int id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }

        public Drug(int id, string name, string description, int quantity, long barcode, decimal price) 
        {
            Id = id;
            Name = name;
            Description = description;
            Quantity = quantity;
            Barcode = barcode;
            Price = price;
		}

        public Drug(string name, string description, int quantity, long barcode, decimal price)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Barcode = barcode;
            Price = price;
        }
    }
}
