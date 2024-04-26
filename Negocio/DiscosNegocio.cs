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
        private AccesoDatos datos;
        public DiscosNegocio() 
        {
            datos = new AccesoDatos(); 
        }
        public List<Discos> Listar()
        {
            List<Discos> lista = new List<Discos>();
            try
            {
                datos.setearConsulta("select d.Id IdDisco, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa,e.Id IdEstilo, e.Descripcion Estilo,t.Id IdTipo, t.Descripcion Edicion from DISCOS d, ESTILOS e, TIPOSEDICION t where e.Id = d.IdEstilo and T.Id = d.IdTipoEdicion");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["IdDisco"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.Urlimagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion.Id = (int)datos.Lector["IdTipo"];
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
            try
            {
                datos.setearConsulta("insert into DISCOS(Titulo, FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)values(@Titulo, @FechaLanzamiento,@CantidadCanciones,@UrlImagenTapa,@IdEstilo,@IdTipoEdicion)");
                datos.setearParametro("@Titulo", nuevo.Titulo);
                datos.setearParametro("@FechaLanzamiento", nuevo.FechaLanzamiento);
                datos.setearParametro("@CantidadCanciones", nuevo.CantidadCanciones);
                datos.setearParametro("@UrlImagenTapa", nuevo.Urlimagen);
                datos.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@IdTipoEdicion",nuevo.TipoEdicion.Id);

                datos.ejecutarAccion();
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
        public void modificar(Discos modificado) 
        {
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Titulo, FechaLanzamiento = @Fecha, CantidadCanciones = @CantCaniones, UrlImagenTapa = @Url, IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipo where id = @Id");
                datos.setearParametro("@Titulo", modificado.Titulo);
                datos.setearParametro("@Fecha", modificado.FechaLanzamiento);
                datos.setearParametro("@CantCaniones", modificado.CantidadCanciones);
                datos.setearParametro("@Url", modificado.Urlimagen);
                datos.setearParametro("@IdEstilo", modificado.Estilo.Id);
                datos.setearParametro("@IdTipo", modificado.TipoEdicion.Id);
                datos.setearParametro("@Id",modificado.Id );

                datos.ejecutarAccion();
                    

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
        public void Eliminar (int Id)
        {
            try
            {
                datos.setearConsulta("delete from discos where id = @id");
                datos.setearParametro("@id",Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Discos> filtrar(string campo, string criterio, string filtro)
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select d.Id IdDisco, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa,e.Id IdEstilo, e.Descripcion Estilo,t.Id IdTipo, t.Descripcion Edicion from DISCOS d, ESTILOS e, TIPOSEDICION t where e.Id = d.IdEstilo and T.Id = d.IdTipoEdicion And ";
                if(campo == "Título")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Titulo like '"+filtro+"%'";
                            break;
                        case "Termina con":
                            consulta += "Titulo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Titulo like '%"+filtro+"%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "CantidadCanciones >"+filtro;
                            break;
                        case "Menor a":
                            consulta += "CantidadCanciones <" + filtro;
                            break;
                        default:
                            consulta += "CantidadCanciones =" + filtro;
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["IdDisco"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.Urlimagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion.Id = (int)datos.Lector["IdTipo"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
