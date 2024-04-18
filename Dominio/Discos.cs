using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Discos
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha Lanzamiento")]

        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad Canciones")]

        public int CantidadCanciones { get; set; }
        public string Urlimagen { get; set; }
        public Estilos Estilo { get; set; }
        [DisplayName("Edición")]

        public TiposEdicion TipoEdicion { get; set; }
        public Discos()
        {
            Estilo = new Estilos();
            TipoEdicion = new TiposEdicion();
        }
    }
}
