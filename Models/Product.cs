using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _19._04Pratice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public static int Count { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string InStock { get; set; }
        public int Price { get; set; }
        public Product()
        {
            Count++;
            Id = Count;
        }
        //public Product[] Code(string Title)
        //{
        //for (int i = 0; i < Title.Length; i++)
        //{
        //    Console.WriteLine(Title[i]);
        //    break;
        //}
        //foreach (char str in title)
        //{
        //    console.writeline(str);
        //}
        public Product(string Title)
        {
            var title = Title.Split(' ')[0];
            Console.WriteLine(title);
        }

        //    return null;
        //}


    }


}
