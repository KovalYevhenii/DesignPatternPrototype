using System.Text.Json;
namespace DesignPatternPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CosmoShip ship = new();
            CosmoTransporter cosmoTransporter = new();
            cosmoTransporter.CanTransportResources();
            var res1 = cosmoTransporter.Clone();
            Console.WriteLine(JsonSerializer.Serialize(res1));  
        }
    }
}
