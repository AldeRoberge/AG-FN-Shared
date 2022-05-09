
using System;

namespace AG_FishNet_Database.Objects.Utils
{
    public class Vector3DO
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public double x;
        public double y;
        public double z;

        public Vector3DO(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3DO()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public static readonly Vector3DO Zero = new Vector3DO(0.0f, 0.0f, 0.0f);
        public static readonly Vector3DO One = new Vector3DO(1f, 1f, 1f);
        public static readonly Vector3DO Up = new Vector3DO(0.0f, 1f, 0.0f);
        public static readonly Vector3DO Down = new Vector3DO(0.0f, -1f, 0.0f);
        public static readonly Vector3DO Left = new Vector3DO(-1f, 0.0f, 0.0f);
        public static readonly Vector3DO Right = new Vector3DO(1f, 0.0f, 0.0f);
        public static readonly Vector3DO Forward = new Vector3DO(0.0f, 0.0f, 1f);
        public static readonly Vector3DO Back = new Vector3DO(0.0f, 0.0f, -1f);
        public static readonly Vector3DO PositiveInfinity = new Vector3DO(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        public static readonly Vector3DO NegativeInfinity = new Vector3DO(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);



        /// <summary>
        ///   <para>Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta.</para>
        /// </summary>
        /// <param name="current">The position to move from.</param>
        /// <param name="target">The position to move towards.</param>
        /// <param name="maxDistanceDelta">Distance to move current per call.</param>
        /// <returns>
        ///   <para>The new position.</para>
        /// </returns>
        public static Vector3DO MoveTowards(
            Vector3DO current,
            Vector3DO target,
            float maxDistanceDelta)
        {
            float num1 = (float) (target.x - current.x);
            float num2 = (float) (target.y - current.y);
            float num3 = (float) (target.z - current.z);
            float num4 = (float) ((double) num1 * (double) num1 + (double) num2 * (double) num2 + (double) num3 * (double) num3);
            if ((double) num4 == 0.0 || (double) maxDistanceDelta >= 0.0 && (double) num4 <= (double) maxDistanceDelta * (double) maxDistanceDelta)
                return target;
            float num5 = (float) Math.Sqrt((double) num4);
            return new Vector3DO(current.x + num1 / num5 * maxDistanceDelta, current.y + num2 / num5 * maxDistanceDelta, current.z + num3 / num5 * maxDistanceDelta);
        }

        /// <summary>
        /// Returns a string representation of the position
        /// With two digit precision (n2)
        /// </summary>
        public override string ToString()
        {
            return $"[{x:n2}, {y:n2}, {z:n2}]";
        }


        #region Equality

        protected bool Equals(Vector3DO other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector3DO) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Vector3DO left, Vector3DO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector3DO left, Vector3DO right)
        {
            return !Equals(left, right);
        }

        #endregion

        #region Operators

        public static Vector3DO operator +(Vector3DO a, Vector3DO b) => new Vector3DO(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector3DO operator -(Vector3DO a, Vector3DO b) => new Vector3DO(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector3DO operator *(Vector3DO a, Vector3DO b) => new Vector3DO(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Vector3DO operator /(Vector3DO a, Vector3DO b) => new Vector3DO(a.x / b.x, a.y / b.y, a.z / b.z);
        public static Vector3DO operator *(Vector3DO a, float b) => new Vector3DO(a.x * b, a.y * b, a.z * b);
        public static Vector3DO operator /(Vector3DO vecOne, float vecTwo) => new Vector3DO(vecOne.x / vecTwo, vecOne.y / vecTwo, vecOne.z / vecTwo);

        #endregion


        public static Random r = new Random();

        public static Vector3DO GetRandomXZ(float factor)
        {
            return new Vector3DO(r.NextDouble() * factor - factor / 2, 0, r.NextDouble() * factor - factor / 2);
        }

        public Vector3DO Clone()
        {
            return new Vector3DO(x, y, z);
        }
    }
}