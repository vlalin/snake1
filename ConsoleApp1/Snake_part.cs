using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Snake_part
    {
        char display_symbol;

        int height_coordinat_x;
        int width_coordinat_y;

        public Snake_part()
        {
            height_coordinat_x = 3;
            width_coordinat_y = 3;
            display_symbol = '*';
        }

        public Snake_part(char display_symbol, int height_coordinat_x, int width_coordinat_y)
        {
            this.display_symbol = display_symbol;
            this.height_coordinat_x = height_coordinat_x;
            this.width_coordinat_y = width_coordinat_y;
        }

        public void move_up()
        {
            if (height_coordinat_x -1 > 0)
            {
                height_coordinat_x--;
            }           
        }

        public void move_down(int max_x)
        {
            if (height_coordinat_x + 1 < max_x )
            {
                height_coordinat_x++;
            }
            
        }

        public void move_left()
        {
            if (width_coordinat_y -1 > 0)
            {
                width_coordinat_y--;
            }
            
        }

        public void move_right(int max_y)
        {
            if (width_coordinat_y + 1 < max_y)
            {
                width_coordinat_y++;
            }
        }

        public int get_x()
        {
            return this.height_coordinat_x;
        }

        public int get_y()
        {
            return this.width_coordinat_y;
        }

        public char get_symbol()
        {
            return this.display_symbol;
        }



    }
}
