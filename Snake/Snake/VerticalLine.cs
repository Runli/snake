using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class VerticalLine: Figure {
        public VerticalLine(int x, int yTop, int yButton, char sym) {
            pList = new List<Point>();
            for (int y = yTop; y <= yButton; y++) {
                pList.Add(new Point(x, y, sym));
            }
        }

        public override void Draw() {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
