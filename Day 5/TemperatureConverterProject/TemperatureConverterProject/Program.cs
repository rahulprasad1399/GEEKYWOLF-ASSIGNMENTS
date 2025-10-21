namespace TemperatureConverterLibrary
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            if (!TemperatureValidator.IsTemperatureValidCelsius(celsius)){
                Console.WriteLine("Please Enter a Valid Temperature");
                return 0;
            }
            return (celsius * 9.0 / 5.0) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            if (!TemperatureValidator.IsTemperatureValidFarenheit(fahrenheit)){
                Console.WriteLine("Please Enter a Valid Temperature");
            }
            return (fahrenheit - 32) * 5.0 / 9.0;
        }

        internal class TemperatureValidator
        {
            public static double MinTemperatureCelsius = -273.15;
            public static double MaxTemperatureCelsius = 5500;

            public static bool IsTemperatureValidCelsius(double celsius)
            {
                return celsius > MinTemperatureCelsius && celsius < MaxTemperatureCelsius;
            }

            public static bool IsTemperatureValidFarenheit(double fahrenheit) {
                double celsius = (fahrenheit - 32) * 5.0 / 9.0;
                return IsTemperatureValidCelsius (celsius);
            }
        }
    }
}
