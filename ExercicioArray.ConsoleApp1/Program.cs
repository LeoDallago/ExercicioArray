namespace ExercicioArray.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Array");

            int[] teste = [-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6];

            int soma = 0;
            ExibirNaTela(teste);

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------");

            ValoresMaiores(teste);

            Console.WriteLine("----------------------------");

            ValoresMenores(teste);

            Console.WriteLine("----------------------------");

            soma = Media(teste, soma);

            Console.WriteLine("----------------------------");
            teste = RemoverValor(teste);

            Console.ReadLine();
        }

        private static void ExibirNaTela(int[] teste)
        {
            for (int i = 0; i < teste.Length; i++)
            {
                Console.Write(teste[i] + " ");
            }
        }

        private static void ValoresMaiores(int[] teste)
        {
            System.Array.Sort(teste);
            Console.WriteLine($"O maior valor eh {teste[15]}");
            Console.WriteLine($"O tres maiores valores são {teste[15]} {teste[14]} {teste[13]} ");
        }

        private static void ValoresMenores(int[] teste)
        {
            System.Array.Reverse(teste);
            Console.WriteLine($"O menor valor eh {teste[15]}");
            Console.WriteLine($"os valores negativos são {teste[15]} {teste[14]} {teste[13]} ");
        }

        private static int Media(int[] teste, int soma)
        {
            for (int i = 0; i < teste.Length; i++)
            {
                soma = soma + teste[i];

            }
            Console.WriteLine($"A media da soma eh {soma / teste.Length}");
            return soma;
        }

        private static int[] RemoverValor(int[] teste)
        {
            Console.WriteLine("informe o valor a ser removido: ");
            int remover = Convert.ToInt32(Console.ReadLine());

            var lista = teste.ToList();
            lista.Remove(remover);
            teste = lista.ToArray();


            for (int i = 0; i < teste.Length; i++)
            {
                Console.Write($"{teste[i]} ");
            }

            return teste;
        }

       
    }
}
