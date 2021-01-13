namespace MeteorRain.States
{
    public abstract class AbstractState
    {
        public virtual void Warning(Earth earth)
        {
        }

        public virtual void Safely(Earth earth)
        {
        }

        public virtual void Destroyed(Earth earth)
        {
        }
    }
}
