namespace ExercicioArray.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Array\n");

            int[] array = [-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6];

            int[] cloneArray = (int[])array.Clone();


            int soma = 0;
            ExibirNaTela(array);

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------");

            ValoresMaiores(array);

            Console.WriteLine("----------------------------");

            ValoresMenores(array);

            Console.WriteLine("----------------------------");

            soma = Media(array, soma);

            Console.WriteLine("----------------------------");
            array = RemoverValor(cloneArray);

            Console.ReadLine();
        }

        private static void ExibirNaTela(int[] array)
        {

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }

        private static void ValoresMaiores(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine($"O maior valor eh {array[15]}");
            Console.WriteLine($"O tres maiores valores são {array[15]} {array[14]} {array[13]} ");
        }

        private static void ValoresMenores(int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine($"O menor valor eh {array[15]}");
            Console.WriteLine($"os valores negativos são {array[15]} {array[14]} {array[13]} ");
        }

        private static int Media(int[] array, int soma)
        {
            for (int i = 0; i < array.Length; i++)
            {
                soma = soma + array[i];

            }
            Console.WriteLine($"A media da soma eh {soma / array.Length}");
            return soma;
        }

        private static int[] RemoverValor(int[] array)
        {
            Console.WriteLine("informe o valor a ser removido: ");
            int remover = Convert.ToInt32(Console.ReadLine());

            var lista = array.ToList();
            lista.Remove(remover);
            array = lista.ToArray();


            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            // Array.ForEach(array, Console.Write); Outra opcao de exibicao

            return array;
        }


    }
}
