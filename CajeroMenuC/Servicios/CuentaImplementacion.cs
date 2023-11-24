using CajeroMenuC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void darAltaCuenta(List<CuentaDto> listaCuenta)
        {
            CuentaDto cuentaNueva = crearNuevaCuenta();

            listaCuenta.Add(cuentaNueva);
        }
        private CuentaDto crearNuevaCuenta()
        {
            CuentaDto cuenta = new CuentaDto();

            Console.WriteLine("Introduzca el id: ");
            cuenta.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el Isban: ");
            cuenta.Isban = Console.ReadLine();

            Console.WriteLine("Introduzca el swift: ");
            cuenta.Swift = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha de alta: ");
            cuenta.FchaAlta1 = Console.ReadLine();

          

            return cuenta;

        }
    }
}
