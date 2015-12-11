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

            // Стены (границы поля)
            Walls wall = new Walls(80, 25);
            wall.Draw();

            // ОТрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // Создаем первую еду
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Бесконечный цикл
            while (true) {
                if (wall.IsHit(snake) || snake.IsHitTail()) break;
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
