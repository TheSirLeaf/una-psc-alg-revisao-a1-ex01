using static una_psc_alg_revisao_a1_ex01.Verify;

string nome;
int idade;
int tentativas = 3;
double totalRisco = 0;
string[] respostas = new string[4];

Console.WriteLine("======================================");
Console.WriteLine("=  Programa de Triagem de Pacientes  =");
Console.WriteLine("======================================");
Console.WriteLine("- Usando 'SIM' ou 'NAO', responda as  ");
Console.WriteLine("  perguntas a seguir:                 ");
Console.WriteLine("======================================");
Console.WriteLine("- Digite o seu nome:                  ");
Console.WriteLine("                                      ");
nome = Console.ReadLine();
Console.WriteLine($"- Nome: {nome} // Cadastrado!        ");
Console.WriteLine("- Digite a sua idade:                 ");
Console.WriteLine("                                      ");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"- Idade: {idade} // Cadastrado!      ");
Console.WriteLine("======================================");

totalRisco += Question(0.1, "- Seu cartão de vacina está em dia?   ", tentativas, true, out respostas[0]);
totalRisco += Question(0.3, "- Teve sintomas recentes?             ", tentativas, false,out respostas[1]);
totalRisco += Question(0.3, "- Teve contato com pessoa infectada?  ", tentativas, false,out respostas[2]);
totalRisco += Question(0.3, "- Retornando de viagem?               ", tentativas, false,out respostas[3]);

Testing(totalRisco, respostas[3]);