using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random( );

        public FoodCreator(int mapWidht, int mapHeight, char sym)   //Присваивание данных
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()       //Создание точки с присвоенными координатами
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point (x,y,sym);
        }
    }
}
