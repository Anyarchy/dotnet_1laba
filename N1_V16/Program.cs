using N1_V16.Models;
using N1_V16.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace N1_V16
{
    /// <summary>
    /// class program
    /// </summary>
    class Program
    {
        /// <summary>
        /// entrypoint method
        /// </summary>
        /// <param name="args">arguments passed in a method</param>
        static void Main(string[] args)
        {
            // initializing lists with data
            var lorries = DataInitializer.GetLorries();
            var anotherLorries = DataInitializer.GetMoreLorries();
            var taxis = DataInitializer.GetTaxis();
            var autoParks = DataInitializer.GetAutoParks();

            // creating queries

            // +-+-+-+-+-+-+ [1] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tSimple select");
            var q1 = lorries.Select(l => l);
            Printer.Print(q1);

            // +-+-+-+-+-+-+ [2] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tSelecting a separate field");
            var q2 = lorries.Select(l => l.Brand);
            Printer.Print(q2);

            // +-+-+-+-+-+-+ [3] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tCreating an anonymous object");
            var q3 = lorries.Select(l => new { brand = l.Brand, date = l.ReleaseDate });
            Printer.Print(q3);

            // +-+-+-+-+-+-+ [4] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tConditions");
            // selecting all lorries with brand [brand1] and that lorries which have release day [Wednesday] and older
            var q4 = lorries.Where(l => l.Brand == "brand1" && 
                                   l.ReleaseDate.DayOfWeek >= DayOfWeek.Wednesday);
            Printer.Print(q4);

            // +-+-+-+-+-+-+ [5] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tSorting");
            var q5 = lorries.Where(l => l.LoadCapacity >= 150 && l.LoadCapacity <= 250)
                            .OrderByDescending(l => l.MajorRepairDate)
                            .OrderByDescending(l => l.ReleaseDate);
            Printer.Print(q5);

            // +-+-+-+-+-+-+ [5.1] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tSorting using extended methods");
            var q5_1 = lorries.Where(l => l.LoadCapacity > 200)
                              .OrderBy(l => l.ReleaseDate)
                              .ThenByDescending(l => l.MajorRepairDate);
            Printer.Print(q5_1);

            // +-+-+-+-+-+-+ [6] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tInner join");
            var q6 = lorries.Join(autoParks,
                                 l => l.AutoParkCipher,
                                 a => a.Cipher,
                                 (l, a) => new { Brand = l.Brand, AutoPark = a.Name });
            Printer.Print(q6);

            // +-+-+-+-+-+-+ [7] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tMax aggregate function using where filter");
            // get all lorries which have max load capacity
            var q7 = lorries.Where(l => l.LoadCapacity == lorries
                            .Max(l => l.LoadCapacity));
            Printer.Print(q7);

            // +-+-+-+-+-+-+ [8] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tSkip");
            var q8 = lorries.OrderByDescending(l => l.LoadCapacity)
                            .Skip(2);
            Printer.Print(q8);

            Console.WriteLine("\t\tSkipWhile & Take");
            var q8_1 = lorries.SkipWhile(l => l.StateNumber == "number2")
                              .Take(3);
            Printer.Print(q8_1);

            // +-+-+-+-+-+-+ [9] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tExcept");
            var q9 = lorries.Except(anotherLorries);
            Printer.Print(q9);

            // +-+-+-+-+-+-+ [10] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tIntersect");
            var q10 = lorries.Intersect(anotherLorries);
            Printer.Print(q10);

            // +-+-+-+-+-+-+ [11] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tUnion");
            var q11 = lorries.Union(anotherLorries);
            Printer.Print(q11);

            // +-+-+-+-+-+-+ [12] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tJoin with where filter");
            var q12 = lorries.Join(autoParks,
                                 l => l.AutoParkCipher,
                                 a => a.Cipher,
                                 (l, a) => new { Parking = a.Name, Brand = l.Brand, ProduceDate = l.ReleaseDate })
                            .Where(n => n.ProduceDate.Year >= 2018);
            Printer.Print(q12);

            // +-+-+-+-+-+-+ [13] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tDictinct");
            var data = new List<Lorry>();
            data.AddRange(lorries);
            data.AddRange(anotherLorries);
            data = data.Distinct().ToList();
            Printer.Print(data);

            // +-+-+-+-+-+-+ [14] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tGroup by");
            var q14 = lorries.GroupBy(l => l.AutoParkCipher);
            foreach (var item in q14)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
            // +-+-+-+-+-+-+ [15] +-+-+-+-+-+-+ \\
            Console.WriteLine("\t\tBrand starts with & order by");
            var q15 = lorries.Where(l => l.Brand.StartsWith("bra")).OrderBy(l => l.Brand);
            Printer.Print(q15);
        }

    }
}
