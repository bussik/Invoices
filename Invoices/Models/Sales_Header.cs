using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoices.Models
{
    public class Sales_Header
    {
        public int ID { get; set; }
        public DateTime Document_Date { get; set; }
        public string Customer { get; set; }
        public string Vat_Reg_No { get; set; }
        public DateTime Service_Date { get; set; }

    }
}