using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DiscosNegocio
    {
        public List<Discos> Listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, e.Descripcion Estilo, t.Descripcion Edicion from DISCOS d, ESTILOS e, TIPOSEDICION t where e.Id = d.IdEstilo and T.Id = d.IdTipoEdicion");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.Urlimagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Discos nuevo)
        {
            AccesoDatos date = new AccesoDatos();
            try
            {
                date.setearConsulta("insert into DISCOS(Titulo, FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)values(@Titulo, @FechaLanzamiento,@CantidadCanciones,@UrlImagenTapa,@IdEstilo,@IdTipoEdicion)");
                date.setearParametro("@Titulo", nuevo.Titulo);
                date.setearParametro("@FechaLanzamiento", nuevo.FechaLanzamiento);
                date.setearParametro("@CantidadCanciones", nuevo.CantidadCanciones);
                date.setearParametro("@UrlImagenTapa", nuevo.Urlimagen);
                date.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                date.setearParametro("@IdTipoEdicion",nuevo.TipoEdicion.Id);

                date.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                date.cerrarConexion();
            }
        }
    }
}
