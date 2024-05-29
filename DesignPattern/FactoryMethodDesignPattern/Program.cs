using FactoryMethodDesignPattern.Factory;
using FactoryMethodDesignPattern.Product;

internal class Program
{
    private static void Main()
    {
        IFanFactory fanFactory = new TableFanFactory();
        IFan fan = fanFactory.CreateFan();
        fan.SwitchOn();

        //If I want to add new ExhaustFan product
        //Step 1 : Create ExhaustFan product
        //Step2: Create ExhaustFanFactory which will return product

        IFanFactory fanFactory1 = new ExhaustFanFactory();
        IFan fan1 = fanFactory1.CreateFan();
        fan1.SwitchOn();

        Console.Read();

    }
}