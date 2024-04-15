using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Discos
    {
        public int Id {  get; set; }
        public string Titulo {  get; set; }
        public DateTime FechaLanzamiento {  get; set; }
        public int CantidadCanciones { get; set; }
        public string Urlimagen {  get; set; }
        public Estilos Estilos { get; set; }
        public TiposEdicion TiposEdicion { get; set; }
    }
}
