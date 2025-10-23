namespace VechileAssignment
{
    public class VechileAssignment
    {
        static void Main(string[] args)
        {
            Vechile vechile = new Vechile();
            vechile.ShowType();

            Car car = new Car();
            car.ShowType();

            Vechile carVechile = new Car();
            carVechile.ShowType();
        }
    }
}
