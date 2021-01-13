using MeteorRain.States;

namespace MeteorRain
{
    public class Earth
    {
        public int TopPosition { get; set; }

        public int LeftPosition { get; set; }

        public int Radius { get; set; }

        private AbstractState state;

        public Earth(int topPosition, int leftPosition, int radius)
        {
            TopPosition = topPosition;
            LeftPosition = leftPosition;
            Radius = radius;
            state = new SafeState();
        }

        public void Alert()
        {
            state.Warning(this);
        }

        public void Safe()
        {
            state.Safely(this);
        }

        public void Destroy()
        {
            state.Destroyed(this);
        }

        public void SetState(AbstractState state)
        {
            this.state = state;
        }

        public AbstractState GetState()
        {
            return state;
        }
    }
}
