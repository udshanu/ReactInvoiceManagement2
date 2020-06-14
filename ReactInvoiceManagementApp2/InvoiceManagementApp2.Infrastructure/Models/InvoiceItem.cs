using InvoiceManagementApp2.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp2.Entities.Models
{
    public class InvoiceItem : Entity
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public Invoice Invoice { get; set; }
    }
}
