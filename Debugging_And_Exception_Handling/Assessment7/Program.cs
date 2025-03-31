using Assessment7.Entities;
using Assessment7.Exceptions;

Car myCar = new Car();
bool needsMaintenance = true;

#if DEBUG
Console.WriteLine("Lets ride!!");
#endif

try
{
    Console.Write("Enter speed: ");
    int speed = int.Parse(Console.ReadLine());
    myCar.Speed = speed;

    myCar.Drive();

    if (needsMaintenance)
    {
        myCar.Maintenance(true, true); 
    }

    myCar.Drive();
}
catch (TooFastException ex)
{
    Console.WriteLine($"{typeof(TooFastException)} -> {ex.Message}");
}
catch (OutOfFuelException ex)
{
    Console.WriteLine($"{typeof(OutOfFuelException)} -> {ex.Message}");
    throw;  
}
catch (EngineFailureException ex)
{
    Console.WriteLine($"{typeof(EngineFailureException)} -> {ex.Message}");
    throw;  
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong");
    throw;  
}
finally
{
    Console.WriteLine("Have a safe drive!");
}
        