using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {
            Console.SetBufferSize(80, 25);

            // Paint frame
            Figure upLine = new HorizontalLine(0, 78, 0, '*');
            Figure downLine = new HorizontalLine(0, 78, 24, '*');
            Figure leftLine = new VerticalLine(0, 0, 24, '*');
            Figure rightLine = new VerticalLine(78, 0, 24, '*');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }     
    }
}
