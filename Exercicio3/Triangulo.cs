using Exercicio2;

namespace Exercicio3
{
    public enum TipoTriangulo { EQUILATERO, ISOSCELES, ESCALENO }

    public class Triangulo
    {
        readonly double segmentoAB;
        readonly double segmentoAC;
        readonly double segmentoBC;

        public Vertice A { get; private set; }

        public Vertice B { get; private set; }

        public Vertice C { get; private set; }

        public TipoTriangulo Tipo { get; private set; }

        public double Area { get; private set; }

        public double Perimetro { get { return segmentoAB + segmentoAC + segmentoBC; } }

        public Triangulo(Vertice a, Vertice b, Vertice c)
        {
            double segmentoAB = a.Distancia(b);
            double segmentoAC = a.Distancia(c);
            double segmentoBC = b.Distancia(c);

            // Validar se o triângulo é possível
            if (!(segmentoAB + segmentoAC > segmentoBC) ||
                !(segmentoAB + segmentoBC > segmentoAC) ||
                !(segmentoAC + segmentoBC > segmentoAB))
            {
                throw new Exception("Os vértices não formam um triângulo");
            }

            A = a;
            B = b;
            C = c;

            // Definir tipo
            if (segmentoAB == segmentoAC && segmentoAB == segmentoBC)
            {
                Tipo = TipoTriangulo.EQUILATERO;
            }
            else if (segmentoAB == segmentoAC ||
                     segmentoAB == segmentoBC ||
                     segmentoAC == segmentoBC)
            {
                Tipo = TipoTriangulo.ISOSCELES;
            }
            else
            {
                Tipo = TipoTriangulo.ESCALENO;
            }

            // Calcular área
            double S = Perimetro / 2;

            Area = Math.Sqrt(S * (S - segmentoAB) * (S - segmentoAC) * (S - segmentoBC));
        }

        public override bool Equals(object? obj)
        {
            // Casos onde dois triângulos podem ser iguais,
            // existe um jeito mais fácil de fazer isso?
            return obj is Triangulo triangulo &&
                (
                    (A.Equals(triangulo.A) &&
                    B.Equals(triangulo.B) &&
                    C.Equals(triangulo.C)) ||

                    (A.Equals(triangulo.A) &&
                    B.Equals(triangulo.C) &&
                    C.Equals(triangulo.B)) ||

                    (A.Equals(triangulo.B) &&
                    B.Equals(triangulo.A) &&
                    C.Equals(triangulo.C)) ||

                    (A.Equals(triangulo.B) &&
                    B.Equals(triangulo.C) &&
                    C.Equals(triangulo.A)) ||

                    (A.Equals(triangulo.C) &&
                    B.Equals(triangulo.A) &&
                    C.Equals(triangulo.B)) ||

                    (A.Equals(triangulo.C) &&
                    B.Equals(triangulo.B) &&
                    C.Equals(triangulo.A))
                );
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}