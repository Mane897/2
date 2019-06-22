using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class clsCLIENTES
    {
        private int _IdCliente;

        private string _Nombres;

        private string _Apellidos; //encapsular usando "acciones rapidas y refactorizaciones"

        public int IdClientes { get => _IdCliente; set => _IdCliente = value ; } //encapsulamiento con "prop" y doble tab

        public string Nombres { get => _Nombres; set => _Nombres = value ; }

        public string Apellidos { get => _Apellidos; set => _Apellidos = value ; }

    }
}
