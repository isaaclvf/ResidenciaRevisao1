namespace Exercicio1
{
    public class Piramide
    {
        private int n;

        public int N
        {
            get { return n; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("O valor da pirâmide precisa ser maior ou igual a 1");
                }
                n = value;
            }
        }

        public Piramide(int n)
        {
            N = n;
        }

        public void Desenha()
        {
            /*
            * O algoritmo foi inspirado em um desse link:
            * https://www.programiz.com/c-programming/examples/pyramid-pattern
            */
            for (int linha = 1; linha <= n; linha++)
            {
                for (int espaco = 1; espaco <= n - linha; espaco++)
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