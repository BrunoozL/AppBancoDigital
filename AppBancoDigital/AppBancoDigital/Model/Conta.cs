using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Conta
    {
        public int id { get; set; }
        public Correntista id_corrente { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }
        public string tipo { get; set; }
        public DateTime data_abertura { get; set; }

    }
}
