﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaEntrada = int.Parse(Console.ReadLine());
            string dia;

            switch (diaEntrada){
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "valor inválido";
                    break;
            }

            Console.WriteLine($"Dia da semana: {dia}");
        }
    }
}
