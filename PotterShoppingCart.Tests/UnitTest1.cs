using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        private List<Book> books;

        [TestInitialize()]
        public void TestInit()
        {
            books = new List<Book>();
        }

        [TestMethod()]
        public void buy_volumn_one_equal_100()
        {
            books.Add(new Book { Name = "HarryPotter Volumn 1", Price = 100 });

            double expected = 100;

            double sum = ShoppingCart.CalcPrice(books);

            Assert.AreEqual(expected, sum);
        }

        [TestMethod()]
        public void buy_volumn_one_and_two_equal_190()
        {
            books.Add(new Book {Name = "HarryPotter Volumn 1", Price = 100});
            books.Add(new Book {Name = "HarryPotter Volumn 2", Price = 100});

            double expected = 190;

            double sum = ShoppingCart.CalcPrice(books);

            Assert.AreEqual(expected, sum);
        }

        [TestMethod()]
        public void buy_volumn_one_two_three_four_five_equal_375()
        {
            books.Add(new Book { Name = "HarryPotter Volumn 1", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 2", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 3", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 4", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 5", Price = 100 });

            double expected = 375;

            double sum = ShoppingCart.CalcPrice(books);

            Assert.AreEqual(expected, sum);
        }

        [TestMethod()]
        public void buy_volumn_one_two_three_three_equal_370()
        {
            books.Add(new Book { Name = "HarryPotter Volumn 1", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 2", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 3", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 3", Price = 100 });

            double expected = 370;

            double sum = ShoppingCart.CalcPrice(books);

            Assert.AreEqual(expected, sum);
        }

        [TestMethod()]
        public void buy_volumn_one_two_two_three_three_equal_460()
        {
            books.Add(new Book { Name = "HarryPotter Volumn 1", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 2", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 2", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 3", Price = 100 });
            books.Add(new Book { Name = "HarryPotter Volumn 3", Price = 100 });

            double expected = 460;

            double sum = ShoppingCart.CalcPrice(books);

            Assert.AreEqual(expected, sum);
        }
    }
}
