using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Invoices.Models;

namespace Invoices.Data_Access_Layer
{
    public class InvoicesContext : DbContext
    {
        public InvoicesContext(): base("connectionString")
        { 
        
        }
        public DbSet<Sales_Header> Sales_Header { get; set; }
    }

}