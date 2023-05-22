using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Conta
    {
        public int? ID { get; set; }
        public string limite { get; set; }
        public string tipo { get; set; }
        public double saldo { get; set; }

    }
}
