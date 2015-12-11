using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {
            List<Point> pList = new List<Point>();
            pList.Add(new Point(1, 3, '*'));
            pList.Add(new Point(4, 5, '#'));
            foreach (Point p in pList) {
                p.Draw();
            }
            Console.ReadLine();
        }     
    }
}
