class Line
{
    Point3d p1;
    Point3d p2;

    double Length { get {  return GetLength(); } }

    public Line(Point3d p1, Point3d p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    // Linjär interpolation
    // Linerar interpolation
    Point3d Lerp(double t) // Standard name
    {
        // Check so that t is between 0 & 1;
        t = Math.Max(0, Math.Min(1, t));
        // Calckulate point
        double newX = p1.X + t * (p2.X - p1.X);
        double newY = p1.Y + t * (p2.Y - p1.Y);
        double newZ = p1.Z + t * (p2.Z - p1.Z);
        
        return new Point3d(newX, newY, newZ);
    }

    public void Draw()
    {
        for (double t = 0; t <= 1; t+=0.01)
        {
            Point3d interpolatedPoint = Lerp(t);
            double consoleX = (double)interpolatedPoint.X;
            double consoleY = (double) interpolatedPoint.Y;
            double consoleZ = (double)interpolatedPoint.Z;
            Console.SetCursorPosition((int)consoleX, (int)consoleY);
            Console.ForegroundColor = AntiAliasing(consoleX, consoleY);
            Console.Write('#');
            Console.ResetColor();
        }
    }

    ConsoleColor AntiAliasing(double ConsoleX, double ConsoleY)
    {
        /*if () // code that checks how close to centre of a pixel pos ConsoleX, ConsoleY is
        {
            return ConsoleColor.Gray;
        }
        else if ()
        {
            return ConsoleColor.DarkGray;
        }*/
        return ConsoleColor.White;
    }

    public double GetLength()
    {
        double deltaX = p1.X + p2.X;    //Math.Abs(p1.X + p2.X); for abs delta
        double deltaY = Math.Abs(p1.Y + p2.Y);
        double deltaZ = Math.Abs(p1.Z + p2.Z);

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    }

    public override string ToString()
    {
        return $"{p1} -- {p2}";
    }
}