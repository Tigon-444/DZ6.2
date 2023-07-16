namespace DZ6._2
{
    internal class CatalogPlanet
    {       
        private List<Planet> catalogPlanet = new List<Planet>();
        private int counter;

        public CatalogPlanet()
        {
            catalogPlanet.Add(new Planet("Venera"));
            catalogPlanet.Add(new Planet("Earth"));
            catalogPlanet.Add(new Planet("Mars"));
        }


        public (int? numberFromSun, int? lengthEquator, string? error) GetPlanet(string name)
        {
            var objectPlanet = catalogPlanet.Find(planet => planet.name == name);
            counter++;
            if (counter == 3)
            {
                counter = 0;
                return (null, null, "Вы спрашиваете слишком часто");
            }
            else if (objectPlanet == null) return (null, null, "Не удалось найти планету " + name);
            
            return (objectPlanet.numberFromSun, objectPlanet.lengthEquator, null);
        }
    }
}
