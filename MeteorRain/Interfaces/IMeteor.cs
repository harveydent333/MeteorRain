namespace MeteorRain.Interfaces
{
    public interface IMeteor
    {
        public int TopPosition { get; set; }

        public int LeftPosition { get; set; }

        void Fly();
    }
}
