using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //I Want cheese corn pizza, tell me the cost

            IPizza pizza = new PizzaBase();
            IPizza cheesePizza = new CheeseDecorator(pizza);
            IPizza cheeseCornPizza = new CornToppingsDecorator(cheesePizza);

            int totalCost = cheeseCornPizza.GetCost();
            string pizzaType = cheeseCornPizza.GetPizzaType();
            Console.WriteLine($"Your total Pizza Cost for {pizzaType} is {totalCost}");

            //I want 1 margerita
            IPizza pizza1 = new MargritaPizza();
            int pizzaCost = pizza1.GetCost();
            string pizzaType1 = pizza1.GetPizzaType();

            Console.WriteLine($"Your total pizza cost for {pizzaType1} is {pizzaCost}");


            //Margrita with extra cheese
            IPizza pizza2 = new MargritaPizza();
            IPizza extraCheese = new CheeseDecorator(pizza2);

            int cost = extraCheese.GetCost();
            string pizzaType2 = extraCheese.GetPizzaType();

            Console.WriteLine(String.Format("Pizza cost for {0} is {1}", pizzaType2, cost));
            Console.Read();

        }
    }
}
