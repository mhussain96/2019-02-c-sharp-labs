using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace lab_30_Northwind_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            // add product / category / northwind classes from last
            // CORE project
            List<Product> products = new List<Product>();
            using (var db = new Northwind())
            {
                products = db.Products.OrderBy(p => p.ProductName).Take(3).ToList();
            }
            products.ForEach(p => Console.WriteLine(p.ProductName));
            // read northwind

            // extract products
            Console.WriteLine("\n\nExtracting To XML \n\n");
            
            var xml = new XElement("Products",
                from p in products
                select new XElement("Products",
                new XAttribute("ID", p.ProductID),
                new XAttribute("Cost", p.Cost),
                new XAttribute("Name", p.ProductName)
                ));
            // write to XML
            Console.WriteLine(xml.ToString());
            // write to file
            var doc = new XDocument(xml);
            doc.Save("Products.xml");

            // now the test 

            Console.WriteLine("\n\n Firstly just read back the raw XML data as a string\n\n");

            Console.WriteLine(File.ReadAllText("Products.xml"));

            // as XML document 

            var doc2 = XDocument.Load("Products.xml");


        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            this.Products = new List<Product>();
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "../../../../data/Northwind.db");
            // use SQLite
            optionsBuilder.UseSqlite($"Filename={path}");
            // use SQL
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=Northwind;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            // filter out discontinued products
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.Discontinued);
        }
    }


    // This class will hold the deserialized object (casting XML back into List of products)
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Products")]
        public List<Product> ProductList { get; set; }
    }
}
