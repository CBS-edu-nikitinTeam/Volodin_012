namespace Exercise4
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        public int X => x;

        public int Y => y;

        public string Name => name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}