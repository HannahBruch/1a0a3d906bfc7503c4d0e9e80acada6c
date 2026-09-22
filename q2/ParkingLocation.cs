using System.Runtime.CompilerServices;

public abstract class ParkingLocation
{
    public int MaxSpaces {get; }
    public int AvailableSpaces {get; set;}
    public List<Vehicle> ParkedVehicles {get; set;}
    public ParkingLocation(int maxSpaces)
    {
        MaxSpaces = maxSpaces;
        AvailableSpaces = maxSpaces;
        ParkedVehicles = new List<Vehicle>();
    }
    
    // Since we probably don't want to instantiate a ParkingLocation, 
    // I made the class abstract, and required the children to implement 
    // ParkVehicle and UnparkVehicle in their own definitions. This works well
    // because these classes would need to override these methods anyways, since
    // the types of vehicles that can be parked in a Garage are different than in 
    // a ParkingLot, and because a Garage also has compact spaces.
    public abstract void ParkVehicle(Vehicle vehicle);
    public abstract void UnparkVehicle(Vehicle vehicle);
}