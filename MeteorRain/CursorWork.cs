using System;

namespace MeteorRain
{
    public class CursorWork
    {
        private int LeftPosition { get; set; }

        private int TopPosition { get; set; }

        public void CursorControl()
        {
            while (true)
            {
                ConsoleKeyInfo pressed;
                pressed = Console.ReadKey();

                switch (pressed.Key)
                {
                    case ConsoleKey.UpArrow:
                        ChangeCursorsTopPosition(true);
                        break;

                    case ConsoleKey.DownArrow:
                        ChangeCursorsTopPosition(false);
                        break;

                    case ConsoleKey.LeftArrow:
                        ChangeCursorsLeftPosition(true);
                        break;

                    case ConsoleKey.RightArrow:
                        ChangeCursorsLeftPosition(false);
                        break;

                    case ConsoleKey.Spacebar:
                        break;
                }
            }
        }

        public void SaveCursorPositio()
        {
            LeftPosition = Console.CursorLeft;
            TopPosition = Console.CursorTop;
        }

        public void ChangeCursorsTopPosition(bool isUp)
        {
            if (isUp)
            {
                if (Console.CursorTop != 0)
                {
                    Console.CursorTop--;
                    SaveCursorPositio();
                    ConsolePainter.PrintCursorPosition(LeftPosition, TopPosition);
                }
            }
            else
            {
                Console.CursorTop++;
                SaveCursorPositio();
                ConsolePainter.PrintCursorPosition(LeftPosition, TopPosition);
            }
        }

        public void ChangeCursorsLeftPosition(bool isLeft)
        {
            if (isLeft)
            {
                if (Console.CursorLeft != 0)
                {
                    Console.CursorLeft--;
                    SaveCursorPositio();
                    ConsolePainter.PrintCursorPosition(LeftPosition, TopPosition);
                }
            }
            else
            {
                Console.CursorLeft++;
                SaveCursorPositio();
                ConsolePainter.PrintCursorPosition(LeftPosition, TopPosition);
            }
        }
    }
}
