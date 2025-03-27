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
            private List<Animal> _animals;
            private int _currentIndex;

            public AnimalEnumerator(List<Animal> animals)
            {
                _animals = animals;
                _currentIndex = -1;
            }

            public Animal Current
            {
                get
                {
                    if(_currentIndex < 0 || _currentIndex >= _animals.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return _animals[_currentIndex];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if(_currentIndex < _animals.Count - 1)
                {
                    _currentIndex++;
                    return true;
                }
                return false;
            }

            public void Reset() => _currentIndex = -1;
            
        }
    }
}
