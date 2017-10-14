using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Modelo
{
    class Proveedor
    {
        private int cuit;
        private string razonSocial;
        private Domicilio domicilio;

        public int Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public Domicilio Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
    }
}
