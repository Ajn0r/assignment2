namespace Assignment2;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Title = "Stringsm selection and iteration in C#";
        FunFeatures funObj = new FunFeatures();
        funObj.Start();

        ContinueToNextPart();

        // Start MathWork
        Console.Title = "Let's work with numbers!";
        MathWork calc = new MathWork();
        calc.Start();

        ContinueToNextPart();

        // Start Temp converter
        Console.Title = "Temperature Converter";
        TemperatureConverter tempCon = new TemperatureConverter();
        tempCon.Start();

        ContinueToNextPart();

        // Start working schedule
        Console.Title = "Working Schedule";
        WorkingSchedule schedule = new WorkingSchedule();
        schedule.Start();
    }


    private static void ContinueToNextPart()
    {
        Console.WriteLine("\nPress enter to continue to the next part");
        Console.ReadLine();
        Console.Clear();

    }
}