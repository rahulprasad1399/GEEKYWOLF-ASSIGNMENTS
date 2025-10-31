using TemperatureConverterLibrary;

namespace TemperatureConsoleApp
{
    public class MyProgram
    {
        static void Main(String[] args)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            double celsiusToFarenheit = temperatureConverter.FahrenheitToCelsius(60);
            Console.WriteLine(celsiusToFarenheit <= 0 ? "Enter a Valid Temperature" : celsiusToFarenheit);
        }
    }
}