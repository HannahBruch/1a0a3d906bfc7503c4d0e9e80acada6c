
public class Garage : ParkingLocation
{
    public int MaxCompactSpaces;
    public int AvailableCompactSpaces;

    public Garage(int maxSpaces, int maxCompactSpaces) : base(maxSpaces)
    {
        MaxCompactSpaces = maxCompactSpaces;
        AvailableCompactSpaces = maxCompactSpaces;
    }

    public override void ParkVehicle(Vehicle vehicle)
    {
        // One might think that it would be less verbose to just check if the vehicle 
        // type is a bus, and only deny busses. While that approach is less verbose, 
        // what happens if we made a new type of vehicle, like a tractor? Or if we just passed
        // this method a Vehicle type, instead of one of it's children. The description says
        // that Garages can ONLY accommodate cars and motorcycles, so we explicity say only cars 
        // and motorcycles can be used.
        if (vehicle.GetType() != typeof(Car) || vehicle.GetType() != typeof(Motorcycle)) {
            throw new ArgumentException("Only cars and motorcycles can be parked in garages");
        } 
        else if (AvailableSpaces <= 0 ) {
            throw new InvalidOperationException("There is no space left in the lot");
        } else {
            ParkedVehicles.Add(vehicle);
            if (vehicle.Weight < 1500)
                AvailableCompactSpaces--;
            else
                AvailableSpaces--;
        }
    }
    public override void UnparkVehicle(Vehicle vehicle)
    {
        ParkedVehicles.Remove(vehicle); 
        if (vehicle.Weight < 1500)
            AvailableCompactSpaces++;
        else
            AvailableSpaces++;
    }
}