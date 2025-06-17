class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Item Manager!");

        ItemManager manager = new ItemManager();

        // Part One: Fix the NullReferenceException
        // This will throw a NullReferenceException
        //Status: Fixed
        manager.AddItem("Apple");
        manager.AddItem("Banana");

        manager.PrintAllItems();

        // Part Two: Implement the RemoveItem method
        //Status: Done
        manager.RemoveItem("Apple");
        // Part Four (Bonus): Implement an interface IItemManager and make ItemManager implement it.
        // TODO: Implement this part four.
        //Interface
    }
}
// Part Four (Bonus): Implement an interface IItemManager and make ItemManager implement it.
// TODO: Implement this part four.
//Status: Success
//Interface
public interface ItemManager1
{
    void AddItem(String item);
    void PrintAllItems();
    void RemoveItem(String item);
    void ClearAllItems();
}

public class ItemManager : ItemManager1
{
    private List<string> items = new List<string>() { };

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    // Part Two: Implement the RemoveItem method
    // TODO: Implement this method
    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"{item} is successfully removed.");
        }
        else
        {
            Console.WriteLine($"{item} is not found. Please try again.");
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

public class ItemManager<T>
{
    private List<T> items = new List<T>() { };

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}
// Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
public class Fruit
{
    public String fruitName;
    //Normal Constructor
    public Fruit(String fN)
    {
        this.fruitName = fN;
    }
    //Setter
    public void setFruit(String fN)
    {
        this.fruitName = fN;
    }
    //Getter
    public String getFruit()
    {
        return fruitName;
    }
    //Print FruitDetails
    public void printFruitDetails()
    {
        Console.WriteLine($"The fruit is {fruitName}.");
    }
    public override string ToString()
    {
        return($"The fruit is {fruitName}.");
    }
}