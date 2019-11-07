using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dojopuzzes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculando estatísticas simples

            /*
            Sua tarefa é processar uma seqüência de números inteiros para determinar as seguintes estatísticas:
            Valor mínimo
            Valor máximo
            Número de elementos na seqüência
            Valor médio
            Por exemplo para uma seqüência de números "6, 9, 15, -2, 92, 11", temos como saída:
            Valor mínimo: -2
            Valor máximo: 92
            Número de elementos na seqüência: 6
            Valor médio: 18.1666666
            */

            int[] arrNumeros = new int[] { 6, 9, 15, -2, 92, 11 };
            float acumulador = 0;
            var max = arrNumeros[0];
            var min = arrNumeros[0];
            

            for (var index = 0; index < arrNumeros.Length; index++)
            {
                acumulador += arrNumeros[index];
                if (arrNumeros[index] > max)
                {
                    max = arrNumeros[index];
                }
                if (arrNumeros[index] < min)
                {
                    min = arrNumeros[index];
                }
            }
            var qtdade = arrNumeros.Length;
            float media = acumulador / qtdade;
                     
            Console.WriteLine("Maximo: " + max);
            Console.WriteLine("Mínimo: " + min);
            Console.WriteLine("Quantidade digitada: " + qtdade);
            Console.WriteLine("Média: " + media);

            Console.ReadLine();

        }

    }
}


