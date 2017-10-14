using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Modelo
{
    class Pais
    {
        private int idPais;
        private string nombre;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
