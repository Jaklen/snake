using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        public List<Point> pList;    //Список для точек

        public virtual void Draw()              //Отрисовка точек в списке
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        internal bool IsHit(Figure figure)  //Проверка на перекрытие точек фигуры
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)     //Проверка на перекрытие точки
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
        public void Draw(List<Figure> fList)        //Отрисовка фигур в указанном списке
        {
            foreach (Figure wall in fList)
            {
                wall.Draw();
            }
        }
    }
}
