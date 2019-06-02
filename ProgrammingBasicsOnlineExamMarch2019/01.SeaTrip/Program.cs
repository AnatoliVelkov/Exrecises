using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SeaTrip
{
//    Група туристи решили да си направят лятна екскурзия до морето.Те тръгват от село Чушкопек.
//Да се напише програма, която пресмята общата сума в левове, която е необходима на туристите за тази
//екскурзия.
//Разстоянието до морето е 210 километра, а цялата екскурзия е с продължителност 3 дни.
//Тяхната кола изразходва средно по 7 литра на всеки 100 километра, а цената на бензина е 1,85 лв.за един
//литър.
//За всеки ден от техния престой те харчат пари за храна и сувенири.
//Общата цена за хотел е Z лв.на ден. Като група, първия ден те получават 10% намаление за престоя, втория
//ден - 15% намаление, а третия ден - 20%.
//Вход
//От конзолата се прочитат 3 реда:
//• Парите за храна за един ден - реално число в интервала (0.00…1500.00]
//• Парите за сувенири за един ден - реално число в интервала(0.00…1500.00]
//• Парите за хотел за един ден - реално число в интервала[100.00…5000.00]
//Изход
//На конзолата се отпечатва 1 ред:
//"Money needed: {total money}"
//където {total money}
//e сумата на общия разход на групата, форматирана до втория знак след десетичната
//запетая.
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalMoney = 0;
            decimal moneyForFuel = ((decimal)420 / (decimal)100 * (decimal)7) * (decimal)1.85;
            


            var moneyForFood = decimal.Parse(Console.ReadLine());
            var moneyForGifts= decimal.Parse(Console.ReadLine());
            var moneyForHotel = decimal.Parse(Console.ReadLine());

            moneyForFood = moneyForFood * 3;
            moneyForGifts = moneyForGifts * 3;

            totalMoney = totalMoney + (moneyForHotel * (decimal)0.9);
            totalMoney = totalMoney + (moneyForHotel * (decimal)0.85);
            totalMoney = totalMoney + (moneyForHotel * (decimal)0.8);

            totalMoney = totalMoney + moneyForGifts + moneyForFuel + moneyForFood;

            Console.WriteLine($"Money needed: {totalMoney:f2}");


        }
    }
}
