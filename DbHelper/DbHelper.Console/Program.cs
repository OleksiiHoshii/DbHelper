using dbHelper.ClassGenerator;
using DBHelper.LingToDb.Configuration;
using LinqToDB.Data;

namespace DbHelper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var classGenrator = new ClassGenrator(
                @$"D:\Projects\DbHelper\DBHelpers.DomainModel\Models", // distination folder
                "Data Source=.;Initial Catalog=Cirrus.Settings.Microservice;Integrated Security=True", // connection string
                "Cirrus.Settings.Microservice"); // db name
            classGenrator.GenerateClasses();


            DataConnection.DefaultSettings = new MySettings();
            //var result = InvoiceRepository.All();

            //var data = InvoiceFakeDataGenerator.Generate(100);
            //InvoiceRepository.Insert(data.ToList());


                System.Console.WriteLine("Hello World!");
        }
    }
}
