namespace DesignPatternPrototype;
/// <summary>
/// Represents a ship in the cosmos.
/// </summary>
public class CosmoShip : BaseShip, ICloneable
{
    /// <summary>
    /// Creates a new ship that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of this instance.</returns>
    public virtual object Clone()
    {
        var cosmoShip = new CosmoShip()
        {
            MaxCrewCapacity = MaxCrewCapacity,
            MaxLoadCapacity = MaxLoadCapacity,
            Engine = Engine,
            Weight = Weight,
        };
        return cosmoShip;
    }
    /// <summary>
    /// Moves the ship.
    /// </summary>
    public override void Move()
    {
        Console.WriteLine("I believe I can fly....");
    }
}
