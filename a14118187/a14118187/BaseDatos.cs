using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a14118187
{
    public class BaseDatos
    {
        public Cuenta _cuenta;

        public List<Cuenta> _cuenta1;


        public BaseDatos()
        {
            _cuenta = new Cuenta();

            _cuenta1 = new List<Cuenta>();
        }


        public void rellenarDatos()
        {

            //  numCuenta = 123;

            Console.WriteLine("Inicio de la  base de datos de las cuentas");

            try
            {

                _cuenta.numeroCuenta = 234;
                _cuenta.pin = 1234;
                _cuenta.sldDisponible = 1234;
                _cuenta.sldTotal = 1234;

                _cuenta1.Add(_cuenta);

                _cuenta.numeroCuenta = 2345;
                _cuenta.pin = 12345;
                _cuenta.sldDisponible = 12345;
                _cuenta.sldTotal = 12345;

                _cuenta1.Add(_cuenta);


                Console.WriteLine("Se lleno la base de datos de las cuentas");

            }
            catch (Exception ex)
            {
                // Code to handle the exception goes here.
                // Only catch exceptions that you know how to handle.
                // Never catch base class System.Exception without
                // rethrowing it at the end of the catch block.
            }
        }

        public bool VerificarUsuario(int numeroCuenta, int pin)
        {

            if (_cuenta1 == null)
            {
                Console.WriteLine("Entro");

                return false;
            }
            else
            {
                for (int i = 0; i < _cuenta1.Count; i++)
                {

                    if (numeroCuenta == _cuenta1[i].numeroCuenta && pin == _cuenta1[i].pin)
                    {

                        Console.WriteLine("Login Exitoso");
                        return true;
                    }

                }
                return false;
            }

        }

        public double verSaldoDisponible(int numeroCuenta)
        {

            int variabletmp = 0;

            for (int k = 0; k < _cuenta1.Count; k++)
            {
                if (numeroCuenta == _cuenta1[k].numeroCuenta)
                {

                    variabletmp = k;

                    Console.WriteLine("El saldo disponible es : " + variabletmp);
                }

            }

            Console.WriteLine("El saldo disponible es :" + _cuenta1[variabletmp].sldDisponible);

            return _cuenta1[variabletmp].sldDisponible;
        }


        public double verSaldoTotal(int numeroCuenta)
        {

            int variabletmp = 0;

            for (int j = 0; j < _cuenta1.Count; j++)
            {
                if (numeroCuenta == _cuenta1[j].numeroCuenta)
                {

                    variabletmp = j;
                }

            }

            Console.WriteLine("El saldo disponible es :" + _cuenta1[variabletmp].sldTotal);

            return _cuenta1[variabletmp].sldTotal;

        }

        public void Debitacion(int numeroCuenta, double monto)
        {
        }

        public void Acreditacion(int numeroCuenta, double monto)
        {
        }
    }
}
