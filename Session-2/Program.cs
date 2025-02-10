namespace Session_2
{
    using static Session_2.ListGenerator;
    internal class Program
    {
        static void Main()
        {
            #region 1- Filteration Operators - where / oftype 
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            //------------------------------------------

            // LINQ : 40+ Extention Methods 
            // LINQ : 13 Category 

            // Filteration Operator - Where / OfType 

            // All Product Out Of Stock 


            // Fluent Syntax 
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            //-----

            // Query Syntax 
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //-----

            //var result =ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;


            // Indexed Where : Valid in Fluent Syntax : 
            // Can't Be Writen Using Query Syntax [Query Expression]

            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P, Index) => Index < 5 );
            //var result = ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock > 0);
            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, I) => I < 5);

            //-----------------------------------

            // 
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m , ProductList[0] , ProductList[1] };

            ////var result = arrayList.OfType<Product>();
            //var result = arrayList.OfType<float>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 2- Tranformation Operators - Select / SelectMany 
            // 2- Tranformation Operators - Select / SelectMany 

            // Fluent Syntax
            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);

            //----------

            //var result = from P in ProductList
            //             select P.ProductName;


            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //    .Select(P => new{
            //        P.ProductName ,
            //        P.Category ,
            //        OldPrice = P.UnitPrice ,
            //        NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //    });


            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M ,
            //             };


            //var result = CustomerList.Select(C => C.CustomerName);
            //var result = CustomerList.Select(C => C.Orders); // If One Of The Proparty is Sequance 
            //var result = CustomerList.SelectMany(C => C.Orders); // If One Of The Proparty is Sequance 


            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;


            // Indexed Select Valid Only In Fulent Syntax 
            // Can't Be Written Using Query Syntax [Query Exprssion]
            //var result = ProductList.Select((P,I) => new {I , P.ProductName }).Where(P => P.I < 5);



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 3- Ordering Operators 
            // 3- Ordering Operators 

            // Sorting 

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderBy(P => P.UnitPrice).Select(P => new {P.ProductName , P.UnitPrice , P.UnitsInStock});

            //var result = ProductList.OrderBy(P => P.UnitPrice)
            //                        .Select(P => new 
            //                        {
            //                            P.ProductName ,
            //                            P.UnitPrice ,
            //                            P.UnitsInStock
            //                        });

            //-/-/-/-

            //var result = ProductList.OrderByDescending(P => P.UnitPrice)
            //                       .Select(P => new
            //                       {
            //                           P.ProductName,
            //                           P.UnitPrice,
            //                           P.UnitsInStock
            //                       });

            //-/-/-/-

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .ThenBy(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                           P.ProductName,
            //                           P.UnitPrice,
            //                           P.UnitsInStock
            //                        });

            //-/-/-/-

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry" && P.UnitsInStock > 0) 
            //                        .OrderByDescending(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                          P.ProductName,
            //                          P.UnitPrice,
            //                          P.UnitsInStock
            //                        });

            //------------

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0 
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };



            ///-------------------------
            ///

            //var result = ProductList.Reverse<Product>();



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 4- Elements Operators - Immediate Execution

            // 4- Elements Operators - Immediate Execution

            //ProductList = new List<Product>();

            //var result = ProductList.First(); // May Throw Exeption [Sequence contains no elements]
            //var result = ProductList.Last(); // May Throw Exeption [Sequence contains no elements]

            //var result = ProductList.First(P => P.UnitsInStock == 1000); // May Throw Exeption [Sequence contains no matching element]
            //var result = ProductList.Last(P => P.UnitsInStock == 0); // May Throw Exeption [ Sequence contains no matching element]

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName = " Default Product " });
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0 , new Product() { ProductName = " Default Product " });

            //-/-/-/-

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = " Default Product " });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0, new Product() { ProductName = " Default Product " });

            //---------------------------------------

            //var result = ProductList.ElementAt(0); // May Throw Exeption [Index was out of range]
            //var result = ProductList.ElementAtOrDefault(0);

            //ProductList = new List<Product>() { new Product() { ProductName = " Only One Product "} };

            //var result = ProductList.Single(); // May Throw Exeption 
            // Sequance Conatins more Than one Elements 
            // Sequance Conatins no Elements 

            //-/-/-

            //var result = ProductList.Single(P => P.UnitsInStock == 0); // May Throw Exeption 
            // [Sequence contains more than one matching element]
            // Sequance Conatins no matching Element 

            //-/-/-/-

            //var result = ProductList.SingleOrDefault(); // May Throw Exeption 
            //  Sequence contains more than one element
            // Return Default Value [null] If The Sequance is Empty 

            //-/-/-/-

            //var result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Value "}); // May Throw Exeption 
            //  Sequence contains more than one element
            // Return Default Value [new Product() { ProductName = "Default Value "}] If The Sequance is Empty 

            //-/-/-/-/-

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000); // May Throw Exeption 
            //  Sequence contains more than one element
            // Return Default Value [null] If The Sequance is Empty 


            //-------------------------------------------------

            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default" });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result?.ProductName ?? "NA");
            #endregion

            #region 5- Aggregate Operators - Immediate Execution
            // 5- Aggregate Operators - Immediate Execution 

            // Count - Sum - MAX - MIN - AVG 

            //var result = ProductList.Count(); // 77
            //var result = ProductList.Count; // 77

            //var result = ProductList.Count(P => P.UnitsInStock == 0); // 5

            //var result = ProductList.Where(P => P.UnitsInStock ==0 ).Count(); //5 

            // Sum :

            //var result = ProductList.Sum(P => P.UnitPrice); // 2222.7100
            //var result = ProductList.Sum(P => P.UnitsInStock); // 3180

            // Avg :

            //var result = ProductList.Average(P => P.UnitPrice); // 28.866363636363636363636363636


            // Max :

            //var result = ProductList.Max(); // $263.50 , Based In ICompareable (Price)
            //var result = ProductList.Max(new ProductCompererUnitInStock()); // $125 , Based In Icomperer (UnitInStock)
            //var result = ProductList.Max(P => P.UnitsInStock); // 125

            //var MaxPrice = ProductList.Max(P => P.UnitPrice); // 263.5000

            //var result = ProductList.FirstOrDefault(P => P.UnitPrice == MaxPrice);

            //var result = ProductList.MaxBy(P => P.UnitPrice); // Product

            // Min :

            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductCompererNameLenght());
            //var result = ProductList.Max(new ProductCompererNameLenght());

            //var result = ProductList.Min(P => P.UnitPrice); //2.5000

            //var result = ProductList.MinBy(P => P.ProductName);

            //--/-/-/-

            // Aggregate 

            //List<string> list = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };

            //var result = list.Aggregate((S01 , S02) => $"{S01} {S02}");  



            //Console.WriteLine(result); 
            #endregion

            #region 6- Casting Operator : Immediate Execution 

            // Casting Operator : Immediate Execution 

            //List<Product> list = /*(List<Product>)*/ ProductList.Where( P => P.UnitsInStock == 0); // INvalid 
            //List<Product> list =  ProductList.Where( P => P.UnitsInStock == 0).ToList();
            //Product[] list =  ProductList.Where( P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long , Product> list =  ProductList.Where( P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //HashSet<Product> list =  ProductList.Where( P => P.UnitsInStock == 0).ToHashSet();


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 7- Generation Operators
            // 7- Generation Operators 
            // The Only Way To Call This Method As -> Class Member Throught "Enumerable" Class

            // Range , Empty , Repeat 

            //var result = Enumerable.Range(1, 100);

            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductName = "Product 01" });
            //result.Add(new Product() { ProductName = "Product 02" });


            //var result = Enumerable.Repeat(ProductList[0] , 3);
            //var result = Enumerable.Repeat( 1 , 3);



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item );
            //} 
            #endregion

            #region 8- Set Operators - Union Family 
            // 8- Set Operators - Union Family 
            // Union - Union All - Intersect , Except

            //var Seq01 = Enumerable.Range(1, 100); // 1 ... 100
            //var Seq02 = Enumerable.Range(50, 100); // 50 ... 149

            //var result = Seq01.Union(Seq02); // Like Union IN SQL Without Duplication 
            //var result = Seq01.Concat(Seq02); // Like Union All IN SQL with Duplication 
            //result = result.Distinct();// Remove Duplication 

            //var result = Seq01.Intersect(Seq02); // 50 ..100
            //var result = Seq01.Except(Seq02); // 1 ..49
            //var result = Seq02.Except(Seq01); // 101 ..149


            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region 9- Quantifiers Operators - Return Boolean
            // 9- Quantifiers Operators - Return Boolean 

            // Any - All - SequanceEqual - Contains 

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            // Any() ->> Return True f There Are At Least One Elrment [in Sequance Or Match The Condtion] 

            //var result = Seq01.Any(N => N % 2== 0);

            //var result = ProductList.Any();
            //var result = ProductList.Any(P => P.UnitsInStock == 0);

            // ALL () -->> Return true if All Elements in the Sequance Mqtch The Conditions Or Sequance is empty 

            //var result = ProductList.All(P => P.UnitsInStock == 0);
            //var result = ProductList.All(P => P.UnitPrice > 0);

            // SequanceEqual () -->> 

            //var result = Seq01.SequenceEqual(Seq01);

            //var result = Seq02.Contains(1);




            //Console.WriteLine(result); 
            #endregion

            #region 10- Zipping Operator 
            // 10- Zipping Operator 
            // Zip 

            //List<string> Words = new List<string>() { "Ten", "twenty", "Thirty", "Fourty" };

            //List<int> Numbers = new List<int>() {10 , 20 ,30 , 40 , 50 , 60};

            //var result = Words.Zip(Numbers , (W, N) => $"{N} --> {W}");

            //foreach ( var item in result )
            //{
            //    Console.WriteLine( item );
            //} 
            #endregion

            #region Groping Operators :
            // Groping Operators : 

            //var result = ProductList.GroupBy(P => P.Category);

            //result = from P in ProductList
            //         group P by P.Category;

            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);

            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($".... {Product}");
            //    }
            //}


            //-/-/-/-/-

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10 
            //             select new {CategoryName = Category.Key , CountOfCategory = Category.Count()};



            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .OrderByDescending( C => C.Count())
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C => new { CategoryName = C.Key, CountOfCategory = C.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion







        }
    }
}
