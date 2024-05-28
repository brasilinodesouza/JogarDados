using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace JogarDados.Models

{
    
    public class Config
    {
    string jogador1, jogador2;
    int pontuaçãoJogador1, pontuaçãoJogador2 = 0;
    int empate, rodadas;
    
        
        public void ConfigurarJogo()
        {
            Console.Clear();
            CriarJogarores();
            InicializaJogo();
            ContinuarOuSair();

        }

        public void CriarJogarores()
        {

            System.Console.WriteLine("Digite o nome do Jogador 1: ");
            jogador1 = Console.ReadLine();
            System.Console.WriteLine("Digite o nome do Jogador 2: ");
            jogador2 = Console.ReadLine();
            System.Console.WriteLine("Informe quantas rodadas: ");
            rodadas = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine($"Jogador(a) 1: {jogador1} vs Jogador(a) 2: {jogador2}\n~> Quantidade de rodadas: {rodadas}\n");
        }
    
        public void InicializaJogo()
                {
            int rodadaAtual = 1;

            while ( rodadaAtual <= rodadas )
            {   
            System.Console.WriteLine("Rodada atual: " +rodadaAtual);
            Random rng = new Random();
            int rand1 = rng.Next(1,7);
            System.Console.WriteLine($"Jogador(a) {jogador1} tirou o numero: {rand1}");
            int rand2 = rng.Next(1,7); 
            System.Console.WriteLine($"Jogador(a) {jogador2} tirou o numero: {rand2}");
            if (rand1 > rand2)
            {
                System.Console.WriteLine($"{jogador1} Venceu a rodada!");
                pontuaçãoJogador1 ++;
            }else if( rand2 == rand1){
                System.Console.WriteLine("Empate");
                empate ++;
            }else{
                System.Console.WriteLine($"{jogador2} Venceu a rodada!");
                pontuaçãoJogador2 ++;
            }

           
        System.Console.WriteLine("");
        rodadaAtual++;

            }
        System.Console.WriteLine($"Pontuação do {jogador1}: {pontuaçãoJogador1}");
        System.Console.WriteLine($"Pontuação do {jogador2}: {pontuaçãoJogador2}");
        System.Console.WriteLine($"Empates: {empate}");
        }

        public void ContinuarOuSair()
        {
            System.Console.WriteLine("\n#######################################");
            System.Console.WriteLine("Deseja continuar com o jogo?\n Digite (y) - Continuar \n Digite (n) para Sair");
            string continuar = Console.ReadLine().ToLower();
            
            switch (continuar)
            {   
                case "y":
                    ConfigurarJogo();
                    break;
                case "n":
                    Console.Clear();
                    System.Console.WriteLine("Obrigado!");
                    break;
                default:    
                    System.Console.WriteLine("Opção invalida");
                    ContinuarOuSair();
                    break;
            }
            


        }
    }
}