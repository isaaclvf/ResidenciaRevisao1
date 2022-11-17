using Exercicio5;

namespace Exercicio6
{
    public class ListaIntervalo
    {
        private List<Intervalo> lista = new List<Intervalo>();

        public void Add(Intervalo intervalo)
        {
            foreach (Intervalo i in lista)
                if (intervalo.TemIntersecao(i))
                    return;

            lista.Add(intervalo);
        }

        public void Imprime() 
        {
            var ListaOrdenada = lista.OrderBy(i => i.Inicial);
            foreach (var intevalo in ListaOrdenada)
            {
                Console.WriteLine($"{intevalo.Inicial} - {intevalo.Final}");
            }
        }
    }
}