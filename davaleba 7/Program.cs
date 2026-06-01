using System.ComponentModel.Design;

namespace davaleba7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../CarsData.txt";

            string[] lines = File.ReadAllLines(path);

            Cars[] car = new Cars[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                car[i] = new Cars();

                car[i].Make = parts[0];
                car[i].Model = parts[1];
                car[i].Year = int.Parse(parts[2]);
                car[i].Price = int.Parse(parts[3]);
                car[i].Color = parts[4];
            }

            foreach (Cars item in car)
            {
                Console.WriteLine($"Brand: {item.Make} {item.Model}, Year: {item.Year}, Price: {item.Price}, Color: {item.Color}");
            }

            FilterByBrandAndModel(car, "Toyota", "h");
            FilterByYear(car, 2022);
            FilterByPriceRange(car, 20000, 30000);
            CountByColor(car, "White");
            PrintTotalValue(car);
        }


        #region first method
        // filter by model
        public static void FilterByBrandAndModel(Cars[] cars, string brand, string model)
        {
            bool found = false;
            foreach (Cars item in cars)
            {
                if (item != null && item.Make == brand && item.Model == model)
                {
                    Console.WriteLine($"'first method'FOUND! -> Brand: {item.Make} {item.Model}, Year: {item.Year}, Price: {item.Price}, Color: {item.Color}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($" 'first method' No matches found for {brand} {model}. Check for text typos!");
            }
        }

        #endregion

        #region second method
        //filter by year. 
        public static void FilterByYear(Cars[] cars, int year)
        {
            int count = 0;
            foreach (Cars item in cars)
            {
                if (item != null && item.Year == year)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"'second method' No matches found for year {year}");
                return;
            }

            Cars[] sameYearCars = new Cars[count];
            int index = 0;
            foreach (Cars item in cars)
            {
                if (item != null && item.Year == year)
                {
                    sameYearCars[index] = item;
                    index++;
                }
            }

            Console.WriteLine("'second' Found {sameYearCars.Length} cars from the year {year}");
            foreach (Cars matchingCar in sameYearCars)
            {
                Console.WriteLine($"{matchingCar.Make} {matchingCar.Model} (${matchingCar.Price})");
            }
        }
        #endregion

        #region third method

        //filter by price range
        public static void FilterByPriceRange(Cars[] cars, int minPrice, int maxPrice)
        {
            string summary = "";
            bool found = false;
            foreach (Cars item in cars)
            {
                if (item != null && item.Price >= minPrice && item.Price <= maxPrice)
                {
                    summary += $"{item.Make} {item.Model} (${item.Price})\n";
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine($"==================================================");
                Console.WriteLine($"these cars are in yourr budget (${minPrice} - ${maxPrice}):");
                Console.WriteLine($"==================================================");
                Console.Write(summary);
                Console.WriteLine($"==================================================");
            }
            else
            {
                Console.WriteLine($"'third method' No matches found for price range ${minPrice} - ${maxPrice}.");
            }
        }

        #endregion

        #region fourth method

        public static void CountByColor(Cars[] cars, string color)
        {
            int count = 0;
            foreach (Cars c in cars)
            {
                if (c != null && c.Color == color) count++;
            }
            Console.WriteLine($"{color} feris manqanis raodenobaa {count}");
        }
        #endregion

        #region fifth method
        public static void PrintTotalValue(Cars[] cars)
        {
            int total = 0;
            foreach (Cars c in cars)
            {
                if (c != null) total += c.Price;
            }
            Console.WriteLine($"manqanebis jamuri fasi: ${total}");
        }
        #endregion


    }
}