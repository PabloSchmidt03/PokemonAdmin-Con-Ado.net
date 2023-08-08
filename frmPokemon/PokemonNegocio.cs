using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace frmPokemon
{
     class PokemonNegocio
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
                comando.CommandText = "SELECT NOMBRE, P.DESCRIPCION, URLIMAGEN, E.DESCRIPCION TIPO, D.DESCRIPCION DEBILIDAD FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.ID = P.IDTIPO AND D.ID = P.IDDEBILIDAD";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Nombre = (string)lector["NOMBRE"];
                    aux.Descripcion = (string)lector["DESCRIPCION"];
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

	}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }



