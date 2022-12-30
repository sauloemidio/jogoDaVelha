using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace JogoDaVelha
{
    class Program
    {

        
       static string Player(string vez)
        {
            if(vez == "O")
            {
                vez = "O";
            }
            else
            {
                vez = "X";
            }


            return vez;        }


        public static void Main(string[] args)
        {

        
            Game velha = new Game();
            velha.Start();
            
           
        }

      }

    }


