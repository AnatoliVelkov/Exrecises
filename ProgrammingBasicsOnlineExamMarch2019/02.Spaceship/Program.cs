using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Spaceship
{
//    Георги трябва да построи космически кораб, който да събира част от екипажа му.За целта, той трябва да го
//направи така, че да има място за поне трима астронавти, но за не повече от 10. Всеки астронавт се нуждае от
//малка стая, която да е с размери: 2 метра ширина, 2 метра дължина и с 40 см по-висока от средната
//височина на астронавтите.
//Напишете програма, която изчислява обема на кораба, колко астронавта ще събере и принтира на
//конзолата дали той е достатъчно голям.
//Вход
//Входът се чете от конзолата и съдържа точно 4 реда:
//• На първия ред е широчината на кораба - реално число в интервала [1.00... 10.00]
//• На втория ред е дължината на кораба - реално число в интервала [1.00…10.00]
//• На третия ред е височината на кораба - реално число в интервала [1.00…20.00]
//• На четвъртия ред е средната височина на астронавтите - реално число в интервала [1.50 … 1.90]
//Изход
//Да се отпечата на конзолата един ред:
//• Ако броят на астронавтите е между 3 и 10:
//"The spacecraft holds {броя на астронавтите} astronauts."
//• Ако броят на астронавтите е по-малък от 3:
//"The spacecraft is too small."
//• Ако броят на астронавтите е по-голям от 10:
//"The spacecraft is too big."
    class Program
    {
        static void Main(string[] args)
        {
            var boatWidth = double.Parse(Console.ReadLine());
            var boatLength= double.Parse(Console.ReadLine());
            var boatHeight = double.Parse(Console.ReadLine());
            var averageAstronauts = double.Parse(Console.ReadLine());


            double rocket = boatWidth * boatLength * boatHeight;
            double room = (averageAstronauts + 0.40) * 2 * 2;

            double result = Math.Round(rocket / room);

            if (result>=3 && result<=10)
            {
                Console.WriteLine($"The spacecraft holds {result} astronauts.");
            }
            else if (result<3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else if (result > 10)
            {
                Console.WriteLine($"The spacecraft is too big.");
            }
        }
    }
}
