﻿class Program
{
    static void Main()
    {
        Vector3d v1 = new Vector3d(1, 2, 5); // Ver 1
        Vector3d v0 = new Vector3d(-1, 3, 2); // Ver0
        Console.WriteLine(v1);
        Vector3d v2 = new Vector3d(v1); // Ver2
        Console.WriteLine(v2);
        Console.WriteLine(v1.Length);
        Vector3d v3 = v1 + v2;
        Console.WriteLine(v3);
        Vector3d v4 = v1 + v3;
        Console.WriteLine(v4);
        Console.WriteLine(v3[1]);

        v0[2] = 4;
        Console.WriteLine(v0[2]);
        double dot = Vector3d.Dot(v1, v0);
        Console.WriteLine(dot);

        double dotProduct = v1 * v0;
        Console.WriteLine(dotProduct);
        object obj = new();
        obj.ToString();
    }
}