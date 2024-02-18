namespace DesignPatternPrototype;
public class CosmoTransporter: CosmoShip
{
    public bool IsResourceTransportabe { get; private set; }
    public CosmoTransporter()
    {
        IsResourceTransportabe = true;
        Weight = 130_4000;
        MaxCrewCapacity = 25;
        MaxLoadCapacity = 20_0000;
        Console.WriteLine(_engine.Type);
    }
    public override void Move()
    {
        base.Move();
    }
    public  void TransportResources()
    {
        if (IsResourceTransportabe)
        {
            Console.WriteLine("Boost spaceShip Capacity");
            MaxLoadCapacity += 5_000;
            Console.WriteLine($"Max Load Capacity: {MaxLoadCapacity}");
        }
        else
        {
            Console.WriteLine("Sorry I cant transport resources");
        }
    }
}
