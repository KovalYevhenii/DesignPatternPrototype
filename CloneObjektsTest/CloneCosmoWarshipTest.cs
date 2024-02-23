using DesignPatternPrototype;

namespace CloneObjektsTest;
public class CloneCosmoWarshipTest
{
    [Fact]
    public void Clone_CreatesIdenticalObj()
    {
        CosmoWarship original = new();
        CosmoWarship clone = (CosmoWarship)original.Clone();

        Assert.Equal(original.WeaponPower, clone.WeaponPower);
        Assert.Equal(original.Weight, clone.Weight);
        Assert.Equal(original.MaxCrewCapacity, clone.MaxCrewCapacity);
        Assert.Equal(original.MaxLoadCapacity, clone.MaxLoadCapacity);
        Assert.Equal(original.Engine.Type, clone.Engine.Type);
    }
}

