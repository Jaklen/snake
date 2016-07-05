using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;       //Координата
        public int y;       //Координата
        public char sym;    //Символ

        public Point (int x,int  y,char  sym)  //Конструктор точки с определёнными координатами
        {
            this.x =  x;
            this.y =  y;
            this.sym =  sym;
        }

        public Point(Point p)                   //Создаёт точку, похожую на указанную
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset,Direction direction)    //Передвигает точку на какое-то число
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y - offset;
            }
            else if(direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

        public void Clear()     //"Удаляет" точку
        {
            sym = ' ';
            Draw();
        }

        public void Draw()      //Функция кот. отображает символ с указаными координатами
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit (Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
