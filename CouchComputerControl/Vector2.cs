using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CouchComputerControl
{
    public struct Vector2 : ICloneable
    {
        private class GMath
        {
            public const double DEG2RAD = (System.Math.PI / 180.0);
            public const double RAD2DEG = (180.0 / System.Math.PI);

            public static float DegreesToRadians(float degrees)
            {
                return (float)(degrees * DEG2RAD);
            }
            public static float DegreesToRadians(double degrees)
            {
                return (float)(degrees * DEG2RAD);
            }
            public static float RadiansToDegrees(float degrees)
            {
                return (float)(degrees * RAD2DEG);
            }
            public static float RadiansToDegrees(double degrees)
            {
                return (float)(degrees * RAD2DEG);
            }
        }

        #region VARIABLES
        private float[] elements;
        #endregion

        #region PROPERTIES
        public static Vector2 Zero { get; } = new Vector2(0f, 0f);
        public static Vector2 Unit { get; } = new Vector2(1f, 1f);
        public static Vector2 UnitX { get; } = new Vector2(1f, 0f);
        public static Vector2 UnitY { get; } = new Vector2(0f, 1f);

        public float X
        {
            get { return elements[0]; }
            set { elements[0] = value; }
        }
        public float Y
        {
            get { return elements[1]; }
            set { elements[1] = value; }
        }
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
            set
            {
                if (value != this.Length)
                {
                    this.Normalize();
                    this.X *= value;
                    this.Y *= value;
                }
            }
        }
        public float Angle
        {
            get
            {
                return GMath.RadiansToDegrees(System.Math.Atan2(X, Y));
            }
            set
            {
                float length = Length;
                if (length != 0)
                {
                    float angle = Angle;

                    if (angle != value)
                    {
                        float rad = GMath.DegreesToRadians(value);
                        X = (float)(System.Math.Sin(rad) * length);
                        Y = (float)(System.Math.Cos(rad) * length);
                    }
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public static Vector2 FromAngle(float angle, float length = 1f)
        {
            float rad = GMath.DegreesToRadians(angle);
            return new Vector2(System.Math.Sin(rad) * length, System.Math.Cos(rad) * length);
        }

        public Vector2(Vector2 other) : this(other.X, other.Y) { }
        public Vector2(float value) : this(value, value) { }
        public Vector2(double value) : this((float)value, (float)value) { }
        public Vector2(double x, double y) : this((float)x, (float)y) { }
        public Vector2(float x, float y)
        {
            elements = new float[] { x, y };
        }

        public Vector2(Point p) : this(p.X, p.Y) { }
        public Vector2(PointF p) : this(p.X, p.Y) { }
        public Vector2(Size s) : this(s.Width, s.Height) { }
        public Vector2(SizeF s) : this(s.Width, s.Height) { }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return ToString(2);
        }
        public string ToString(int decimals)
        {
            return string.Format("[Vec2: X=\"{0}\", Y=\"{1}\"]", System.Math.Round(X, decimals), System.Math.Round(Y, decimals));
        }
        public object Clone()
        {
            return new Vector2(this);
        }
        public void Normalize()
        {
            float length = Length;
            if (length != 0)
            {
                X /= length;
                Y /= length;
            }
        }
        public Vector2 Normalized()
        {
            var vec = new Vector2(this);
            vec.Normalize();
            return vec;
        }
        public static float AngleBetween(Vector2 a, Vector2 b)
        {
            Vector2 tA = new Vector2(a), tB = new Vector2(b);
            tA.Normalize();
            tB.Normalize();
            return tA.Angle - tB.Angle;
        }
        public float AngleTo(Vector2 other)
        {
            return AngleBetween(this, other);
        }
        public bool Equals(Vector2 other)
        {
            return this.X == other.X && this.Y == other.Y;
        }
        public void Rotate(float angle, Vector2 center)
        {
            Vector2 delta = this - center;
            delta.Angle += angle;
            X = delta.X + center.X;
            Y = delta.Y + center.Y;
        }
        public void Rotate(float angle)
        {
            Rotate(angle, Zero);
        }
        public Vector2 Absolute()
        {
            return new Vector2(System.Math.Abs(X), System.Math.Abs(Y));
        }
        #endregion

        #region Conversions
        public PointF ToPointF() { return new PointF(X, Y); }
        public Point ToPoint() { return new Point((int)X, (int)Y); }
        public SizeF ToSizeF() { return new SizeF(X, Y); }
        public Size ToSize() { return new Size((int)X, (int)Y); }
        public static RectangleF CreateRectangleF(Vector2 pos, Vector2 size, bool centered)
        {
            if (!centered)
                return new RectangleF(pos.X, pos.Y, size.X, size.Y);
            return new RectangleF(pos.X - size.X / 2f, pos.Y - size.Y / 2f, size.X, size.Y);
        }
        public static Rectangle CreateRectangle(Vector2 pos, Vector2 size, bool centered)
        {
            if (!centered)
                return new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y);
            return new Rectangle((int)(pos.X - size.X / 2f), (int)(pos.Y - size.Y / 2f), (int)size.X, (int)size.Y);
        }
        #endregion

        #region OPERATORS
        public float this[int index]
        {
            get
            {
                return elements[index];
            }
            set
            {
                elements[index] = value;
            }
        }
        public static explicit operator Vector2(Point a)
        {
            return new Vector2(a);
        }
        public static explicit operator Vector2(PointF a)
        {
            return new Vector2(a);
        }
        public static explicit operator Vector2(Size a)
        {
            return new Vector2(a);
        }
        public static explicit operator Vector2(SizeF a)
        {
            return new Vector2(a);
        }
        public static explicit operator Point(Vector2 a)
        {
            return new Point((int)a.X, (int)a.Y);
        }
        public static explicit operator PointF(Vector2 a)
        {
            return new PointF(a.X, a.Y);
        }
        public static explicit operator Size(Vector2 a)
        {
            return new Size((int)a.X, (int)a.Y);
        }
        public static explicit operator SizeF(Vector2 a)
        {
            return new SizeF(a.X, a.Y);
        }
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
        public static Vector2 operator *(Vector2 a, float scalar)
        {
            return new Vector2(a.X * scalar, a.Y * scalar);
        }
        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X * b.X, a.Y * b.Y);
        }
        public static Vector2 operator /(Vector2 a, float scalar)
        {
            if (scalar != 0f)
                return new Vector2(a.X / scalar, a.Y / scalar);
            else
                return Vector2.Zero;
        }
        public static Vector2 operator +(Vector2 a, float offset)
        {
            return new Vector2(a.X + offset, a.Y + offset);
        }
        public static Vector2 operator -(Vector2 a, float offset)
        {
            return new Vector2(a.X - offset, a.Y - offset);
        }
        #endregion
    }
}
