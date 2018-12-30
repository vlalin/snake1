using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bonus
    {
        char bonus;

        int height_coordinat;
        int width_coordinat;

        public void randomize_position(int height, int width)
        {
            Random rand = new Random();
            height_coordinat = rand.Next(2,height - 2);
            width_coordinat = rand.Next(2,width - 2);
        }

        public Bonus()
        {
            height_coordinat = 1;
            width_coordinat = 1;
            bonus = '$';
        }

        public int get_height()
        {
            return this.height_coordinat;
        }

        public int get_width()
        {
            return this.width_coordinat;
        }

        public char get_symbol()
        {
            return this.bonus;
        }
    }

    
}
