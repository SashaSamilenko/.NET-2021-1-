using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carriers
{
    public class ChooseCity
    {
        private List<City> cities = new List<City> { };
        public List<ITransport> ChooseTransport(string from, string to)
        {
            AddCities();
            MatrixOfDistance.CreateMatrix();
            MatrixOfDistance.GetMinimumDistance();
        }
        private void AddCities()
        {
            cities.Add(new City() { title = "Kharkiv" });
            cities.Add(new City() { title = "Minsk" });
            cities.Add(new City() { title = "Varshava" });
            cities.Add(new City() { title = "Lviv" });
            cities.Add(new City() { title = "Rivne" });
            cities.Add(new City() { title = "Gitomir" });
            cities.Add(new City() { title = "Kiev" });
            cities.Add(new City() { title = "Odessa" });
            cities.Add(new City() { title = "Brashov" });
            cities.Add(new City() { title = "Galac" });
        }
    }
}
