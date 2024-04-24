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
                cargarImagen(ListaDiscos[0].Urlimagen);
                prepararDgv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }           
        }
        private void prepararDgv()
        {
            dgvListaDiscos.Columns[0].Visible = false;
            dgvListaDiscos.Columns[4].Visible = false;
            dgvListaDiscos.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            if(dgvListaDiscos.CurrentRow != null)
            {
                Discos selec = (Discos)dgvListaDiscos.CurrentRow.DataBoundItem;
                cargarImagen(selec.Urlimagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaDiscos alta = new FrmAltaDiscos();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaDiscos.CurrentRow != null)
            {
                Discos seleccionado;
                seleccionado = (Discos)dgvListaDiscos.CurrentRow.DataBoundItem;
                FrmAltaDiscos modificar = new FrmAltaDiscos(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            else
                MessageBox.Show("Seleccione un Disco");
        }

        private void btnElimFisica_Click(object sender, EventArgs e)
        {
            if (dgvListaDiscos.CurrentRow != null)
            {
                Discos seleccionado = new Discos();
                DiscosNegocio datos = new DiscosNegocio();
                try
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro deseas Eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes) 
                    {
                        seleccionado = (Discos)dgvListaDiscos.CurrentRow.DataBoundItem;
                        datos.Eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
            else
                MessageBox.Show("Seleccione un Disco");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {


        }

        private void txbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listaFiltrada;
            string filtro = txbFiltroRapido.Text;

            if (filtro != "")
            {
                listaFiltrada = ListaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.TipoEdicion.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaDiscos;
            }
            dgvListaDiscos.DataSource = null;
            dgvListaDiscos.DataSource = listaFiltrada;
            prepararDgv();
        }
    }
}
