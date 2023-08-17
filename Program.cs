using System;

/* Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.Os códigos utilizados são:
    • 1,2,3,4 votos para os respectivos candidatos;
    • 5 voto nulo; 
    • 6 voto em branco.
    Assim, escreva um programa para receber um único voto e imprima: 
    • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
    • Se o usuário votou nulo: "Voto nulo contabilizado..."
    • Se o usuário votou em branco: "Voto branco contabilizado...
      Se o voto for diferente de todas as opções acima: "Voto inválido..."
*/

namespace Voto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CANDIDATO1 = 1, CANDIDATO2 = 2, CANDIDATO3 = 3, CANDIDATO4 = 4;
            const int NULO = 5, BRANCO = 6;

            Console.WriteLine("--Programa Voto--\n");

            Console.Write("Informe o voto:");
            int voto = int.Parse(Console.ReadLine());

            #region "switch"

            switch (voto)
            {
                case CANDIDATO1:
                case CANDIDATO2:
                case CANDIDATO3:
                case CANDIDATO4:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case NULO:
                    Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case BRANCO:
                    Console.WriteLine("Voto branco contabilizado...");
                    break;
                default:
                    Console.WriteLine("Voto inválido...");
                    break;
            }

            #endregion

            #region "Estruturas de decisões simples"

            if (voto == CANDIDATO1)
                Console.WriteLine("Voto contabilizado com sucesso...");
                
            if (voto == CANDIDATO2)
                Console.WriteLine("Voto contabilizado com sucesso...");
            
            if (voto == CANDIDATO3)
               Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == CANDIDATO4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == NULO)
                Console.WriteLine("Voto nulo contabilizado...");

            if (voto == BRANCO)
                Console.WriteLine("Voto branco contabilizado...");

            if (voto != CANDIDATO1 && voto != CANDIDATO2 // :( :( :( :( :( :( :( :( :( :( :( :( 
                && voto != CANDIDATO3 && voto != CANDIDATO4 
                && voto != NULO && voto != BRANCO)
                Console.WriteLine("Voto inválido...");

            if (voto != CANDIDATO1) // :(((((((((((((((((((((((((((((((((((((((((((( ED aninhada.
                if (voto != CANDIDATO2)
                    if (voto != CANDIDATO3)
                        if (voto != CANDIDATO4)
                            if (voto != NULO)
                                if (voto != BRANCO)
                                    Console.WriteLine("Voto inválido...");

            #endregion

            #region "Estrutura de decisão encadeada sem operador Lógico"

            if (voto == CANDIDATO1)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == CANDIDATO2)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == CANDIDATO3)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == CANDIDATO4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == NULO)
                Console.WriteLine("Voto nulo contabilizado...");

            else if (voto == BRANCO)
                Console.WriteLine("Voto branco contabilizado...");

            else
                Console.WriteLine("Voto inválido...");

            #endregion

            #region "Estrutura de decisão encadeada com operador lógico OU => ||"

            /*
             Operaores lógicos: Permitir utilizar mais de uma condição

             OU => voto == CANDIDATO1 || voto == CANDIDATO2 
             */

            if (voto == CANDIDATO1 || voto == CANDIDATO2 || voto == CANDIDATO3 || voto == CANDIDATO4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == NULO)
                Console.WriteLine("Voto nulo contabilizado...");

            else if (voto == BRANCO)
                Console.WriteLine("Voto branco contabilizado...");

            else
                Console.WriteLine("Voto inválido...");

            #endregion

            #region "Estrutura de decisão encadeada com operador lógico E => &&"

            /*
             Operaores lógicos: Permitir utilizar mais de uma condição

             E => voto >= CANDIDATO1 && voto <= CANDIDATO4 
             */

            if (voto >= CANDIDATO1 && voto <= CANDIDATO4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == NULO)
                Console.WriteLine("Voto nulo contabilizado...");

            else if (voto == BRANCO)
                Console.WriteLine("Voto branco contabilizado...");

            else
                Console.WriteLine("Voto inválido...");

            #endregion

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
