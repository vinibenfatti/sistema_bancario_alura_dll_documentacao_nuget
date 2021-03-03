﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021,5,15);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferença = dataFimPagamento - dataCorrente;

            string mensagem = "Venvimento em: " + TimeSpanHumanizeExtensions.Humanize(diferença);

            Console.WriteLine(mensagem);
            
            Console.ReadLine();
        }

        }
    }

