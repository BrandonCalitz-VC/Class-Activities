//base class for vehicles
public class Vehicle
{
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public double MaxSpeed { get; set; }
  public string Type { get; set; }
  public int SeatCapacity { get; set; }

  public Vehicle(string Make, string Model, int Year, double MaxSpeed, string Type, int SeatCapacity) 
  {
    this.Make = Make;
    this.Model = Model;
    this.Year = Year;
    this.MaxSpeed = MaxSpeed;
    this.Type = Type;
    this.SeatCapacity = SeatCapacity;
  }

  //Virtual allows method to be overridden]

  public void startEngine()
  {
        Console.WriteLine("Starting Engine...");
  }

  public void stopEngine() 
  { 
    Console.WriteLine("Stopping Engine...");
  }
}