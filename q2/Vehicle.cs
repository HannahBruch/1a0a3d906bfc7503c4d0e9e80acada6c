public class Vehicle
{
// I made make and model immutable, as that's what they are in real life.
    public readonly string Make;
    public readonly string Model;
    public float Length {get; set;}
    public float Weight {get; set;}
    public int MaxPassengers {get; set;}

    public ParkingLocation? ParkingLocation {get; set; }

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