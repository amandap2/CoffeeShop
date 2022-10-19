using System;

namespace CoffeeShop 
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Olá! O que gostaria de pedir?");
            //Console.ReadLine();

            Cappuccino cappuzinho = new Cappuccino(typeof(Cappuccino).Name);
            //Latte lattezinho = new Latte(typeof(Latte).Name);
            //Macchiato macchiatinho = new Macchiato(typeof(Macchiato).Name);

            Console.WriteLine(cappuzinho.Description() + ": " + cappuzinho.Cost());

            Sugar sugarAdd = new Sugar(cappuzinho);

            Console.WriteLine(sugarAdd.Description() + ": " + sugarAdd.Cost());

            Milk milkAdd = new Milk(sugarAdd);

            Console.WriteLine(milkAdd.Description() + ": " + milkAdd.Cost());

            Console.ReadLine();
        }
    }
}
