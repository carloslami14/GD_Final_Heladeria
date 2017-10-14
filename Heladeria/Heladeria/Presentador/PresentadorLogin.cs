using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heladeria.Interfaces;

namespace Heladeria.Presentador
{
    class PresentadorLogin
    {
        private readonly ILogin _vista;

        public PresentadorLogin(ILogin vista)
        {
            _vista = vista;
        }


    }
}
