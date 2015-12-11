using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            // ОТрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            // Создаем первую еду
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Бесконечный цикл
            while (true) {
                if (snake.Eat(food)) {
                    food = foodCreator.CreateFood();
                    food.Draw();
                } else {
                    snake.MoveSnake();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            //Console.ReadLine();
        }     
    }
}
