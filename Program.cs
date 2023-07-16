namespace DZ6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new CatalogPlanet();
            WritePlanet(a.GetPlanet("Earth"), "Earth");
            WritePlanet(a.GetPlanet("Limonia"), "Limonia");
            WritePlanet(a.GetPlanet("Mars"), "Mars");

        }

        static void WritePlanet((int?, int?, string?) info, string name)
        {
            if (info.Item3 == null)
            {
                Console.WriteLine("Планета " + name);
                Console.WriteLine("Номер от Солнца " + info.Item1);
                Console.WriteLine("Длинна экватора " + info.Item2);
            }
            else
            {
                Console.WriteLine(info.Item3);
            }
            Console.WriteLine();
        }
    }

}