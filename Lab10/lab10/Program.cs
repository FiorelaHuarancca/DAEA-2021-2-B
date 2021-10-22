using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            //var query = from p in context.Products
            //            select p;

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //insertar datos
            //Product np = new Product();
            //np.ProductName = "Peruvian Coffe";
            //np.SupplierID = 20;
            //np.CategoryID = 1;
            //np.QuantityPerUnit = "10 pkgs";
            //np.UnitPrice = 25;

            //context.Products.InsertOnSubmit(np);
            //context.SubmitChanges();



            //var query = from p in context.Products
            //            where np.CategoryID == 1
            //            select p;



            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}

            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //               select p).FirstOrDefault();

            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;

            //context.SubmitChanges();

            //eliminar registro
            var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();

            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();

            Console.ReadKey();
        } 
    }
}
