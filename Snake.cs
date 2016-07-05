using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public static int bestscore = 0;
        public static int score = 0;
        public Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)  //Создание змейки от хвоста в указанном направлении
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);  //Получение копии хвоста
                p.Move(i, direction);       //Перемещение на какое-то кол-во в указанном направлении
                pList.Add(p);
                p.Draw();
            }
        }

        internal void Move() //Удаляет хвост, добавляет следующую после головы точку 
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        public Point GetNextPoint() //Получает точку после головы в направлении
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return (nextPoint);
        }

        public void HandleKey(ConsoleKey key)   //Сохранение в этом классе направления
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
        internal bool Eat ( Point food)     //Поедание еды, либо передача голове следующей координаты
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                food.Draw();
                score++;
                return true;               
            }
            else
                return false;
        }
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
    }
}
