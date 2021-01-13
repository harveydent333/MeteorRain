using MeteorRain;
using System;

namespace MeteorRain.States
{
    public class WarningState : AbstractState
    {
        public string NameState { get; } = "Режим опастности";

        public override void Destroyed(Earth earth)
        {
            earth.SetState(new DestroyState());
            ConsolePainter.DrawEarthAndRadius(ConsoleColor.Blue, earth);
        }

        public override void Safely(Earth earth)
        {
            earth.SetState(new SafeState());
            ConsolePainter.DrawEarthAndRadius(ConsoleColor.Black, earth);
        }
    }
}
