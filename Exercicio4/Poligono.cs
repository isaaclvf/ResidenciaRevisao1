using Exercicio2;

namespace Exercicio4
{
    public class Poligono
    {
        List<Vertice> listaVertices = new List<Vertice>();

        public int QuantidadeVertices
        {
            get { return listaVertices.Count; }
        }

        public Poligono(params Vertice[] vertices)
        {
            if (vertices.Length < 3)
            {
                throw new Exception("O polígono precisa ter pelo menos 3 vértices");
            }

            foreach (Vertice v in vertices)
            {
                listaVertices.Add(v);
            }
        }

        public bool AddVertice(Vertice v)
        {
            foreach (Vertice i in listaVertices)
            {
                if (Vertice.Iguais(v, i))
                {
                    return false;
                }
            }

            listaVertices.Add(v);
            return true;
        }

        public bool RemoveVertice(Vertice v)
        {
            if (listaVertices.Count - 1 < 3)
            {
                throw new Exception("O polígono não pode ter menos de 3 vértices");
            }

            foreach (Vertice i in listaVertices)
            {
                if (Vertice.Iguais(v, i))
                {
                    var index = listaVertices.IndexOf(i);
                    listaVertices.RemoveAt(index);

                    return true;
                }
            }

            return false;
        }

        public double Perimetro()
        {
            double perimetro = 0;
            for (int i = 0; i < listaVertices.Count - 1; i++)
            {
                perimetro += Vertice.Distancia(
                    listaVertices.ElementAt(i),
                    listaVertices.ElementAt(i + 1)
                );
            }
            return perimetro;
        }
    }
}