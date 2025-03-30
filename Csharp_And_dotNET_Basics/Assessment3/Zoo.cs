using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Assessment3
{
    public class Zoo : IEnumerable<Animal>, ICloneable
    {
        private List<Animal> _animals;

        public Zoo()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public object Clone()
        {
            Zoo clonedZoo = new Zoo();
            foreach (var animal in _animals)
            {
                clonedZoo.AddAnimal((Animal)animal.Clone());
            }
            return clonedZoo;
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return new AnimalEnumerator(_animals);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void DisplayAnimals()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal.ToString());
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
