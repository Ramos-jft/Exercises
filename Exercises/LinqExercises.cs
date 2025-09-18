using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class LinqExercises
    {
        // Exercise 1 - Write a program in C# Sharp to show how the three parts of a query operation execute.
        public static string Exercise1()
        {
            int[] n1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery = from num in n1
                         where num % 2 == 0
                         select num;

            return string.Join(" ", nQuery);
        }

        // Exercise 2 - Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
        public static string Exercise2()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var nQuery = from num in n1
                         where num > 0
                         where num < 12
                         select num;

            return string.Join(" ", nQuery);
        }

        // Exercise 3 - Write a program in C# Sharp to find the number of an array and the square of each number.
        public static List<string> Exercise3()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var sqNo = from Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            return sqNo.Select(a => $"{{ Number = {a.Number}, SqrNo = {a.SqrNo} }}").ToList();
        }

        // Exercise 4 - Write a program in C# Sharp to display the number and frequency of a given number from an array.
        public static List<string> Exercise4()
        {
            int[] arr1 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var n = from x in arr1
                    group x by x into y
                    select y;

            return n.Select(arrNo => $"Number {arrNo.Key} appears {arrNo.Count()} times").ToList();
        }

        // Exercise 5 -  Write a program in C# Sharp to display the characters and frequency of each character in a given string.
        public static List<string> Exercise5(string input)
        {
            var FreQ = from x in input
                       group x by x into y
                       select y;

            return FreQ.Select(ArrEle => $"Character {ArrEle.Key}: {ArrEle.Count()} times").ToList();
        }

        // Exercise 6 - Write a program in C# Sharp to display the name of the days of the week.
        public static List<string> Exercise6()
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            var days = from WeekDay in dayWeek
                       select WeekDay;

            return days.ToList();
        }

        // Exercise 7 - Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
        public static List<string> Exercise7()
        {
            int[] nums = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var m = from x in nums
                    group x by x into y
                    select y;

            return m.Select(arrEle => $"{arrEle.Key}\t{arrEle.Sum()}\t\t\t{arrEle.Count()}").ToList();
        }

        // Exercise 8 - Write a program in C# Sharp to find a string that starts and ends with a specific character.
        public static List<string> Exercise8(string startChar, string endChar)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var _result = from x in cities
                          where x.StartsWith(startChar)
                          where x.EndsWith(endChar)
                          select x;

            return _result.ToList();
        }

        // Exercise 9 - Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
        public static List<int> Exercise9()
        {
            List<int> templist = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

            var FilterList = from num in templist
                             where num > 80
                             select num;

            return FilterList.ToList();
        }

        // Exercise 10 - Write a program in C# Sharp to accept list members through the keyboard and display them more than a specific value.
        public static List<int> Exercise10(List<int> inputList, int threshold)
        {
            var FilterList = from num in inputList
                             where num > threshold
                             select num;

            return FilterList.ToList();
        }

        // Exercise 11 - Write a program in C# Sharp to display the top n-th records.
        public static List<int> Exercise11(List<int> inputList, int n)
        {
            return inputList.OrderByDescending(x => x).Take(n).ToList();
        }

        // Exercise 12 - Write a program in C# Sharp to find uppercase words in a string.
        public static List<string> Exercise12(string input)
        {
            var upWord = input.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));

            return upWord.ToList();
        }

        // Exercise 13 - Write a program in C# Sharp to convert a string array to a string.
        public static string Exercise13(string[] inputArray)
        {
            return string.Join(", ", inputArray);
        }

        // Exercise 14 - Write a program in C# Sharp to find the n-th maximum grade point achieved by the students from the list of students.
        public class Students
        {
            public string StuName { get; set; }
            public int GrPoint { get; set; }
            public int StuId { get; set; }

            public List<Students> GtStuRec()
            {
                List<Students> stulist = new List<Students>();
                stulist.Add(new Students { StuId = 1, StuName = "Joseph", GrPoint = 800 });
                stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
                stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
                stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
                stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
                stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
                stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
                stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
                stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
                stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
                return stulist;
            }
        }

        public static List<string> Exercise14(int grPointRank)
        {
            Students e = new Students();
            var stulist = e.GtStuRec();

            var students = (from stuMast in stulist
                            group stuMast by stuMast.GrPoint into g
                            orderby g.Key descending
                            select new { StuRecord = g.ToList() }).ToList();

            return students[grPointRank - 1].StuRecord
                .Select(i => $"Id : {i.StuId}, Name : {i.StuName}, achieved Grade Point : {i.GrPoint}").ToList();
        }

        // Exercise 15 - Write a program in C# Sharp to count file extensions and group it using LINQ.
        public static List<string> Exercise15()
        {
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                         .GroupBy(z => z, (fExt, extCtr) => new
                         {
                             Extension = fExt,
                             Count = extCtr.Count()
                         });

            return fGrp.Select(m => $"{m.Count} File(s) with .{m.Extension} Extension").ToList();
        }

        // Exercise 16 - Write a program in C# Sharp to calculate size of file using LINQ.
        public static string Exercise16(string[] filePaths)
        {
            var avgFsize = filePaths.Select(file => new FileInfo(file).Length).Average();
            avgFsize = Math.Round(avgFsize / (1024 * 1024), 1);
            return $"The Average file size is {avgFsize} MB";
        }

        // Exercise 17 - Write a program in C# Sharp to remove items from list using remove function by passing the object.
        public static List<string> Exercise17()
        {
            List<string> listOfString = new List<string> { "m", "n", "o", "p", "q" };

            string newstr = listOfString.FirstOrDefault(en => en == "o");
            listOfString.Remove(newstr);

            return listOfString.Select(z => $"Char: {z}").ToList();
        }

        // Exercise 18 - Write a program in C# Sharp to remove items from list by creating an object internally by filtering.
        public static List<string> Exercise18()
        {
            List<string> listOfString = new List<string> { "m", "n", "o", "p", "q" };

            listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));

            return listOfString.Select(z => $"Char: {z}").ToList();
        }

        // Exercise 19 - Write a program in C# Sharp to remove items from list by passing filters.
        public static List<string> Exercise19()
        {
            List<string> listOfString = new List<string> { "m", "n", "o", "p", "q" };

            listOfString.RemoveAll(en => en == "q");

            return listOfString.Select(z => $"Char: {z}").ToList();
        }

        // Exercise 20 - Write a program in C# Sharp to remove items from list by passing the item index.
        public static List<string> Exercise20()
        {
            List<string> listOfString = new List<string> { "m", "n", "o", "p", "q" };

            listOfString.RemoveAt(3);

            return listOfString.Select(z => $"Char: {z}").ToList();
        }

        // Exercise 21 - Write a program in C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove.
        public static List<string> Exercise21()
        {
            List<string> listOfString = new List<string> { "m", "n", "o", "p", "q" };

            listOfString.RemoveRange(1, 3);

            return listOfString.Select(z => $"Char: {z}").ToList();
        }

        // Exercise 22 - Write a program in C# Sharp to find the strings for a specific minimum length.
        public static List<string> Exercise22(string[] inputArray, int minLength)
        {
            var objNew = from m in inputArray
                         where m.Length >= minLength
                         orderby m
                         select m;

            return objNew.Select(z => $"Item: {z}").ToList();
        }

        // Exercise 23 - Write a program in C# Sharp to generate a cartesian product of two sets.
        public static List<string> Exercise23(char[] charset1, int[] numset1)
        {
            var cartesianProduct = from letterList in charset1
                                   from numberList in numset1
                                   select new { letterList, numberList };

            return cartesianProduct.Select(p => $"{{ letterList = {p.letterList}, numberList = {p.numberList} }}").ToList();
        }

        // Exercise 24 - Write a program in C# Sharp to generate a cartesian product of three sets.
        public static List<string> Exercise24(char[] charset1, int[] numset1, string[] colorset1)
        {
            var cartesianProduct = from letter in charset1
                                   from number in numset1
                                   from colour in colorset1
                                   select new { letter, number, colour };

            return cartesianProduct.Select(p => $"{{ letter = {p.letter}, number = {p.number}, colour = {p.colour} }}").ToList();
        }

        // Exercise 25 - Write a program in C# Sharp to generate an Inner Join between two data sets.
        public class Item_mast
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }
        }

        public class Purchase
        {
            public int InvNo { get; set; }
            public int ItemId { get; set; }
            public int PurQty { get; set; }
        }

        public static List<string> Exercise25()
        {
            List<Item_mast> itemlist = new List<Item_mast>
        {
            new Item_mast { ItemId = 1, ItemDes = "Biscuit" },
            new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
            new Item_mast { ItemId = 3, ItemDes = "Butter" },
            new Item_mast { ItemId = 4, ItemDes = "Brade" },
            new Item_mast { ItemId = 5, ItemDes = "Honey" }
        };

            List<Purchase> purchlist = new List<Purchase>
        {
            new Purchase { InvNo=100, ItemId = 3, PurQty = 800 },
            new Purchase { InvNo=101, ItemId = 2, PurQty = 650 },
            new Purchase { InvNo=102, ItemId = 3, PurQty = 900 },
            new Purchase { InvNo=103, ItemId = 4, PurQty = 700 },
            new Purchase { InvNo=104, ItemId = 3, PurQty = 900 },
            new Purchase { InvNo=105, ItemId = 4, PurQty = 650 },
            new Purchase { InvNo=106, ItemId = 1, PurQty = 458 }
        };

            var innerJoin = from e in itemlist
                            join d in purchlist on e.ItemId equals d.ItemId
                            select new
                            {
                                itid = e.ItemId,
                                itdes = e.ItemDes,
                                prqty = d.PurQty
                            };

            return innerJoin.Select(data => $"{data.itid}\t\t{data.itdes}\t\t{data.prqty}").ToList();

        }

        // Exercise 26 - Write a program in C# Sharp to generate a Left Join between two data sets.
        public class ItemMast26
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }
        }

        public class Purchase26
        {
            public int InvNo { get; set; }
            public int ItemId { get; set; }
            public int PurQty { get; set; }
        }

        public static List<string> Exercise26()
        {
            List<ItemMast26> itemlist = new List<ItemMast26>
        {
            new ItemMast26 { ItemId = 1, ItemDes = "Biscuit" },
            new ItemMast26 { ItemId = 2, ItemDes = "Chocolate" },
            new ItemMast26 { ItemId = 3, ItemDes = "Butter" },
            new ItemMast26 { ItemId = 4, ItemDes = "Brade" },
            new ItemMast26 { ItemId = 5, ItemDes = "Honey" }
        };

            List<Purchase26> purchlist = new List<Purchase26>
        {
            new Purchase26 { InvNo=100, ItemId = 3, PurQty = 800 },
            new Purchase26 { InvNo=101, ItemId = 2, PurQty = 650 },
            new Purchase26 { InvNo=102, ItemId = 3, PurQty = 900 },
            new Purchase26 { InvNo=103, ItemId = 4, PurQty = 700 },
            new Purchase26 { InvNo=104, ItemId = 3, PurQty = 900 },
            new Purchase26 { InvNo=105, ItemId = 4, PurQty = 650 },
            new Purchase26 { InvNo=106, ItemId = 1, PurQty = 458 }
        };

            var leftOuterJoin = from itm in itemlist
                                join prch in purchlist
                                on itm.ItemId equals prch.ItemId
                                into a
                                from b in a.DefaultIfEmpty(new Purchase26())
                                select new
                                {
                                    itid = itm.ItemId,
                                    itdes = itm.ItemDes,
                                    prqty = b.PurQty
                                };

            return leftOuterJoin.Select(data => $"{data.itid}\t\t{data.itdes}\t\t{data.prqty}").ToList();
        }

        // Exercise 27 - Write a program in C# Sharp to generate a Right Outer Join between two data sets.
        public class ItemMast27
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }
        }

        public class Purchase27
        {
            public int InvNo { get; set; }
            public int ItemId { get; set; }
            public int PurQty { get; set; }
        }

        public static List<string> Exercise27()
        {
            List<ItemMast27> itemlist = new List<ItemMast27>
        {
            new ItemMast27 { ItemId = 1, ItemDes = "Biscuit" },
            new ItemMast27 { ItemId = 2, ItemDes = "Chocolate" },
            new ItemMast27 { ItemId = 3, ItemDes = "Butter" },
            new ItemMast27 { ItemId = 4, ItemDes = "Brade" },
            new ItemMast27 { ItemId = 5, ItemDes = "Honey" }
        };

            List<Purchase27> purchlist = new List<Purchase27>
        {
            new Purchase27 { InvNo=100, ItemId = 3, PurQty = 800 },
            new Purchase27 { InvNo=101, ItemId = 5, PurQty = 650 },
            new Purchase27 { InvNo=102, ItemId = 3, PurQty = 900 },
            new Purchase27 { InvNo=103, ItemId = 4, PurQty = 700 },
            new Purchase27 { InvNo=104, ItemId = 3, PurQty = 900 },
            new Purchase27 { InvNo=105, ItemId = 4, PurQty = 650 },
            new Purchase27 { InvNo=106, ItemId = 1, PurQty = 458 }
        };

            var rightOuterJoin = from p in purchlist
                                 join i in itemlist
                                 on p.ItemId equals i.ItemId
                                 into a
                                 from b in a.DefaultIfEmpty()
                                 select new
                                 {
                                     itid = b?.ItemId ?? 0,
                                     itdes = b?.ItemDes ?? "",
                                     prqty = p.PurQty
                                 };

            return rightOuterJoin.Select(data => $"{data.itid}\t\t{data.itdes}\t\t{data.prqty}").ToList();
        }

        /* Exercise 28 - Write a program in C# Sharp to display the list of items in the array according to the length of the
           string then by name in ascending order. */
        public static List<string> Exercise28()
        {
            string[] cities =
            {
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
        };

            var cityOrder = cities.OrderBy(str => str.Length).ThenBy(str => str);

            return cityOrder.ToList();
        }

        // Exercise 29 - Write a program in C# Sharp to split a collection of strings into some groups.
        public static List<string> Exercise29()
        {
            string[] cities =
            {
            "ROME","LONDON","NAIROBI","CALIFORNIA",
            "ZURICH","NEW DELHI","AMSTERDAM",
            "ABU DHABI", "PARIS","NEW YORK"
        };

            var citySplit = from i in Enumerable.Range(0, cities.Length)
                            group cities[i] by i / 3;

            var result = new List<string>();
            foreach (var city in citySplit)
            {
                result.Add(string.Join(";  ", city.ToArray()));
                result.Add("-- here is a group of cities --");
            }

            return result;
        }

        // Exercise 30 - Write a program in C# Sharp to arrange the distinct elements in the list in ascending order.
        public class ItemMast30
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }

            public static List<ItemMast30> GetItemMast()
            {
                List<ItemMast30> itemlist = new List<ItemMast30>();
                itemlist.Add(new ItemMast30() { ItemId = 1, ItemDes = "Biscuit" });
                itemlist.Add(new ItemMast30() { ItemId = 2, ItemDes = "Honey" });
                itemlist.Add(new ItemMast30() { ItemId = 3, ItemDes = "Butter" });
                itemlist.Add(new ItemMast30() { ItemId = 4, ItemDes = "Brade" });
                itemlist.Add(new ItemMast30() { ItemId = 5, ItemDes = "Honey" });
                itemlist.Add(new ItemMast30() { ItemId = 6, ItemDes = "Biscuit" });

                return itemlist;
            }
        }

        public static List<string> Exercise30()
        {
            var itemlist = (from c in ItemMast30.GetItemMast()
                            select c.ItemDes)
                            .Distinct()
                            .OrderBy(x => x);

            return itemlist.ToList();
        }
    }
}
