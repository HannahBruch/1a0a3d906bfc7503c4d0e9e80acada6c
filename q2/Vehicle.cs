public class Vehicle
{
    // I only allow setters for length, weight, passenger count, and ParkingLocation. 
    // A car's make and model can never be changed, but a car's weight, 
    // length, and the amount of max passengers can. 
    public string Make {get;}
    public string Model {get; }
    public float Length {get; set;}
    public float Weight {get; set;}
    public int MaxPassengers {get; set;}

    public ParkingLocation? ParkingLocation {get; set;}

    public Vehicle(string make, string model, float length, float weight, int maxPassengers)
    {
        Make = make;
        Model = model;
        Length = length;
        Weight = weight;
        MaxPassengers = maxPassengers;
        ParkingLocation = null;
    }

}