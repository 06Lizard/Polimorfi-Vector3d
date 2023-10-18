public class Vector3d
{
    // Variebles
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public double Length
    {
        get
        {
            return GetLength();
        }
    }

    //Indexer
    public double this[int i]
    {
        get
        {
            switch(i)
            {
                case 0: return X;
                case 1: return Y;
                case 2: return Z;
                default: throw new IndexOutOfRangeException();
            }
        }
        set
        {
            switch (i)
            {
                case 0: this.X = value; break; 
                case 1: this.Y = value; break;
                case 2: this.Z = value; break;
                default: throw new IndexOutOfRangeException();
            }
        }
    }

    // Consotructors 
    public Vector3d(double x, double y, double z) // Ver1
    {
        X = x;
        Y = y;
        Z = z; 
    }

    public Vector3d() // Ver0
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public Vector3d(Vector3d other) // Ver2
    {
        X = other.X;
        Y = other.Y;
        Z = other.Z;
    }

    //Override
    public override string ToString() // polimorfi, overide object to content of this function
    {
        return $"[{X}, {Y}, {Z}]";
    }
    // Methods/Functions
    double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    static Vector3d Add(Vector3d a, Vector3d b)
    {
        return new Vector3d(a.X+b.X, a.Y+b.Y, a.Z+b.Z);
    }

    public static double Dot(Vector3d a, Vector3d b) //Dot produkten kan användas för at tex få utvolym på hur hårt den trefar nånging
    {
        return a.X * b.X + a.Y*b.Y + a.Z * b.Z;
    }

    //Operator overloads
    public static Vector3d operator +(Vector3d a, Vector3d b) // operator overloading
    {
        return Add(a, b);
    }
    public static double operator * (Vector3d a, Vector3d b)
    {
        return Dot(a, b);
    }
}