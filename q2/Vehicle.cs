public class Vehicle
{
    // I only allow setters for length, weight, and passenger count. 
    // A car's make and model can never be changed, but a car's weight, 
    // length, and the amount of max passengers can. 
    public string Make {get;}
    public string Model {get; }
    public float Length {get; set;}
    public float Weight {get; set;}
    public int MaxPassengers {get; set;}

    public ParkingLocation? ParkingLocation = null;

    public Vehicle(string make, string model, float length, float weight, int maxPassengers)
    {
        Make = make;
        Model = model;
        Length = length;
        Weight = weight;
        MaxPassengers = maxPassengers;
    }
    
    // The ParkingLocation should decide if a vehicle is valid. If it isn't, it throws an exception. 
    // It means we don't have to reimplement Park and Unpark in Vehicle's children classes. 
    // The exception will be thrown up to the caller. 
    // Part of me wishes I could use a java-style "throws Exception" pattern to let the caller know
    // that they have to be ready to handle an exception
    public void Park(ParkingLocation p)
    {
        try {
            p.ParkVehicle(this);
            ParkingLocation = p;
        } catch (Exception e)
        {
            throw e;
        }
    }    
    public void Unpark()
    {
        if (ParkingLocation != null) {   
            ParkingLocation.UnparkVehicle(this);
            ParkingLocation = null;
        }
    }
}