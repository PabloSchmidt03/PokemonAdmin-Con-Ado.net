using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dom;


namespace negocio
{
     public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            //Creo la lista de pokemon
            List<Pokemon> lista = new List<Pokemon>();
            //Creo las conexiones con DB
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NUMERO, NOMBRE, P.DESCRIPCION, URLIMAGEN, E.DESCRIPCION TIPO, D.DESCRIPCION DEBILIDAD FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.ID = P.IDTIPO AND D.ID = P.IDDEBILIDAD";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = (int)lector["NUMERO"];
                    aux.Nombre = (string)lector["NOMBRE"];
                    aux.Descripcion = (string)lector["DESCRIPCION"];
                    if (!(lector["urlimagen"] is DBNull))
                        aux.UrlImagen = (string)lector["URLIMAGEN"];
                    aux.Elemento = new Tipo();
                    aux.Elemento.Descripcion = (string)lector["TIPO"];
                    aux.Debilidad = new Tipo();
                    aux.Debilidad.Descripcion = (string)lector["DEBILIDAD"];



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
                conexion.Close();
            }
        }

        public void Agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into pokemons (numero, nombre, activo, descripcion, idtipo, iddebilidad,urlimagen)values(1,@nombre,1,@descripcion,@tipo,@debilidad,@url)");
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@tipo", nuevo.Elemento.Id);
                datos.setearParametro("@debilidad", nuevo.Debilidad.Id);
                datos.setearParametro("@url", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

	}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }



