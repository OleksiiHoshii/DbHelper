using LinqToDB;

namespace DBHelper.LingToDb
{
    public class InvoiceDbContext : LinqToDB.Data.DataConnection
    {
        public InvoiceDbContext() : base("Invoice") { }

       // public ITable<Invoice> Invoices => GetTable<Invoice>();
    }
}
