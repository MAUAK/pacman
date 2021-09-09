using System;

namespace pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            string reposta;

            inimigos fantasma1, fantasma2;
            pacMan pm;

            pm = new pacMan();
            fantasma1 = new inimigos();
            fantasma2 = new inimigos();

            Console.WriteLine("Velocidade do Pac Man");
            pm.velocidade = float.Parse(Console.ReadLine());
            andar();

            Console.WriteLine("Digite a cor do fantasma: ");
            fantasma1.cor = Console.ReadLine();

            Console.WriteLine("Dano? S/N");
            reposta = Console.ReadLine();
            if(reposta == "s")
            {
                damage();
            }
            
            if (pm.dead == false)
            {
                gamewin();
            }
            else if (pm.dead)
            {
                gameOver();
            }
            void andar()
            {
                if (pm.velocidade > 0)
                {
                    Console.WriteLine("Andando. ");
                }
                else
                {
                    Console.WriteLine("Parado. ");
                }
            }

            void damage()
            {
                fantasma1.dano = 1;
                pm.vida = pm.vida - fantasma1.dano;
                pm.dead = true;

            }

            void gamewin()
            {
                Console.WriteLine("Jogo ganho! Você matou todos os fantasmas.");
            }
            void gameOver()
            {
                Console.WriteLine("Você perdeu! Os fantamas te mataram.");
            }
        }
        
    }
}
