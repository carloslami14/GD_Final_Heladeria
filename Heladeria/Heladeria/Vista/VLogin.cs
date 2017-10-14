using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Interfaces;
using Heladeria.Presentador;

namespace Heladeria.Vista
{
    public partial class VLogin : Form, ILogin
    {
        private PresentadorLogin _presentador;

        public VLogin()
        {
            InitializeComponent();
            _presentador = new PresentadorLogin(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
