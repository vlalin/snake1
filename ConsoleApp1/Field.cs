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

        public void show_map(Bonus bonus, List<Snake_part> snake)
        {

            for (int i = 0; i < field_height; i++)
            {

                for (int g = 0; g < fiels_width; g++)
                {


                    if (i == field_height - 1 || g == fiels_width - 1
                        || i == 0 || g == 0)
                        Console.Write(wall_symbol);
                    else if (i == bonus.get_height() && g == bonus.get_width())
                    {
                        Console.Write(bonus.get_symbol());
                    }
                    else
                        Console.Write(cell_symbol);

                    foreach (var item in snake)
                    {
                        if (i == item.get_x() && g == item.get_y())
                        {
                            Console.Write(item.get_symbol());
                        }
                    }
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


        public int get_height()
        {
            return this.field_height;
        }

        public int get_width()
        {
            return this.fiels_width;
        }
    }
}
