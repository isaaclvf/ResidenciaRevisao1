using System;

namespace Exercicio5
{
    public class Intervalo
    {
        private readonly DateTime inicial;

        private readonly DateTime final;

        public DateTime Inicial { get { return inicial; } }

        public DateTime Final { get { return final; } }

        public TimeSpan Duracao { get { return Final - Inicial; } }

        public Intervalo(DateTime inicial, DateTime final)
        {
            // Retorna um número maior que zero se a data/hora inicial for depois que a final
            // https://learn.microsoft.com/en-us/dotnet/api/system.datetime.compare
            var verificacao = DateTime.Compare(inicial, final);

            if (verificacao > 0)
                throw new Exception("A data inicial não pode ser maior que a final");

            this.inicial = inicial;
            this.final = final;
        }

        public bool TemIntersecao(Intervalo outro)
        {
            /*
             * Os casos onde NÂO há interseção são:
             * quando o final de um é menor que a inicial do outro,
             * quando o inicial de um é maior que a final do outro
             */
            return !(Final < outro.Inicial || Inicial > outro.Final);
        }

        public override bool Equals(object? obj)
        {
            return obj is Intervalo intervalo &&
                Inicial == intervalo.Inicial &&
                Final == intervalo.Final;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}