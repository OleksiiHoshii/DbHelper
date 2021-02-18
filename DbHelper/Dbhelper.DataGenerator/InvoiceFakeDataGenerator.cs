using Bogus;
using System;
using System.Collections.Generic;

namespace Dbhelper.DataGenerator
{
    public class InvoiceFakeDataGenerator
    {
        public static IEnumerable<Invoice> Generate(int count)
        {
            var invoiceGenerator = new Faker<Invoice>()
                .RuleFor(x => x.InvoiceNo, f => f.Commerce.Ean8())
                .RuleFor(x => x.IsPaid, f => f.Random.Bool())
                .RuleFor(x => x.Date, f => f.Date.Recent())
                .RuleFor(x => x.DueDate, f => f.Date.Recent());

            return invoiceGenerator.Generate(count);
        }
    }
}
