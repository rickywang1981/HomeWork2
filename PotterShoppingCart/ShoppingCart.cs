using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        static Dictionary<int, double> discounts = new Dictionary<int, double>()
        {
            {1, 1.0},
            {2, 0.95},
            {3, 0.9},
            {4, 0.8},
            {5, 0.75}
        }; 

        public static double CalcPrice(List<Book> books)
        {
            // determine book category by book name
            var bookCategory = books.GroupBy(x => x.Name);

            // determine how many books in each category
            var categoryCountGroup = bookCategory.Select(x => x.Count())
                                                 .Distinct()
                                                 .OrderBy(c => c).ToList();

            double sum = 0;
            int prevMinCount = 0;
            foreach (var c in categoryCountGroup)
            {
                double partialSum = 0;
                int discountKey = 0;
                foreach (var bc in bookCategory)
                {
                    if (bc.Count() >= c)
                    {
                        // get a book in the group
                        var k = bc.ElementAt(0);

                        // sum the book price in the group
                        partialSum += k.Price * (c - prevMinCount);

                        // increment discount key
                        discountKey++;
                    }
                }

                partialSum *= discounts[discountKey];                

                prevMinCount = c;

                // result
                sum += partialSum;
            }

            return sum;
        }
    }
}
