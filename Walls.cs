using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls : Figure
    {
        List<Figure> wallList;

        public Walls(int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();      //Создание списка фигур

            HorizontalLine upLine = new HorizontalLine(0, mapWidht - 2, 0, '-');      //Создание списков точек
            HorizontalLine downLine = new HorizontalLine(0, mapWidht - 2, mapHeight - 2, '-');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 2, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 2, mapWidht - 2, '|');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

            //Draw(wallList);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        public Walls(int xOffset, int yOffset,int Widht, int Height, ConsoleColor color, char sym)
        {
            Console.ForegroundColor = color;

            HorizontalLine upLine = new HorizontalLine(xOffset, xOffset+Widht, yOffset, sym);
            HorizontalLine downLine = new HorizontalLine(xOffset, xOffset + Widht, yOffset+Height, sym);
            VerticalLine leftLine = new VerticalLine(yOffset, yOffset+Height, xOffset, sym);
            VerticalLine rightLine = new VerticalLine(yOffset, yOffset + Height, xOffset+Widht, sym);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
