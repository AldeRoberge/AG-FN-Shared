namespace OpenAlienGarden.Core.Data
{
    public class Position
    {
        public float x;
        public float y;
        public float z;

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Position()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
    }
}