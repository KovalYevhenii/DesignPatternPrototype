using DesignPatternPrototype.Interfaces;
namespace DesignPatternPrototype;
public class CosmoWarship : CosmoShip, IMyClonable<object>, ICloneable
{
    public int WeaponPower { get; set; }
    public CosmoWarship()
    {
        Weight = 140_4000;
        MaxCrewCapacity = 70;
        MaxLoadCapacity = 20_0000;
        WeaponPower = 1000;
    }
    public void FireWeapons()
    {
        Console.WriteLine($"Firing weapons with power: {WeaponPower}");
    }
    public object MyClone()
    {
        CosmoWarship cosmoWarship = new()
        {
            Weight = Weight,
            MaxCrewCapacity = MaxCrewCapacity,
            MaxLoadCapacity = MaxLoadCapacity,
            WeaponPower = WeaponPower
        };
        return cosmoWarship;
    }
    public override object Clone()
    {
        return MyClone();
    }
}
