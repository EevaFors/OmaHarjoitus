using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmaHarjoitus
{

    // Luokka Koiran omistajalle
    public class DogOwner
    {
        // Metodi, joka tulostaa omistajan lauseen
        public void Speak()
        {
            Console.WriteLine("Syötä koiran omistajan lause:");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Koiran omistaja sanoo: {sentence}");
            Console.WriteLine();
        }
    }

    // Luokka Kissan omistajalle
    public class CatOwner
    {
        public void Speak()
        {
            Console.WriteLine("Syötä kissan omistajan lause:");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Kissan omistaja sanoo: {sentence}");
            Console.WriteLine();
        }
    }

    // Luokka Hevosen omistajalle
    public class HorseOwner
    {
        public void Speak()
        {
            Console.WriteLine("Syötä hevosen omistajan lause:");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Hevosen omistaja sanoo: {sentence}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan instanssi jokaisesta omistajaluokasta
            DogOwner dogOwner = new DogOwner();
            CatOwner catOwner = new CatOwner();
            HorseOwner horseOwner = new HorseOwner();

            // Kutsutaan jokaisen omistajan Speak-metodia
            dogOwner.Speak();
            catOwner.Speak();
            horseOwner.Speak();
            Console.ReadLine();
        }

    }

}
