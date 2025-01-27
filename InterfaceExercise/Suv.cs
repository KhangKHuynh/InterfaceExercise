using System;

namespace InterfaceExercise;

public class Suv : IVehicle, ICompany
{
    public double EngineSize { get; set; } = 2.5;
    public string Model { get; set; } = "Toyota";
    public string Make { get; set; } = "Rav4";
    public int SeatCount { get; set; } = 4;
    public string Name { get; set; } = "Toyota";
    public string Motto { get; set; } = "Let's Go Places";
    public bool HasChangedGears { get; set; }

    
    public void Drive()
    {
        Console.WriteLine($"{GetType().Name} now driving forward. . .");
    }
    
    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now reversing. . .");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't reverse until we change gears.");
        }
        
    }

    public void Park()
    {
        if (HasChangedGears == true) 
        {
            Console.WriteLine($"{GetType().Name} now in park. . .");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't park until we change gears.");
        }
    }

    public void ChangeGears(bool isChanged)
    {
        HasChangedGears = isChanged;
    }
}
