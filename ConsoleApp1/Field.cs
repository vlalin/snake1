using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Field
    {
        int field_height;
        int fiels_width;

        char cell_symbol;
        char wall_symbol;

        public void show_map()
        {

            for (int i = 0; i < field_height; i++)
            {

                for (int g = 0; g < fiels_width; g++)
                {
                    
                    
                    if (i == field_height - 1 || g == fiels_width - 1
                        || i == 0 || g == 0)
                        Console.Write(wall_symbol);
                    else
                        Console.Write(cell_symbol);

                }
                Console.WriteLine("");
            }
        }

        public Field()
        {
            field_height = 23;
            fiels_width = 78;

            cell_symbol = ' ';
            wall_symbol = '#';
        }

    }
}
