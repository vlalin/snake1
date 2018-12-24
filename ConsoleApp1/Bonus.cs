using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bonus
    {
        char bonus = '$';

        int height_coordinat = 0;
        int width_coordinat = 0;

        void randomize_position(int height, int width)
        {
            Random rand = new Random();
            height_coordinat = rand.Next(height - 1);
            width_coordinat = rand.Next(width - 1);
        }

        Bonus()
        {
            height_coordinat = 1;
            width_coordinat = 1;
        }
    }

    
}
