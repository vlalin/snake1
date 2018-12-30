using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Snake_part
    {
        char display_symbol;

        int height_coordinat_x;
        int width_coordinat_y;

        Snake_part()
        {
            height_coordinat_x = 3;
            width_coordinat_y = 3;
            display_symbol = '*';
        }

        Snake_part(char display_symbol, int height_coordinat_x, int width_coordinat_y)
        {
            this.display_symbol = display_symbol;
            this.height_coordinat_x = height_coordinat_x;
            this.width_coordinat_y = width_coordinat_y;
        }

        void move_up()
        {
            height_coordinat_x--;
        }

        void move_down()
        {
            height_coordinat_x++;
        }

        void move_left()
        {
            width_coordinat_y--;
        }

        void move_right()
        {
            width_coordinat_y++;
        }


    }
}
