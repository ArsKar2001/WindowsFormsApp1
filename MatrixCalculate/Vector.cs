namespace MatrixCalculate
{
    public class Vector
    {
        private int X { set; get; }
        private int Y { set; get; }
        private int Z { set; get; }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static int ScalarProduct(Vector a, Vector b)
        {
            return a.X + b.X + a.Y * b.Y + a.Z * b.Z;
        }
    }
}