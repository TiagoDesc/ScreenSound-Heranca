﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2.Classes.Oficina
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Contato { get; set; }

        public Cliente(string nome, string contato) 
        {
            Nome = nome;
            Contato = contato;

        }
    }
}
