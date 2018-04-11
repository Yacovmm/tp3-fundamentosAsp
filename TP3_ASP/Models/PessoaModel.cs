using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP3_ASP.Models
{
    public class PessoaModel
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public DateTime Nascimento { get; set; }
    }
}

    public class Parametro
    {
        public string MeuParametro { get; set; }
    }