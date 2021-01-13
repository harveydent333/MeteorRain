using System;

namespace MeteorRain.States
{
    public class DestroyState : AbstractState
    {
        public string NameState { get; } = "Состояние - уничтожен";

        public override void Destroyed(Earth earth)
        {
            earth.SetState(new DestroyState());
            ConsolePainter.DrawEarthAndRadius(ConsoleColor.Blue, earth);
        }
    }
}
