using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    internal class Correntista
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public string data_nasc { get;set; }
        public string senha { get; set; }
    }
}
