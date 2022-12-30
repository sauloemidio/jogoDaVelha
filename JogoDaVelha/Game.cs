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
            
            string msg = "Bem vindo";
            int[] options = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Display mainMenu  = new Display(msg, options);
            int selectdIndex = mainMenu.Rodar();


            WriteLine("Enter = sair");

            ReadKey(true);
        }

    }
}
