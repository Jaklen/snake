using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Menu
    {
        public string result;
        public Menu(string condition)   //Вызов таблички меню
        {
            if (condition == "loose")
            {
                if (Snake.score > Snake.bestscore)
                    Snake.bestscore = Snake.score;

                Console.WriteLine("Your score is " + Snake.score);


                Console.SetCursorPosition(31, 7);
                Console.Write("Your best score is " + Snake.bestscore); 
                Text text = new Text("\n\n1 if you real maaan \n2 if you have to do your(or not) homework", ConsoleColor.Green);

                Walls frame = new Walls(30, 5, 23, 4, ConsoleColor.Magenta, '*');

                /*HorizontalLine upLine = new HorizontalLine(30, 53, 5, '*');     //Сделать метод в Walls для создания коробочки определённого цвета
                HorizontalLine downLine = new HorizontalLine(30, 53, 9, '*');
                VerticalLine leftLine = new VerticalLine(5, 9, 30, '*');
                VerticalLine rightLine = new VerticalLine(5, 9, 53, '*');
                */

                Console.SetCursorPosition(1, 12);

                result = condition;
            }
        }
        /*public void HandleKey(ConsoleKey key)
        {
            if (result == "loose")
            {

            }
        }*/
    }
}
