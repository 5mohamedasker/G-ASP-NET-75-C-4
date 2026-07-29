using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1.Create a one-dimensional array double[] prices
            ////with the values 25.5, 40.0, 33.75.
            ////Print the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Question02
            ////.2Create a 2x2 multidimensional array int[,]
            ////shelfCopies where shelf 0 has 3, 5 copies
            ////and shelf 1 has 1, 4 copies.
            ////Print the number of copies on shelf 1, slot 0.
            //int[,] arr = { {3,5} , {1,4} };
            //Console.WriteLine(arr[1, 0]);
            #endregion
            #region Question03
            ////3.Write a method called PrintWelcomeMessage
            ////that takes no parameters and prints "Welcome to the Library!"
            ////.Call it from Main.
            //PrintWelcomeMessage();
            #endregion
            #region Question04
            ////4.Write a method PrintBookTitle(string title)
            ////that prints "Book title: " + title. Call it with "Clean Code".
            //string title = "Clean Code";
            //PrintBookTitle(title);
            #endregion
            #region Question05
            ////5.Write a method AddBonusPages(int pages)
            ////that adds 50 to pages. Call it with a variable int pages = 400;
            ////and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            /*  What do you expect to see, and why?
            Nothing will happen because I passed by values
            That means we made a copy of it.
            and modified the copy, not the original.
            */
            #endregion
            #region Question06
            ////6.Write a method ApplyDiscount(double[] prices)
            ////that subtracts 5 from prices[0].
            ////Call it with double[] prices = { 25.5, 40.0 };
            ////and print prices[0] afterward.What do you expect to see, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            /*What do you expect to see, and why?
               Here the value will change because I passed the reference
               that means I'm dealing with the original, not a copy.
            */
            #endregion
            #region Question07
            ////7.Rewrite the method from question 5
            ////as AddBonusPagesByRef(ref int pages) using ref.
            ////Call it and print pages afterward.
            ////How is the result different from question 5 ?
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            /*How is the result different from question 5
                Here the value will change because I passed by reference
                that means I'm dealing with the original, not a copy.
            */
            #endregion
            #region Question08
            ////8.Write a method ReplaceArray(ref double[] prices)
            ////that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.
            ////Call it with your prices array and print prices.Lengt afterward.
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion
        }
        #region Question03_Method
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //} 
        #endregion
        #region Question04_Method
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title: {title}");
        //}
        #endregion
        #region Question05_Method
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}
        #endregion
        #region Question06_Method
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}
        #endregion
        #region Question07_Method
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}
        #endregion
        #region Question08_Method
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}
        #endregion
    }
}
