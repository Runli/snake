using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {
    class Walls {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight) {
            wallList = new List<Figure>();
            // Paint frame
            Figure upLine = new HorizontalLine(0, mapWidth - 2, 0, '*');
            Figure downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '*');
            Figure leftLine = new VerticalLine(0, 0, mapHeight - 1, '*');
            Figure rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '*');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }


        internal void Draw() {
            foreach (var element in wallList) {
                element.Draw();
            }
        }

        internal bool IsHit(Figure figure) {
            foreach (var element in wallList) {
                if (element.IsHit(figure)) {
                    return true;
                }
            }
            return false;
        }
    }
}
