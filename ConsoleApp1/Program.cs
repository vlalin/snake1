using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Snake_part> snake;

        static void Main(string[] args)
        {
            snake = new List<Snake_part>();

            snake.Add(new Snake_part('@',2,2));

            


            Field field = new Field();

            Bonus bonus = new Bonus();

            bonus.randomize_position(field.get_height(), field.get_width());

            field.show_map(bonus, snake);

            


            Console.ReadKey();
        }
    }
}
