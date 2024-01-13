using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Data.SqlTypes;
using System.ComponentModel.Design;

namespace Conexion_DB
{
    public class DB_conectar
    {
        public List<Articulos> Listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Id, Codigo, Nombre, a.Descripcion, ImagenUrl, c.Descripcion as Categoria, m.Descripcion as Marca, Precio from ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.Id  and IdCategoria = c.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Imagenurl = (string)lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descri = (string)lector["Categoria"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    aux.Precio = (decimal)lector["Precio"];
                    
                    lista.Add(aux);


                }
                conexion.Close();
                return lista;


            }

            catch (Exception ex )
            {

                throw ex;
               
                
            }

        }
    
    


        public  void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, ImagenUrl, Precio, Marca, Categoria) values(@Codigo,@Nombre,@Descripcion,@ImagenUrl,@Precio,@Marca, @Categoria)");
          
             datos.setearParametro("@Codigo", nuevo.Codigo);
             datos.setearParametro("@Nombre", nuevo.Nombre);
             datos.setearParametro("@Descripcion", nuevo.Descripcion);
             datos.setearParametro("@ImagenUrl", nuevo.Imagenurl);
             datos.setearParametro("@Marca", nuevo.Marca.Id);
             datos.setearParametro("@Categoria", nuevo.Categoria.Id);
             datos.setearParametro("@Precio", nuevo.Precio);

             datos.ejecutarAcion();

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


        public void modificar(Articulos arti)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, ImagenUrl = @ImagenUrl, Descripcion = @Descripcion, Precio = @Precio where Id = @Id");
                datos.setearParametro("@Id", arti.Id);
                datos.setearParametro("@Codigo", arti.Codigo);
                datos.setearParametro("@Nombre", arti.Nombre);
                datos.setearParametro("@ImagenUrl", arti.Imagenurl);
                datos.setearParametro("@Descripcion", arti.Descripcion);
                datos.setearParametro("@Precio", arti.Precio);

                datos.ejecutarAcion();



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}

        }


        public void eliminar( int id)
        {
            try
            {

                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Articulos where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAcion();
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
}   }
//comentario