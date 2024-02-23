using System.Text.Json;
namespace DesignPatternPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var transporter = new CosmoTransporter()
            {
                IsResourceTransportabe = true,
                Weight = 130_4000,
                MaxCrewCapacity = 25,
                MaxLoadCapacity = 20_0000,
                Engine = new Engine("defaulf Ion engine")
            };
            transporter.CanTransportResources();
            var res1 = transporter.MyClone();
            Console.WriteLine(JsonSerializer.Serialize(res1));

            Console.WriteLine("-----");
            var warship = new CosmoWarship()
            {
                WeaponPower = 1,
                Weight = 130_7000,
                MaxCrewCapacity = 33,
                MaxLoadCapacity = 17_0000,
                Engine = new Engine(" Ion engine turbo")

            };
            var res2 = warship.MyClone();
            Console.WriteLine(JsonSerializer.Serialize(res2));
        }
    }
}
