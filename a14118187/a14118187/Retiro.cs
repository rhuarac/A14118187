using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a14118187
{
    public class Retiro
    {
        public int Efectivo { get; set; }
        public int numeroTicket { get; set; }
        public ATM Atm { get; set; }

        public Retiro()
        {
        }

        public Retiro(ATM atm)
        {
            Atm = atm;
        }

        public Retiro(int numeroTicket)
        {
            numeroTicket = numeroTicket;
        }

        public void CalcRetiro()
        {
            // numeroTicket= Atm;

        }
    }
}
