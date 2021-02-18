using LinqToDB;
using LinqToDB.Data;
using System.Collections.Generic;
using System.Linq;

namespace DBHelper.LingToDb
{
    public class InvoiceRepository
    {
        //public static List<Invoice> All()
        //{
        //    using (var db = new InvoiceDbContext())
        //    {
        //        var query = db.Invoices.Where(x => x.Id == 1).OrderBy(x => x.InvoiceNo);
        //        return query.ToList();
        //    }
        //}

        //public static void  Insert(List<Invoice> invoces)
        //{
        //    using (var db = new InvoiceDbContext())
        //    {
        //        db.BulkCopy(invoces);
        //        //db.Insert(invoces);
        //    }
        //}
    }
}
