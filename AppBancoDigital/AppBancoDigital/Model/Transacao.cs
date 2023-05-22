using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Transacao
    {
        public int? ID { get; set; }
        public DateTime data_hora { get; set; }
        public double valor { get;set; }
    }
}
