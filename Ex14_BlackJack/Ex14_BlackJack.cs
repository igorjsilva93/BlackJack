using System;

namespace Ex14_BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalPoints = 0;

            // Distribui 2 cartas iniciais
            for (int i = 0; i < 2; i++)
            {
                int naipe = random.Next(1, 5); // Naipe de 1 a 4
                int carta = random.Next(1, 14); // Carta de 1 a 13
                int pontos;

                switch (carta)
                {
                    case 1:
                        pontos = 11; // ÁS vale 11
                        break;
                    case 11:
                    case 12:
                    case 13:
                        pontos = 10; // Valete, Dama e Rei valem 10
                        break;
                    default:
                        pontos = carta; // Cartas numéricas valem seu próprio número
                        break;
                }

                string nomeCarta;
                switch (carta)
                {
                    case 1:
                        nomeCarta = "Ás";
                        break;
                    case 11:
                        nomeCarta = "Valete";
                        break;
                    case 12:
                        nomeCarta = "Dama";
                        break;
                    case 13:
                        nomeCarta = "Rei";
                        break;
                    default:
                        nomeCarta = carta.ToString();
                        break;
                }

                string nomeNaipe;
                switch (naipe)
                {
                    case 1:
                        nomeNaipe = "Copas";
                        break;
                    case 2:
                        nomeNaipe = "Espadas";
                        break;
                    case 3:
                        nomeNaipe = "Paus";
                        break;
                    case 4:
                        nomeNaipe = "Ouros";
                        break;
                    default:
                        nomeNaipe = "Desconhecido";
                        break;
                }

                Console.WriteLine($"Você recebeu {nomeCarta} de {nomeNaipe}, que vale {pontos} pontos.");
                totalPoints += pontos;
            }

            Console.WriteLine($"Você começou com {totalPoints} pontos.");

            while (true)
            {
                Console.WriteLine("Escolha: (1) Continuar jogando (2) Desistir");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    int naipe = random.Next(1, 5); // Naipe de 1 a 4
                    int carta = random.Next(1, 14); // Carta de 1 a 13
                    int pontos;

                    switch (carta)
                    {
                        case 1:
                            pontos = 11; // ÁS vale 11
                            break;
                        case 11:
                        case 12:
                        case 13:
                            pontos = 10; // Valete, Dama e Rei valem 10
                            break;
                        default:
                            pontos = carta; // Cartas numéricas valem seu próprio número
                            break;
                    }

                    string nomeCarta;
                    switch (carta)
                    {
                        case 1:
                            nomeCarta = "Ás";
                            break;
                        case 11:
                            nomeCarta = "Valete";
                            break;
                        case 12:
                            nomeCarta = "Dama";
                            break;
                        case 13:
                            nomeCarta = "Rei";
                            break;
                        default:
                            nomeCarta = carta.ToString();
                            break;
                    }

                    string nomeNaipe;
                    switch (naipe)
                    {
                        case 1:
                            nomeNaipe = "Copas";
                            break;
                        case 2:
                            nomeNaipe = "Espadas";
                            break;
                        case 3:
                            nomeNaipe = "Paus";
                            break;
                        case 4:
                            nomeNaipe = "Ouros";
                            break;
                        default:
                            nomeNaipe = "Desconhecido";
                            break;
                    }

                    Console.WriteLine($"Você recebeu {nomeCarta} de {nomeNaipe}, que vale {pontos} pontos.");
                    totalPoints += pontos;

                    if (totalPoints > 21)
                    {
                        Console.WriteLine($"Você ultrapassou 21 pontos. Pontuação final: {totalPoints}. Você perdeu!");
                        break;
                    }
                    else if (totalPoints == 21)
                    {
                        Console.WriteLine("Parabéns! Você fez exatamente 21 pontos e ganhou!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sua pontuação atual é {totalPoints}.");
                    }
                }
                else if (escolha == "2")
                {
                    Console.WriteLine($"Você desistiu com {totalPoints} pontos. Você perdeu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, escolha novamente.");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}
