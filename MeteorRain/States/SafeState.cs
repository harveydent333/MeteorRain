using System;
using MeteorRain.States;

namespace MeteorRain.States
{
    public class SafeState : AbstractState
    {
        public string NameState { get; } = "Безопасное состояние";

        public override void Warning(Earth earth)
        {
            earth.SetState(new WarningState());
            ConsolePainter.DrawEarthAndRadius(ConsoleColor.Red, earth);
        }
    }
}
