using Exercicio2;

namespace Exercicio3
{
    public enum TipoTriangulo { Equilatero, Isosceles, Escaleno }

    public class Triangulo
    {
        double segmentoAB;
        double segmentoAC;
        double segmentoBC;

        public Triangulo(Vertice a, Vertice b, Vertice c)
        {
            bool trianguloValido = ValidarTriangulo(a, b, c);

            if (!trianguloValido)
            {
                throw new Exception("Os vértices não formam um triângulo");
            }

            A = a;
            B = b;
            C = c;

            CalcularSegmentos();
            DefinirTipo();
            CalcularArea();
        }

        public Vertice A { get; private set; }

        public Vertice B { get; private set; }

        public Vertice C { get; private set; }

        public double Perimetro { get { return segmentoAB + segmentoAC + segmentoBC; } }

        // "private set" porque os valores são atribuídos pelos métodos DefinirTipo e CalcularArea
        public TipoTriangulo Tipo { get; private set; }

        public double Area { get; private set; }

        private bool ValidarTriangulo(Vertice a, Vertice b, Vertice c)
        {
            // Calcula os três segmentos de retas formados pelos vértices.
            // Se a soma das medidas de dois deles for sempre maior que a medida do terceiro,
            // então eles podem formar um triângulo

            double segmentoAB = Vertice.Distancia(a, b);
            double segmentoAC = Vertice.Distancia(a, c);
            double segmentoBC = Vertice.Distancia(b, c);

            if (!(segmentoAB + segmentoAC > segmentoBC)) return false;
            if (!(segmentoAB + segmentoBC > segmentoAC)) return false;
            if (!(segmentoAC + segmentoBC > segmentoAB)) return false;

            return true;
        }

        private void CalcularSegmentos()
        {
            // Usados para calcular Perimetro, Tipo e Area
            segmentoAB = Vertice.Distancia(A, B);
            segmentoAC = Vertice.Distancia(A, C);
            segmentoBC = Vertice.Distancia(B, C);
        }

        private void DefinirTipo()
        {
            if (segmentoAB == segmentoAC && segmentoAB == segmentoBC)
            {
                Tipo = TipoTriangulo.Equilatero;
            }
            else if (segmentoAB == segmentoAC
                || segmentoAB == segmentoBC
                || segmentoAC == segmentoBC)
            {
                Tipo = TipoTriangulo.Isosceles;
            }
            else
            {
                Tipo = TipoTriangulo.Escaleno;
            }
        }

        private void CalcularArea()
        {
            double S = Perimetro / 2;
            double a = segmentoAB;
            double b = segmentoAC;
            double c = segmentoBC;

            Area = Math.Sqrt(S * (S - a) * (S - b) * (S - c));
        }

        public static bool Iguais(Triangulo trianguloUm, Triangulo trianguloDois)
        {
            // Os triângulos são iguais se os vértices forem iguais
            return (Vertice.Iguais(trianguloUm.A, trianguloDois.A)
                && Vertice.Iguais(trianguloUm.B, trianguloDois.B)
                && Vertice.Iguais(trianguloUm.C, trianguloDois.C));
        }

    }
}