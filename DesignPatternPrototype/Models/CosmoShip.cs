namespace DesignPatternPrototype;
/// <summary>
/// Represents a ship in the cosmos.
/// </summary>
public class CosmoShip : BaseShip, ICloneable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CosmoShip"/> class.
    /// </summary>
    public CosmoShip() : base(){}
    /// <summary>
    /// Creates a new ship that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of this instance.</returns>
    public virtual object Clone()
    {
        return new CosmoShip();
    }
    /// <summary>
    /// Moves the ship.
    /// </summary>
    public override void Move()
    {
        Console.WriteLine("I believe I can fly....");
    }
}
