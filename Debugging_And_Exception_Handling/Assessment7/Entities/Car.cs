using Assessment7.Exceptions;

namespace Assessment7.Entities
{
    internal class Car
    {
        private int _speed;
        private bool _isOutOfFuel = false;
        private bool _isEngineBroken = false;
        private int _fuelLevel = 100;
        private int _engineHealth = 100;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value > 60)
                {
                    throw new TooFastException($"Maximum speed is 60 km/h, slow down!");
                }
                _speed = value;
            }
        }

        public void Drive()
        {
            if (_isOutOfFuel)
            {
                throw new OutOfFuelException("Out of fuel! Charge now!");
            }

            if (_isEngineBroken)
            {
                throw new EngineFailureException("Engine is broken!");
            }

            _fuelLevel -= 5;
            _engineHealth -= 2;

            if (_fuelLevel <= 0)
            {
                _isOutOfFuel = true;
            }

            if (_engineHealth <= 0)
            {
                _isEngineBroken = true;
            }

            Console.WriteLine(ToString());
        }

        public void Refuel()
        {
            _fuelLevel = 100;
            _isOutOfFuel = false;
            Console.WriteLine("Car has been refueled!");
        }

        public void RepairEngine()
        {
            _engineHealth = 100;
            _isEngineBroken = false;
            Console.WriteLine("Engine is good now!");
        }

        public void Maintenance(bool needsRefueling = false, bool needsRepair = false)
        {
            try
            {
                if (needsRefueling)
                {
                    Refuel();
                }

                if (needsRepair)
                {
                    RepairEngine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
                throw;
            }
        }

        public override string ToString()
        {
            return $"Speed: {Speed}, Fuel Level: {_fuelLevel}, Engine Health: {_engineHealth}";
        }
    }
}
