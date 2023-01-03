using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;
using static System.ConsoleKey;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace JogoDaVelha
{
    internal class Display

    {
        private int SelectedIndex;
        private int[] Options;
        private string Prompt;
        private int[] marcados = new int[10];
        private string vez;
        private int[] marcadosO = new int[10];
        private int[] marcadosX = new int[10];
        private int posicao;
        string ultimaJogada = "";


        string[,] matrizJogo = { { " ", " ", " " },
                                 { " ", " ", " " },
                                 { " ", " ", " " } };

        static void Velha(string[,] matrizJogo)
        {

            Console.WriteLine($"\t {matrizJogo[0, 0]} |  {matrizJogo[0, 1]}  | {matrizJogo[0, 2]} ");
            Console.WriteLine("\t---|-----|---");
            Console.WriteLine($"\t {matrizJogo[1, 0]} |  {matrizJogo[1, 1]}  | {matrizJogo[1, 2]} ");
            Console.WriteLine("\t---|-----|---");
            Console.WriteLine($"\t {matrizJogo[2, 0]} |  {matrizJogo[2, 1]}  | {matrizJogo[2, 2]} ");
        }


        public Display(string msg, int[] options)
        {
            Prompt = msg;
            Options = options;
            SelectedIndex = 0;
            posicao = -1;
            vez = "O";
            

        }

        public void Verifica()
        {
            string msgVitoriaBolinha = "Ganhador é Bolinha\n PRESSIONE ENTER";
            string msgVitoriaX = "Ganhador X\n PRESSIONE ENTER";

            if (marcadosO.Contains(1) && marcadosO.Contains(2) && marcadosO.Contains(3))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(4) && marcadosO.Contains(5) && marcadosO.Contains(6))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(7) && marcadosO.Contains(8) && marcadosO.Contains(9))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(1) && marcadosO.Contains(4) && marcadosO.Contains(7))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(2) && marcadosO.Contains(5) && marcadosO.Contains(8))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(3) && marcadosO.Contains(6) && marcadosO.Contains(9))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(1) && marcadosO.Contains(5) && marcadosO.Contains(9))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosO.Contains(3) && marcadosO.Contains(5) && marcadosO.Contains(7))
            {
                Console.WriteLine($"{msgVitoriaBolinha}");
            }
            else if (marcadosX.Contains(1) && marcadosX.Contains(2) && marcadosX.Contains(3))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(4) && marcadosX.Contains(5) && marcadosX.Contains(6))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(7) && marcadosX.Contains(8) && marcadosX.Contains(9))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(1) && marcadosX.Contains(4) && marcadosX.Contains(7))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(2) && marcadosX.Contains(5) && marcadosX.Contains(8))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(3) && marcadosX.Contains(6) && marcadosX.Contains(9))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(1) && marcadosX.Contains(5) && marcadosX.Contains(9))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            else if (marcadosX.Contains(3) && marcadosX.Contains(5) && marcadosX.Contains(7))
            {
                Console.WriteLine($"{msgVitoriaX}");
            }
            
        }
    
    


        public void OpcoesTela()
        {
            Console.WriteLine(Prompt);
            if (ultimaJogada == "")
                ultimaJogada = "X";
            Console.WriteLine($"Vez de {ultimaJogada}");

            for (int i = 1; i < Options.Length; i++)

            {
                
                if (i == SelectedIndex)
                {
                    
                    if (SelectedIndex == 1 )
                    {
                        
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[0, 0] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[0, 0] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(9))
                            {
                                matrizJogo[2, 2] = " ";
                            }
                            matrizJogo[0, 0] = "#";

                        }
                        
                        
                    }
                    else if (SelectedIndex == 2)
                    {

                        
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[0, 1] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            
                            matrizJogo[0, 1] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(1))
                            {
                                matrizJogo[0, 0] = " ";
                            }
                            matrizJogo[0, 1] = "#";

                        }



                    }
                    else if (SelectedIndex == 3)
                    {

                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[0, 2] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[0, 2] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(2))
                            {
                                matrizJogo[0, 1] = " ";
                            }
                            matrizJogo[0, 2] = "#";

                        }

                    }
                    else if (SelectedIndex == 4)
                    {
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[1, 0] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[1, 0] = "X";
                        }
                        else
                        {
                            if (! marcados.Contains(3)) {
                                matrizJogo[0, 2] = " ";
                            }
                            
                            matrizJogo[1, 0] = "#";

                        }
                    }
                    else if (SelectedIndex == 5)
                    {
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[1, 1] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[1, 1] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(4))
                            {
                                matrizJogo[1, 0] = " ";
                            }
                            matrizJogo[1, 1] = "#";

                        }
                    }
                    else if (SelectedIndex == 6)
                    {

                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[1, 2] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[1, 2] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(5))
                            {
                                matrizJogo[1, 1] = " ";
                            }
                            matrizJogo[1, 2] = "#";

                        }
                    }
                    else if (SelectedIndex == 7)
                    {
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[2, 0] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[2, 0] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(6))
                            {
                                matrizJogo[1, 2] = " ";
                            }
                            matrizJogo[2, 0] = "#";

                        }
                    }
                    else if (SelectedIndex == 8)
                    {
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[2, 1] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[2, 1] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(7))
                            {
                                matrizJogo[2, 0] = " ";
                            }
                            matrizJogo[2, 1] = "#";

                        }
                    }
                    else if (SelectedIndex == 9)
                    {
                        if (marcadosO.Contains(SelectedIndex))
                        {
                            matrizJogo[2, 2] = "O";
                        }
                        else if (marcadosX.Contains(SelectedIndex))
                        {
                            matrizJogo[2, 2] = "X";
                        }
                        else
                        {
                            if (!marcados.Contains(8))
                            {
                                matrizJogo[2, 1] = " ";
                            }
                            matrizJogo[2, 2] = "#";

                        }
                    }


                }

                
            }

        }

        public int Rodar()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                OpcoesTela();
                Velha(matrizJogo);
                Verifica();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex++;

                    posicao = SelectedIndex - 1;

                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = -1;
                    }
                }
                else if(keyPressed == ConsoleKey.Spacebar)
                {
                    ultimaJogada = vez;

                    if (vez == "O")
                    {
                        vez = "X";
                        marcadosX[SelectedIndex] = SelectedIndex;
                        
                    }
                    else
                    {
                        vez = "O";
                        marcadosO[SelectedIndex] = SelectedIndex;
                        
                    }
                    marcados[SelectedIndex] = SelectedIndex;
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
