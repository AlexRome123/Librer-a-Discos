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
        public FrmAltaDiscos()
        {
            InitializeComponent();
        }
        private void btnCnacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos Disco = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                Disco.Titulo = txbNombre.Text;
                Disco.FechaLanzamiento = dtpFecha.Value;
                Disco.CantidadCanciones = int.Parse(txbCantCanciones.Text);
                Disco.Urlimagen = txbUrlImagen.Text;
                Disco.Estilo = (Estilos)cmbGenero.SelectedItem;
                Disco.TipoEdicion = (TiposEdicion)cmbEdicion.SelectedItem;
                
                negocio.agregar(Disco);
                MessageBox.Show("Agregado Exitosamente");
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
