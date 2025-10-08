using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace una_psc_alg_revisao_a1_ex01
{
    public class Verify
    {
        public static double Question(double increase, string pergunta, int attempts, bool reverse, out string answer)
        {
            int thisAttempt = attempts;
            string resposta;
            while (thisAttempt > 0)
            {
                try
                {
                    Console.WriteLine(pergunta);
                    Console.WriteLine("                                      ");
                    resposta = Console.ReadLine().ToUpper();
                    if (resposta == "SIM")
                    {
                        Console.WriteLine($"- Resposta obtida com sucesso!       ");
                        Console.WriteLine("======================================");
                        if (!reverse)
                        {
                            answer = "Sim";
                            return increase;
                        }
                        else
                        {
                            answer = "Sim";
                            return 0;
                        }
                    }
                    else if (resposta == "NAO")
                    {
                        Console.WriteLine($"- Resposta obtida com sucesso!       ");
                        Console.WriteLine("======================================");
                        if (!reverse)
                        {
                            answer = "Não";
                            return 0;
                        }
                        else
                        {
                            answer = "Não";
                            return increase;
                        }
                    }
                    else
                    {
                        throw new Exception($"{resposta} não é uma resposta válida!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex);
                }
                thisAttempt--;
            }
            throw new Exception("Não foi possível realizar o diagnóstico." +
                                "Gentileza procurar ajuda médica caso apareça algum sintoma.");
        }
        public static void Testing(double porcentagem, string viagem)
        {
            if (porcentagem <= 0.3)
            {
                if (viagem == "Não")
                {
                    Console.WriteLine("======================================");
                    Console.WriteLine("Paciente sob observação. Caso apareça ");
                    Console.WriteLine("algum sintoma, gentileza buscar       ");
                    Console.WriteLine("assistência médica.                   ");
                    Console.WriteLine("======================================");
                }
                else
                {
                    Console.WriteLine("======================================");
                    Console.WriteLine("Você ficará sob observação por 05     ");
                    Console.WriteLine("dias.                                 ");
                    Console.WriteLine("======================================");
                }
            }
            else if (porcentagem <= 0.6)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Paciente com risco de estar infectado.");
                Console.WriteLine("Gentileza aguardar em lockdown por 02 ");
                Console.WriteLine("dias para ser acompanhado.            ");
                Console.WriteLine("======================================");
            }
            else if (porcentagem < 0.9)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Paciente com alto risco de estar      ");
                Console.WriteLine("infectado. Gentileza aguardar em      ");
                Console.WriteLine("lockdown por 05 dias para ser         ");
                Console.WriteLine("acompanhado.                          ");
                Console.WriteLine("======================================");
            }
            else
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Paciente crítico! Gentileza aguardar  ");
                Console.WriteLine("em lockdown por 10 dias para ser      ");
                Console.WriteLine("acompanhado.                          ");
                Console.WriteLine("======================================");
            }
            Console.WriteLine($"Chance de estar infectado: {porcentagem:P0}");
        }
    }
}