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
            cargar();
        }
        private void cargar()
        {
            try
            {
                DiscosNegocio datos = new DiscosNegocio();
                ListaDiscos = datos.Listar();
                dgvListaDiscos.DataSource = ListaDiscos;
                dgvListaDiscos.Columns[0].Visible = false;
                dgvListaDiscos.Columns[4].Visible = false;
                cargarImagen(ListaDiscos[0].Urlimagen);
                dgvListaDiscos.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                ptbTapaDisco.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbTapaDisco.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk=");
            }
        }

        private void dgvListaDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListaDiscos != null)
            {
                Discos seleccionado = (Discos)dgvListaDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Urlimagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaDiscos alta = new FrmAltaDiscos();
            alta.ShowDialog();
            cargar();
        }
    }
}
