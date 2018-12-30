using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field();

            Bonus bonus = new Bonus();

            bonus.randomize_position(field.get_height(), field.get_width());

            field.show_map(bonus);

            Console.ReadKey();
        }
    }
}
