using System;

public class ProgramFruit
{
	static void Main(string[] args)
	{
        // Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
        // TODO: Implement this part three.
        //Status

        ItemManager<Fruit> fruitList = new ItemManager<Fruit> { };
        int NumberOfFruitsToAdd = 0;
        System.Console.WriteLine("How many fruits would you like to add?");
        NumberOfFruitsToAdd = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < NumberOfFruitsToAdd; i++)
        {
            Console.WriteLine("What fruit would you like to add: ");
            String? fruitName = Console.ReadLine();
            if (!String.IsNullOrEmpty(fruitName))
            {
                Fruit f = new Fruit(fruitName);
                fruitList.AddItem(f);
            }
            else
            {
                Console.WriteLine("No input for the fruit name.");
            }
        }
        fruitList.PrintAllItems();
    }
}
