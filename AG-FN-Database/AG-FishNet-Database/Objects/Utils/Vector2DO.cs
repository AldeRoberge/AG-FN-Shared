using System;

namespace AG_FishNet_Database.Objects.Utils
{
    public class Vector2DO
    {
        public int x;
        public int y;

        public Vector2DO(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2DO()
        {
            x = 0;
            y = 0;
        }

        public static readonly Vector2DO Zero = new Vector2DO(0, 0);
        public static readonly Vector2DO One  = new Vector2DO(1, 1);

        public static readonly Vector2DO Up   = new Vector2DO(0, 1);
        public static readonly Vector2DO Down = new Vector2DO(0, -1);

        public static readonly Vector2DO Left  = new Vector2DO(-1, 0);
        public static readonly Vector2DO Right = new Vector2DO(1, 0);

        /// <summary>
        /// Returns a string representation of the position
        /// With two digit precision (n2)
        /// </summary>
        public override string ToString()
        {
            return $"[{x:n2}, {y:n2}";
        }

        #region Equality

        protected bool Equals(Vector2DO other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector2DO)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x.GetHashCode() * 397) ^ y.GetHashCode();
            }
        }

        public static bool operator ==(Vector2DO left, Vector2DO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector2DO left, Vector2DO right)
        {
            return !Equals(left, right);
        }

        #endregion

        #region Operators

        public static Vector2DO operator +(Vector2DO a, Vector2DO b) => new Vector2DO(a.x + b.x, a.y + b.y);
        public static Vector2DO operator -(Vector2DO a, Vector2DO b) => new Vector2DO(a.x - b.x, a.y - b.y);
        public static Vector2DO operator *(Vector2DO a, Vector2DO b) => new Vector2DO(a.x * b.x, a.y * b.y);
        public static Vector2DO operator /(Vector2DO a, Vector2DO b) => new Vector2DO(a.x / b.x, a.y / b.y);
        public static Vector2DO operator *(Vector2DO a, float b) => new Vector2DO((int)(a.x * b), (int)(a.y * b));
        public static Vector2DO operator /(Vector2DO vecOne, float vecTwo) => new Vector2DO((int)(vecOne.x / vecTwo), (int)(vecOne.y / vecTwo));

        #endregion

        public static Random r = new Random();

        public static Vector3DO GetRandomXZ(float factor)
        {
            return new Vector3DO(r.NextDouble() * factor - factor / 2, 0, r.NextDouble() * factor - factor / 2);
        }

        public Vector2DO Clone()
        {
            return new Vector2DO(x, y);
        }
    }
}