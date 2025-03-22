using Assessment3;

Zoo zoo = new Zoo();

Tiger tiger = new Tiger("Kotio", "SoftUni", "Bengal", 2);
zoo.AddAnimal(tiger);

Tiger tiger2 = new Tiger("Murcho", "Billa", "Bengal", 2);
zoo.AddAnimal(tiger2);

Bear bear = new Bear("Bobi", "ProCredit Bank", "Grizzly", 3);
zoo.AddAnimal(bear);

Penguin penguin = new Penguin("Pingu", null, "Emperor", 1);
zoo.AddAnimal(penguin);

Console.WriteLine("Zoo Animals:");
zoo.DisplayAnimals();

foreach (var animal in zoo)
{
    animal.Sound();
    animal.Eat();
}

Zoo clonedZoo = (Zoo)zoo.Clone();

Console.WriteLine("Cloned Zoo Animals:");
clonedZoo.DisplayAnimals();


