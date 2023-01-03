using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace JogoDaVelha
{
    internal class Game
    {

        public void Start()
        {
            
            string msg = "\tBem vindo" +
                "\n " +
                "\n 1 - Para INICIAR Pressione SETA PARA CIMA" +
                "\n 2 - Escolha a casa pressionando SETA PARA CIMA (UpArrow)" +
                "\n 3 - Marque a casa pressionando a tecla ESPAÇO (Spacebar)" +
                "\n 4 - Para encerrar o jogo pressione ENTER" +
                "\n 5 - O Primeiro a será O X" +
                "\n ";

            int[] options = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Display mainMenu  = new Display(msg, options);
            int selectdIndex = mainMenu.Rodar();


            WriteLine("Enter = sair");

            ReadKey(true);
        }

    }
}
