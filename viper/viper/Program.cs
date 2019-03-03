﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25); //Установили размер окна, убрали возможность перемотки

            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT );
            snake.Draw();
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);

            Console.ReadLine();

        }        
    }
}
