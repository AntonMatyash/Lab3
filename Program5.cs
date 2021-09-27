using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class User

    {

        public string login; // индекс

        public string name;     // Страна

        public string surname;     // город

        public string age;     // улица

        private DateTime date = DateTime.Today;





        public void GetInfo()

        {
            Console.WriteLine($"login: {login} \nname: {name} \nsurname: {surname} \nage: {age} \ndate of registrarion: {date.ToString("D")}\n");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            User user = new User();

            user.login = "a.matyashr@gmail.com";

            user.name = "Anton";

            user.surname = "Matyash";

            user.age = "18";

            user.GetInfo();

            Console.ReadKey();

        }

    }
}
