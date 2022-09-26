namespace SyncBreakfast.Models;
public class Breakfast
{
    public Coffee Coffee { get; set; } = new Coffee();
    public Bacon Bacon { get; set; } = new Bacon();
    public Egg Egg { get; set; } = new Egg();
    public Juice Juice { get; set; } = new Juice();
} 

public class Coffee
{
    public Coffee PourCoffee(int cup)
    {
        Console.WriteLine($"Pouring {cup} of coffee");
        Task.Delay(1000).Wait();
        return new Coffee();
    }
}

public class Bacon
{
    public Bacon FryBacon(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Cooking a slice of bacon");
            Task.Delay(2000).Wait();
        }
        return new Bacon();
    }
}

public class Egg
{
    public Egg FryEggs(int eggs)
    {
        for (int egg = 0; egg < eggs; egg++)
        {
            Console.WriteLine("Cooking a egg");
            Task.Delay(3000).Wait();
        }
        return new Egg();
    }
}

public class Juice
{
    public Juice PourJuice()
    {
        Console.WriteLine("Pouring orange juice");
        Task.Delay(1000).Wait();
        return new Juice();
    }
}
