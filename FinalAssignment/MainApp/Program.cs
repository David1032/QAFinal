namespace MainApp
{
    public class Program
    {
        public static bool CanDrive(int age)
        {
            const int drivingAge = 16;
            return age >= drivingAge;
        }

        static void Main(string[] args)
        {
            // Example usage
            System.Console.WriteLine("Can drive (age 15): " + CanDrive(15)); // Output: False
            System.Console.WriteLine("Can drive (age 18): " + CanDrive(18)); // Output: True
        }
    }
}