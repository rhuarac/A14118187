using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a14118187
{
    public class Cuenta
    {
        public int numeroCuenta { get; set; }
        public int pin { get; set; }
        public double sldTotal { get; set; }
        public double sldDisponible { get; set; }

        public Cuenta() { }

        public Cuenta(int numeroCuenta, int pin, double sldTotal, double sldDisponible)
        {

            this.numeroCuenta = numeroCuenta;
            this.pin = pin;
            this.sldTotal = sldTotal;
            this.sldDisponible = sldDisponible;
        }

    }
}
