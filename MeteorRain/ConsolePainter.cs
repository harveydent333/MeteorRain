using System;

namespace MeteorRain
{
    public static class ConsolePainter
    {
        public static void PrintCursorPosition(int leftPosition, int topPosition)
        {
            Console.SetCursorPosition(50, 1);
            Console.WriteLine(leftPosition + " " + topPosition);
            Console.SetCursorPosition(leftPosition, topPosition);
        }

        public static void DrawUniverse()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
        }

        public static void DrawEarthAndRadius(ConsoleColor color, Earth earth)
        {
            Console.ForegroundColor = color;
            var top = earth.TopPosition;
            var left = earth.LeftPosition;
            var radius = earth.Radius;
            Console.SetCursorPosition(left, top);
            Console.WriteLine("@");

            DrawHorizonLine(left, top, radius, -radius);
            DrawHorizonLine(left, top, radius, radius);
            DrawVerticalLine(left, top, radius, -radius);
            DrawVerticalLine(left, top, radius, radius);
        }

        public static void DrawVerticalLine(int left, int top, int radius, int leftLevel)
        {
            for (int i = -radius; i < radius + 1; i++)
            {
                Console.SetCursorPosition(left + leftLevel, top + i);
                Console.WriteLine("@");
            }
        }

        public static void DrawHorizonLine(int left, int top, int radius, int topLevel)
        {
            for (int i = -radius; i < radius + 1; i++)
            {
                Console.SetCursorPosition(left + i, top + topLevel);
                Console.WriteLine("@");
            }
        }
    }
}
