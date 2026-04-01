
using System.Numerics;
using System.Runtime.Intrinsics;

class Vector2D
{

    private int X;

    private int Y;

    public Vector2D(int x, int y)
    {
        X=x;
        Y=y;
    }

    public string DisplayVectorString()
    {
        return $"x: {X}, y: {Y}";
    }

    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector2D operator -(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static bool operator ==(Vector2D v1, Vector2D v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    public static bool operator !=(Vector2D v1, Vector2D v2)
    {
        return v1.X != v2.X || v1.Y != v2.Y;
    }
}