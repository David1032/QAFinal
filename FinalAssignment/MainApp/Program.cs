namespace MainApp
{
    public class Program
    {
        public static bool CanDrive(int age)
        {
            const int drivingAge = 16;
            return age >= drivingAge;
        }
    }
}