using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a14118187
{
    public class ATM
    {
        private Teclado _teclado;
        private DispensadorEfectivo _dispensadorEfectivo;
        private RanuraDeposito _ranuraDeposito;
        private Pantalla _pantalla;
        private Retiro _retiro;
        BaseDatos _baseDatos = null;

        public void comenzar()
        {

            // Console.Write("comenzar")

            _baseDatos = new BaseDatos();

            _baseDatos.rellenarDatos();

            _baseDatos.VerificarUsuario(234, 1234);

            _baseDatos.verSaldoDisponible(234);

            _baseDatos.verSaldoTotal(234);
            Console.ReadKey();

        }
    }
}
