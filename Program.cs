using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);      //Размеры консоли
            Text hello = new Text("Created by Denis Heyguys", ConsoleColor.Cyan);
            Thread.Sleep(2000);
        Start:
            Console.Clear();

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '#'); //Хвост змейки
            Snake snake = new Snake(p, 4, Direction.RIGHT); //Создание змейки

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)    //Постоянно делается
            {
                if (walls.IsHit(snake) || snake.IsHitTail())    //Столкновение змейки со стеной и своим телом
                    break;
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();   //Передвижение змейки
                }
                Thread.Sleep(100);  //Задержка

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);       //Сохраняет направление
                }
            }

            Console.Clear();
            Text fun = new Text("Hehe XD", ConsoleColor.Yellow);

            Menu menu = new Menu("loose");      //Вызов "меню" при проигрыше

            ConsoleKeyInfo mkey = Console.ReadKey();    //Считывание нажатой клавиши
            Begin: if (mkey.Key == ConsoleKey.D1)
            {
                Snake.score = 0;
                goto Start;
            }
            else if (mkey.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Text bye = new Text("Byyyyye, have a greate time ^_^", ConsoleColor.Yellow);
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine(" Are you stupid?");
                mkey = Console.ReadKey();
                goto Begin;
            }




            /*
            menu.loose(Console.ReadKey());
            goto Start;

            
            

            /*
            if (menu.loose(Console.ReadKey()))
                goto Start;
            else
            {
                Console.Clear();
                Text bye = new Text("Byyyyye, have a greate time ^_^", ConsoleColor.Yellow);
                Thread.Sleep(2000);
            }
            
            Console.WriteLine("test");
            Console.ReadLine();*/
        }
    }
}
