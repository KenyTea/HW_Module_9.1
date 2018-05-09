﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9._1.Modules
{


    public class Creator
    {
        private Random r = new Random();
        public List<Product> product;

        public Creator()
        {
            product = new List<Product>();
        }

        public void GenerateToys()
        {
            Toy toy = new Toy();
            toy.Name = (ForToys)r.Next(0, 3);
            toy.Price = r.Next(100, 999);
            toy.Material = (Materials)r.Next(0, 3);
            toy.Manufacturer = r.Next(1000, 9999);
            toy.Age = r.Next(1, 7);

            product.Add(toy);
        }

        public void GenerateBooks()
        {
            Book book = new Book();
            book.Name = (Boooks)r.Next(0, 3);
            book.Price = r.Next(800, 2500);
            book.Manufacturer = r.Next(1000, 9999);
            book.Author = (Authors)r.Next(0, 3);
            book.Age = r.Next(6, 55);

            product.Add(book);

        }

        public void GenerateSportEquipments()
        {
            SportsEquipment sport = new SportsEquipment();
            sport.Name = (SportsEq)r.Next(0, 3);
            sport.Price = r.Next(20000, 150000);
            sport.Manufacturer = r.Next(1000, 9999);
            sport.Age = r.Next(6, 25);

            product.Add(sport);

        }

        public void PrintAll()
        {

            foreach (Product item in product)
            {
                Console.WriteLine("Name - " + item.Age);
                Console.WriteLine("Manufacturer - " + item.Manufacturer);
                Console.WriteLine("Price - " + item.Price);
                Console.WriteLine("Capasity - " + item.);
                Console.WriteLine(" ");
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}
