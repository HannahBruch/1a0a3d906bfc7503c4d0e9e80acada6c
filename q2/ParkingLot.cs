public class ParkingLot : ParkingLocation
{
    public ParkingLot(int maxSpaces) : base(maxSpaces) {
    }
    public override void ParkVehicle(Vehicle vehicle)
    {
        if (AvailableSpaces <= 0) {
            throw new InvalidOperationException("There is no space left in the lot");
        } else {
            ParkedVehicles.Add(vehicle);
            AvailableSpaces--;
        }
    }
    public override void UnparkVehicle(Vehicle vehicle) {
        ParkedVehicles.Remove(vehicle); 
        AvailableSpaces++; 
    }
}