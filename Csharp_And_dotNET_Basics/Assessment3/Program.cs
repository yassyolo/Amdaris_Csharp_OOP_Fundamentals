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

Console.WriteLine("Animals in the zoo before cloning:");
zoo.DisplayAnimals();

foreach (var animal in zoo)
{
    animal.Sound();
    animal.Eat();
}

penguin.Equals(tiger);
penguin.Equals(bear);

Zoo clonedZoo = (Zoo)zoo.Clone();

Console.WriteLine("Animals in the zoo after cloning:");
clonedZoo.DisplayAnimals();

tiger.Purr();
bear.Hibernate();
penguin.Swim();

Console.ReadLine();


