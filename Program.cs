using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Address

    {

        public string index; // индекс

        public string country;     // Страна

        public string city;     // город

        public string street;     // улица

        public int house;     //номер улицы

        public int apartment;     // квартира

        public void GetInfo()

        {

            Console.WriteLine($"index: {index} \ncountry: {country} \ncity: {city} \nstreet: {street} \nhouse: {house} \napartment: {apartment}");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Address home = new Address();

            home.index = "03500";

            home.country = "Ukraine";

            home.city = "Baryshivka";

            home.street = "Zentralna";

            home.house = 20;

            home.apartment = 6;

            home.GetInfo();

            Console.ReadKey();

        }

    }
}
