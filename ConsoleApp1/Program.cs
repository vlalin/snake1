﻿using System;
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

            do
            {
                Console.Clear();

                field.show_map(bonus, snake);

                switch (Console.ReadLine().ToString().ToUpper().ToString())
                {
                    case "W":
                        snake.ForEach(x => x.move_up());
                        break;

                    case "S":
                        snake.ForEach(x => x.move_down(field.get_height() -1));
                        break;

                    case "A":
                        snake.ForEach(x => x.move_left());
                        break;

                    case "D":
                        snake.ForEach(x => x.move_right(field.get_width() -1));
                        break;

                    default:
                        break;
                }

            } while (true);




            
        }
    }
}
