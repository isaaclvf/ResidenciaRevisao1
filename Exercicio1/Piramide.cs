namespace Exercicio1
{
    public class Piramide
    {
        readonly int n;
        public Piramide(int n)
        {
            if (n < 1)
            {
                throw new Exception("n >= 1");
            }
            this.n = n;
        }

        public int N { get { return n; } }

        public void Desenha()
        {
            for (int linha = 1; linha <= N; linha++)
            {
                for (int espaco = 1; espaco <= N - linha; espaco++)
                {
                    Console.Write(" ");
                }

                int digito = 1;

                while (digito <= linha)
                {
                    Console.Write(digito);
                    digito++;
                }

                digito = linha - 1;

                while (digito >= 1)
                {
                    Console.Write(digito);
                    digito--;
                }

                Console.Write("\n");
            }
        }
    }
}