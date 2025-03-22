using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Assessment3
{
    public class Zoo : IEnumerable<Animal>, ICloneable
    {
        private List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public object Clone()
        {
            Zoo clonedZoo = new Zoo();
            foreach (var animal in animals)
            {
                clonedZoo.AddAnimal((Animal)animal.Clone());
            }
            return clonedZoo;
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return new AnimalEnumerator(animals);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void DisplayAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}, Age: {animal.AgeCategory}, Breed: {animal.Breed}, Sponsor: {animal.Sponsor}");
            }
        }

        private class AnimalEnumerator : IEnumerator<Animal>
        {
            private List<Animal> animals;
            private int currentIndex;

            public AnimalEnumerator(List<Animal> animals)
            {
                this.animals = animals;
                currentIndex = -1;
            }

            public Animal Current
            {
                get
                {
                    if(currentIndex < 0 || currentIndex >= animals.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return animals[currentIndex];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if(currentIndex < animals.Count - 1)
                {
                    currentIndex++;
                    return true;
                }
                return false;
            }

            public void Reset() => currentIndex = -1;
            
        }
    }
}
