using DesignPatternPrototype;

namespace CloneObjektsTest;
public class CloneCosmoWarshipTest
{
    [Fact]
    public void Clone_CreatesIdenticalObj()
    {
        CosmoWarship original = new();
        CosmoWarship clone = (CosmoWarship)original.MyClone();

        Assert.Equal(original.WeaponPower, clone.WeaponPower);
        Assert.Equal(original.Weight, clone.Weight);
        Assert.Equal(original.MaxCrewCapacity, clone.MaxCrewCapacity);
        Assert.Equal(original.MaxLoadCapacity, clone.MaxLoadCapacity);
    }
}

