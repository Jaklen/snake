using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)  //Конструктор для создания списка точек вертикальных линий
        {
            pList = new List<Point>();              //Создаёт список
            for (int y = yUp; y <= yDown; y++)      //Цикл для создания и добавления точек в список
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
                p.Draw();
            }
        }
    }
}

