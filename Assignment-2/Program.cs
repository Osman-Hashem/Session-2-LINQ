using Session_2;
using static Session_2.ListGenerator;

namespace Assignment_2
{
    internal class Program
    {
        static void Main()
        {
            #region Part 01 :

            #region Q01 :
            // 1. Find all products that are out of stock. ???

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02 : 
            // 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Q03 : 
            // 3. Returns digits whose name is shorter than their value.



            #endregion
            #endregion

            #region Part 02 :

            #region Q01 : 
            // 1. Get first Product out of Stock 

            //var result = ProductList.First();

            //Console.WriteLine(result);

            #endregion

            #region Q02 : 
            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.


            //var Result = ProductList.First(P => P.UnitsInStock > 1000);


            //Console.WriteLine(Result?.ProductName ?? "NULL");
            #endregion

            #region Q03 : 
            // 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var greaterThan5 = Arr.Where(X => X > 5).ToList();

            //if (greaterThan5.Count > 2)
            //    Console.WriteLine(greaterThan5[1]);


            #endregion

            #endregion

            #region Part 03 :

            #region Q01 : 
            // 1. Uses Count to get the number of odd numbers in the array

            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int Odd = Arr.Count(X => X % 2 != 0);

            //Console.WriteLine(Odd);

            #endregion

            #region Q02 : 
            // 2. Return a list of customers and how many orders each has.

            List<Customer> customerLists = new List<Customer>();



            #endregion

            #region Q03 : 
            // 
            #endregion


            #endregion


        }
    }
}
