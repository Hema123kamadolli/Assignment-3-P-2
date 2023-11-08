using System;
 namespace ConversionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            string intStr = "10";  // Using TryParse to convert a string to an integer and multiply by 5
            if (int.TryParse(intStr, out int intValue))
            {
                int result = intValue * 5;
                Console.WriteLine($"TryParse Result: {result}");
            }
            else
            {
                Console.WriteLine("TryParse Error: Invalid integer format.");
            }

            
            string dateStr = "2023-11-08"; // Using Convert to convert a string to a DateTime with error handling
            try
            {
                DateTime dateValue = Convert.ToDateTime(dateStr);
                dateValue = dateValue.AddMonths(-1);
                Console.WriteLine($"Convert Result: {dateValue:yyyy-MM-dd}");
            }
            catch (Exception)
            {
                Console.WriteLine("Convert Error: Invalid date format.");
            }

            
            string timeSpanStr = "02:30:00"; // Using Parse to convert a string to a TimeSpan with error handling
            try
            {
                TimeSpan timeSpanValue = TimeSpan.Parse(timeSpanStr);
                timeSpanValue = timeSpanValue.Add(new TimeSpan(2, 0, 0)); // Adding 2 hours
                Console.WriteLine($"Parse Result: {timeSpanValue}");
            }
            catch (Exception)
            {
                Console.WriteLine("Parse Error: Invalid TimeSpan format.");

            }
            Console.ReadKey();
        }
    }
}
        
    

