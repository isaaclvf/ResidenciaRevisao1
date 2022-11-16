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

        public double Distancia(Vertice ver)
        {
            double Square(double x) => x * x;

            return Math.Sqrt(Square(ver.X - this.X) + Square(ver.Y - this.Y));
        }

        public override bool Equals(object? obj)
        {
            return obj is Vertice vertice &&
                this.X == vertice.X &&
                this.Y == vertice.Y;
        }

        // O VS recomendou colocar isso, pesquisar sobre
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}