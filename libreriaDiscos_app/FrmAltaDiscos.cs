using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace libreriaDiscos_app
{
    public partial class FrmAltaDiscos : Form
    {
        private Discos disco = null;
        public FrmAltaDiscos()
        {
            InitializeComponent();
        }
        public FrmAltaDiscos(Discos seleccionado)
        {
            InitializeComponent();
            disco = seleccionado;
            Text = "Modificar Disco";
        }
        private void btnCnacelar_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (disco == null)
                    disco = new Discos();
                disco.Titulo = txbNombre.Text;
                disco.FechaLanzamiento = dtpFecha.Value;
                disco.CantidadCanciones = int.Parse(txbCantCanciones.Text);
                disco.Urlimagen = txbUrlImagen.Text;
                disco.Estilo = (Estilos)cmbGenero.SelectedItem;
                disco.TipoEdicion = (TiposEdicion)cmbEdicion.SelectedItem;

                if(disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado Exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FrmAltaDiscos_Load(object sender, EventArgs e)
        {
            try
            {
                EstilosNegocio estilo = new EstilosNegocio();
                TiposEdicionNegocio tipo = new TiposEdicionNegocio();

                cmbGenero.DataSource = estilo.Listar();
                cmbGenero.ValueMember = "Id";
                cmbGenero.DisplayMember = "Descripcion";

                cmbEdicion.DataSource = tipo.Listar();
                cmbEdicion.ValueMember = "Id";
                cmbEdicion.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    txbNombre.Text = disco.Titulo;
                    dtpFecha.Value = disco.FechaLanzamiento;
                    txbCantCanciones.Text = disco.CantidadCanciones.ToString();
                    txbUrlImagen.Text = disco.Urlimagen;
                    cargarImagen(txbUrlImagen.Text);

                    cmbGenero.SelectedValue = disco.Estilo.Id;
                    cmbEdicion.SelectedValue = disco.TipoEdicion.Id;
                }
                else
                    cargarImagen("");                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                ptbAltaDIscos.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbAltaDIscos.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk=");
            }    
        }

        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagen.Text);
        }
    }
}
