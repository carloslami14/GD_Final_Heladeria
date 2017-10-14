using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Modelo
{
    class Localidad
    {
        private int idLocalidad;
        private string nombre;
        private Provincia provinvia;

        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Provincia Provincia
        {
            get { return provinvia; }
            set { provinvia = value; }
        }
    }
}
