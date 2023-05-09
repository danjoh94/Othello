namespace OthelloBusiness
{
    public abstract class Player
    {
        public string Name { get; set; }

        public int Disk { get; set; }

        public abstract void RequestMove();
    }
}