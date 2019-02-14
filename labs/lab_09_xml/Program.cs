using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
// USE XML
using System.Xml.Linq;
// LOAD XML

namespace lab_09_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            // To use XML must add following
            // using System.Xml.Linq;

            Console.WriteLine("\nMost Basic XML element\n");

            var xml01 = new XElement("test", 1); // test is name of field and 1 is value of data/object
            Console.WriteLine(xml01);

            Console.WriteLine("\nNow add sub-element\n");
            var xml02 = new XElement("RootElement",
                new XElement("SubElement", 100));
            Console.WriteLine(xml02);

            Console.WriteLine("\nNow add multiple sub-element\n");
            var xml03 = new XElement("RootElement",
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100)
                );
            Console.WriteLine(xml03);

            Console.WriteLine("\nNow add attributes\n");
            var xml04 = new XElement("RootElement",
                new XElement("SubElement",
                    new XAttribute("height",500), 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100)
                );
            Console.WriteLine(xml04);

            Console.WriteLine("\nNow add attributes\n");
            var xml05 = new XElement("RootElement",
                new XElement("SubElement",
                    new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100)
                );
            Console.WriteLine(xml05);

            Console.WriteLine("\nNow save to a document\n");
            var xml06 = new XElement("RootElement",
                new XElement("SubElement",
                    new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100)
                );
            Console.WriteLine(xml06);
            // xDocument : save this to file
            var doc06 = new XDocument(XElement.Parse(xml06.ToString()));
            doc06.Save("Xml06.xml");  // inside is the relative path of file

            // loading same data and print it out 
            Console.WriteLine("\nNow load back the same data\n");
            var doc07 = XDocument.Load("Xml06.xml");
            Console.WriteLine(doc07);
        }
    }
}
