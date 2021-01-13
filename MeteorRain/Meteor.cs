using MeteorRain.Interfaces;
using System;
using System.Threading;

namespace MeteorRain
{
    public class Meteor : IMeteor
    {
        public int TopPosition { get; set; }

        public int LeftPosition { get; set; }

        public void Fly()
        {
            LeftPosition = new Random().Next(100);
            TopPosition = 1;

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = TopPosition; i < 40; i++)
            {
                TopPosition = i;
                Console.SetCursorPosition(LeftPosition, i - 1);
                Console.Write(" ");
                Console.SetCursorPosition(LeftPosition, i);
                Console.Write("#");
                Program.CheckMetiorPosition(this);
                Thread.Sleep(30);
            }
        }
    }
}
