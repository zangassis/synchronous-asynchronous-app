using SyncBreakfast.Models;

var initialTime = DateTime.Now.Second;

var breakfast = new Breakfast();

var coffee = breakfast.Coffee.PourCoffee(1);
Console.WriteLine("Coffee is ready");

var bacon = breakfast.Bacon.FryBacon(2);
Console.WriteLine("Bacon is ready");

var egg = breakfast.Egg.FryEggs(2);
Console.WriteLine("Egg is ready");

var juice = breakfast.Juice.PourJuice();
Console.WriteLine("Juice is ready");

var finishTime = DateTime.Now.Second;

Console.WriteLine($"Breakfast is ready! The process took {finishTime - initialTime} seconds");
