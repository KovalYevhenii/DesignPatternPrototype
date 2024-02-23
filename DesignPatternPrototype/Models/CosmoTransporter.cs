
using DesignPatternPrototype.Interfaces;

namespace DesignPatternPrototype;
/// <summary>
/// Represents a transporter ship in the cosmos.
/// </summary>
public class CosmoTransporter : CosmoShip, IMyClonable<object>, ICloneable
{
    /// <summary>
    /// Gets a value indicating whether this transporter can transport resources.
    /// </summary>
    public bool IsResourceTransportabe { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CosmoTransporter"/> class.
    /// </summary>
    public CosmoTransporter()
    {
        IsResourceTransportabe = true;
        Weight = 130_4000;
        MaxCrewCapacity = 25;
        MaxLoadCapacity = 20_0000;
        Console.WriteLine(_engine.Type);
    }
    /// <summary>
    /// Transports resources if possible.
    /// </summary>
    public void CanTransportResources()
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
    public object MyClone()
    {
        CosmoTransporter cosmoTransporter = new()
        {
            IsResourceTransportabe = IsResourceTransportabe,
            Weight = Weight,
            MaxLoadCapacity = MaxLoadCapacity,
            MaxCrewCapacity = MaxCrewCapacity
        };
        return cosmoTransporter;
    }
    /// <summary>
    /// Creates a new transporter that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of this instance.</returns>
    public override object Clone()
    {
        return base.Clone();
    }
}
