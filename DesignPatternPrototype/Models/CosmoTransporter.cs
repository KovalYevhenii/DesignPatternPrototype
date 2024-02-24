
using DesignPatternPrototype.Interfaces;

namespace DesignPatternPrototype;
/// <summary>
/// Represents a transporter ship in the cosmos.
/// </summary>
public class CosmoTransporter : CosmoShip, IMyClonable<CosmoTransporter>
{
    /// <summary>
    /// Gets a value indicating whether this transporter can transport resources.
    /// </summary>
    public bool IsResourceTransportabe { get; set; }
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
    public CosmoTransporter MyClone()
    {
        return new CosmoTransporter
        {
            Weight = Weight,
            MaxCrewCapacity = MaxCrewCapacity,
            MaxLoadCapacity = MaxLoadCapacity,
            IsResourceTransportabe = IsResourceTransportabe,
            Engine = Engine
        };
    }
    /// <summary>
    /// Creates a new transporter that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of this instance.</returns>
    public override object Clone()
    {
        return MyClone();
    }
}
