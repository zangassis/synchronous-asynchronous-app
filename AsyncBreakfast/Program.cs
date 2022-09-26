using AsyncBreakfast.Models;

var initialTime = DateTime.Now.Second;

await BreakfastProcess();

async Task BreakfastProcess()
{
    var breakfast = new Breakfast();
    var coffeeTask = breakfast.Coffee.PourCoffee(1);
    var baconTask = breakfast.Bacon.FryBacon(2);
    var eggTask = breakfast.Egg.FryEggs(2);
    var juiceTask = breakfast.Juice.PourJuice();

    var breakfastTasks = new List<Task> { coffeeTask, baconTask, eggTask, juiceTask };

    while (breakfastTasks.Count > 0)
    {
        Task finishedTask = await Task.WhenAny(breakfastTasks);

        if (finishedTask == coffeeTask)
        {
            Console.WriteLine("Coffee are ready");
        }
        else if (finishedTask == baconTask)
        {
            Console.WriteLine("Bacon is ready");
        }
        else if (finishedTask == eggTask)
        {
            Console.WriteLine("Egg is ready");
        }
        else if (finishedTask == juiceTask)
        {
            Console.WriteLine("Juice is ready");
        }
        breakfastTasks.Remove(finishedTask);
    }
}

var finishTime = DateTime.Now.Second;
Console.WriteLine($"Breakfast is ready! The process took {finishTime - initialTime} seconds");

