using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Modelo
{
    class Provincia
    {
        private int idProvinvia;
        private string nombre;
        private Pais pais;

        public int IdProvinvia
        {
            get { return idProvinvia; }
            set { idProvinvia = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }
    }
}
