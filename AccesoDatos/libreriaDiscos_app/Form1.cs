using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace libreriaDiscos_app
{
    public partial class FrmPrincipal : Form
    {
        private List<Discos> ListaDiscos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                DiscosNegocio datos = new DiscosNegocio();
                ListaDiscos = datos.Listar();
                dgvListaDiscos.DataSource = ListaDiscos;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
