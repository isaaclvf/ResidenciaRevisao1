namespace Exercicio2
{
    public class Vertice
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double Distancia(Vertice a, Vertice b)
        {
            double Square(double x) => x * x;
            return Math.Sqrt(Square(b.X - a.X) + Square(b.Y - a.Y));
        }

        public static bool Iguais(Vertice a, Vertice b)
        {
            return ((a.X == b.X) && (a.Y == b.Y));
        }
    }
}