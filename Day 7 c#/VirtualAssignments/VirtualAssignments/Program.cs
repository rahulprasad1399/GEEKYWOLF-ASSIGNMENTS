namespace ConsoleApp
{
    public class ConsoleApp
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Dog dog = new Dog();    
            dog.Speak();

            Animal dogAnimal = new Dog();
            dogAnimal.Speak();    
            
            Cat cat = new Cat();
            cat.Speak();
        }
    }
}
