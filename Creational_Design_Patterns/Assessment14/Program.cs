using Assessment14;
using Assessment14.Factories;
using Assessment14.Models;

CoffeeFactory espressoFactory = new EspressoFactory();
CoffeeFactory cappuccinoFactory = new CappuccinoFactory();
CoffeeFactory flatWhiteFactory = new FlatWhiteFactory();
MilkFactory oatMilkFactory = new OatMilkFactory();
MilkFactory regularMilkFactory = new RegularMilkFactory();
MilkFactory soyMilkFactory = new SoyMilkFactory();

Coffee espresso = espressoFactory.MakeCoffee();
espresso.AddIngredient("Sugar");
espresso.AddIngredient(soyMilkFactory.UseMilk().Name);
Console.WriteLine(espresso.ToString());

Coffee cappuccino = cappuccinoFactory.MakeCoffee();
cappuccino.AddIngredient("Sugar");
Console.WriteLine(cappuccino.ToString());

Coffee flatWhite = flatWhiteFactory.MakeCoffee();
flatWhite.AddIngredient("Sugar");
flatWhite.AddIngredient("Sugar");

Console.WriteLine(flatWhite.ToString());