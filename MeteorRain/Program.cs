using MeteorRain.Interfaces;
using MeteorRain.States;
using System;
using System.Threading.Tasks;

namespace MeteorRain
{
    public class Program
    {
        private static Earth earth = new Earth(20, 50, 10);

        public static void CheckMetiorPosition(IMeteor meteor)
        {
            if (meteor.LeftPosition == earth.LeftPosition && meteor.TopPosition == earth.TopPosition)
            {
                earth.Destroy();
            }

            if ((meteor.LeftPosition >= earth.LeftPosition - earth.Radius) &&
                (meteor.LeftPosition <= earth.LeftPosition + earth.Radius))
            {
                if ((meteor.TopPosition >= earth.TopPosition - earth.Radius) &&
                (meteor.TopPosition <= earth.TopPosition + earth.Radius))
                {
                    earth.Alert();
                }
                else
                {
                    earth.Safe();
                }
            }
        }

        public static async Task Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;

            IMeteor meteor = new Meteor();

            ConsolePainter.DrawUniverse();
            ConsolePainter.DrawEarthAndRadius(ConsoleColor.Black, earth);

            while (true)
            {
                await Task.Run(() =>
                {
                    ConsolePainter.DrawEarthAndRadius(ConsoleColor.Black, earth);
                    meteor.Fly();
                });

                CheckMetiorPosition(meteor);

                if (earth.GetState() is DestroyState)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Ваша планета была уничтожена");
                    break;
                }
            }
        }
    }
}