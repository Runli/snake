using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {
            HorizontalLine hLine = new HorizontalLine(5, 10, 2, '*');
            hLine.Drow();
            VerticalLine vLine = new VerticalLine(8, 2, 10, '#');
            vLine.Drow();
            Console.ReadLine();
        }     
    }
}
