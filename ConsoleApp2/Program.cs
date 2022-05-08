using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            var str = File.ReadAllText("Credit_Cards.xml");
            xDoc.LoadXml(str);
            XmlElement xRoot = xDoc.DocumentElement;
            List<CreditCard> creditCards = new List<CreditCard>();
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    creditCards.Add(new CreditCard
                    {
                        CardIssuer = xnode.ChildNodes[0].InnerText,
                        CardNumber = xnode.ChildNodes[1].InnerText,
                        CardExpDate = xnode.ChildNodes[2].InnerText,
                        Balance = xnode.ChildNodes[3].InnerText,
                        CardHolder = xnode.ChildNodes[4].InnerText
                    });
                }
            }
            foreach (var item in creditCards)
            {
                Console.WriteLine($"CardIssuer : {item.CardIssuer}");
                Console.WriteLine($"CardNumber : {item.CardNumber}");
                Console.WriteLine($"CardExpDate : {item.CardExpDate}");
                Console.WriteLine($"Balance : {item.Balance}");
                Console.WriteLine($"CardHolder : {item.CardHolder}");
                Console.WriteLine();
            }
            Console.WriteLine($"Count : {creditCards.Count}");
            Console.ReadKey();
    }

}
    public class CreditCard
    {
        public string CardIssuer { get; set; }
        public string CardNumber { get; set; }
        public string CardExpDate { get; set; }
        public string Balance { get; set; }
        public string CardHolder { get; set; }
    }
}
