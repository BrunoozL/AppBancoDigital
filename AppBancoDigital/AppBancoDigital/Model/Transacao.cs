using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    internal class Transacao
    {
        public int ID { get; set; }
        public string data_hora { get; set; }
        public double valor { get;set; }
    }
}
