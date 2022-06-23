using N1_V16.Models;
using System;
using System.Collections.Generic;

namespace N1_V16.Services
{
    /// <summary>
    /// class to initialize data
    /// </summary>
    internal static class DataInitializer
    {
        /// <summary>
        /// method to get list of lorries
        /// </summary>
        /// <returns>list of lorries</returns>
        public static List<Lorry> GetLorries()
        {
            return new List<Lorry>()
            {
                new Lorry("brand1", new DateTime(2017, 7, 20), "number1", "cipher1", 250, new DateTime(2020, 12, 20)),
                new Lorry("brand2", new DateTime(2018, 3, 19), "number2", "cipher2", 300, new DateTime(2021, 10, 23)),
                new Lorry("brand3", new DateTime(2019, 2, 2), "number3", "cipher3", 150, new DateTime(2019, 3, 15)),
                new Lorry("brand4", new DateTime(2018, 5, 4), "number4", "cipher4", 250, new DateTime(2020, 6, 2)),
                new Lorry("brand5", new DateTime(2019, 3, 2), "number5", "cipher5", 100, new DateTime(2022, 2, 20)),
                new Lorry("brand1", new DateTime(2018, 2, 17), "number6", "cipher5", 250, new DateTime(2020, 1, 18)),
                new Lorry("brand1", new DateTime(2016, 10, 3), "number7", "cipher5", 200, new DateTime(2018, 4, 17))
            };
        }

        /// <summary>
        /// method to get list of lorries
        /// </summary>
        /// <returns>list of lorries</returns>
        public static List<Lorry> GetMoreLorries()
        {
            return new List<Lorry>()
            {
                new Lorry("brand1", new DateTime(2017, 7, 20), "number1", "cipher1", 250, new DateTime(2020, 12, 20)),
                new Lorry("brand2", new DateTime(2018, 3, 19), "number2", "cipher2", 300, new DateTime(2021, 10, 23)),
                new Lorry("brand3", new DateTime(2019, 2, 2), "number3", "cipher3", 150, new DateTime(2019, 3, 15)),
            };
        }

        /// <summary>
        /// method to get list of taxis
        /// </summary>
        /// <returns>list of taxis</returns>
        public static List<Taxi> GetTaxis()
        {
            return new List<Taxi>()
            {
                new Taxi("brand1", DateTime.Now.AddMonths(-13), "number8", "cipher1", 4),
                new Taxi("brand2", DateTime.Now.AddMonths(-12), "number9", "cipher2", 8),
                new Taxi("brand3", DateTime.Now.AddMonths(-7), "number10", "cipher3", 5),
                new Taxi("brand4", DateTime.Now.AddMonths(-1), "number11", "cipher1", 2),
                new Taxi("brand4", DateTime.Now.AddMonths(-9), "number12", "cipher4", 4),
                new Taxi("brand4", DateTime.Now.AddMonths(-3), "number13", "cipher1", 4)
            };
        }

        /// <summary>
        /// method to get list of auto parks
        /// </summary>
        /// <returns>list of parks</returns>
        public static List<AutoPark> GetAutoParks()
        {
            return new List<AutoPark>()
            {
                new AutoPark("auto park1", "address1", 350, "cipher1"),
                new AutoPark("auto park2", "address2", 500, "cipher2"),
                new AutoPark("auto park3", "address3", 300, "cipher3"),
                new AutoPark("auto park4", "address4", 120, "cipher4"),
                new AutoPark("auto park5", "address5", 520, "cipher5"),
                new AutoPark("auto park6", "address6", 100, "cipher6"),
                new AutoPark("auto park7", "address7", 50, "cipher7")
            };
        }
    }
}
