namespace AsyncBreakfast.Models;
public class Breakfast
{
    public Coffee Coffee { get; set; } = new Coffee();
    public Bacon Bacon { get; set; } = new Bacon();
    public Egg Egg { get; set; } = new Egg();
    public Juice Juice { get; set; } = new Juice();
}

public class Coffee
{
    public async Task<Coffee> PourCoffee(int cup)
    {
        Console.WriteLine($"Pouring {cup} of coffee");
        await Task.Delay(1000);
        return new Coffee();
    }
}

public class Bacon
{
    public async Task<Bacon> FryBacon(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Cooking a slice of bacon");
            await Task.Delay(2000);
        }
        return new Bacon();
    }
}

public class Egg
{
    public async Task<Egg> FryEggs(int eggs)
    {
        for (int egg = 0; egg < eggs; egg++)
        {
            Console.WriteLine("Cooking a egg");
            await Task.Delay(millisecondsDelay: 3000);
        }
        return new Egg();
    }
}

public class Juice
{
    public async Task<Juice> PourJuice()
    {
        Console.WriteLine("Pouring orange juice");
        await Task.Delay(1000);
        return new Juice();
    }
}
