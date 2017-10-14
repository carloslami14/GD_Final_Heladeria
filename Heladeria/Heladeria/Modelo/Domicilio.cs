using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Modelo
{
    class Domicilio
    {
        private int calle;
        private string numero;
        private Localidad localidad;

        public int Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
    }
}
