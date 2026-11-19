using System;

namespace Task_1    
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            /*
            object FirstBook = new Book { Title = "How to learn Turkish in 3 days", Pages = 140 };
            Console.WriteLine(FirstBook);
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 2

            /*
            Book FirstBook = new Book { Title = "How to learn Turkish in 3 days", Pages = 140 };

            Console.WriteLine(FirstBook.ToString());
            Console.WriteLine(FirstBook.Equals(FirstBook));
            Console.WriteLine(FirstBook.GetHashCode());
            Console.WriteLine(FirstBook.GetType());
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 3

            /*
            int pages = "464"; // Compile-time error, you cannot store a string in an int variable without conversion

            int pages = int.Parse("464");
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 4

            /*
            int num = 0;

            try
            {
                int result = 10 / num;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 5

            /*
            int pages = 300;
            double doublePages = pages;
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 6

            /*
            double price = 49.99;
            int intPrice = (int)price;
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 7

            /*
            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 8

            /*
            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";
            if (!int.TryParse(badText, out int result))
            {
                Console.WriteLine("Invalid number");
            }
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 9

            /*
            int pages = 464;
            string pagesStr = pages.ToString();
            Console.WriteLine(pagesStr.GetType());
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 10

            /*
            int num = 100;
            object boxNum = num;
            int unboxNum = (int)boxNum;

            Console.WriteLine(num);
            Console.WriteLine(unboxNum);
            */

            #endregion
        }
    }
}
