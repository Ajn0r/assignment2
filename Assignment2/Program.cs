namespace Assignment2;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Title = "Stringsm selection and iteration in C#";
        FunFeatures funObj = new FunFeatures();
        //funObj.Start();

        //ContinueToNextPart();

        // Start MathWork
        Console.Title = "Let's work with numbers!";
        MathWork calc = new MathWork();
        //calc.Start();

        // Start Temp converter
        Console.Title = "Temperature Converter";
        TemperatureConverter tempCon = new TemperatureConverter();
        tempCon.Start();
    }


    private static void ContinueToNextPart()
    {
        throw new NotImplementedException();
    }
}