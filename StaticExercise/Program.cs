namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"Celsius Temp is {celsius}");
            Console.WriteLine($"Fahrenheit Temp is {fahrenheit}");
        }
    }
}
