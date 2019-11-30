using _23_CRUDSuperHero_DAL.Connection;
using _23_CRUDSuperHero_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_DAL.Lists
{
    public class clsListadoSuperheroDAL
    {
        /// Se conecta a la BBDD y devuelve el listado de los superheroes
        /// </summary>
        /// <returns>Listado de Superhero List<clsSuperHero></returns>
        public List<clsSuperhero> listadoSuperheroes()
        {
            List<clsSuperhero> listado = new List<clsSuperhero>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsSuperhero oSuperhero;
            //Byte[] bytes = new Byte[20];
            try
            {
               
                miComando.CommandText = "SELECT * FROM dbo.Superheros";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oSuperhero = new clsSuperhero();
                        oSuperhero.ID = (Int16)miLector["ID"];
                        oSuperhero.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oSuperhero.Apellidos = (miLector["Apellidos"] is DBNull) ? "NULL" : (string)miLector["Apellidos"];
                        oSuperhero.Apodo = (miLector["Apodo"] is DBNull) ? "NULL" : (string)miLector["Apodo"];
                        oSuperhero.Sexo = (miLector["Sexo"] is DBNull) ? "NULL" : (string)miLector["Sexo"];
                        oSuperhero.IDCompanhia = (Int16)miLector["IDCompanhia"];
                        oSuperhero.Foto = (miLector["Foto"] is DBNull) ? new byte[1] : (Byte[])miLector["Foto"];
                        listado.Add(oSuperhero);
                    }
                }

                //miLector.Close();
                //connection.closeConnection(ref conn);  
            }
            catch (Exception exSql)
            {
                throw exSql;
            }

            finally
            {
                if (miLector != null)
                {
                    miLector.Close();
                }

                if (conn != null)
                {
                    connection.closeConnection(ref conn);
                }
            }

            return listado;

        }


        /// Se conecta a la BBDD y devuelve el listado de los superheroes
        /// </summary>
        /// <returns>Listado de Superhero List<clsSuperHero></returns>
        public List<clsSuperhero> listadoSuperheroesPorIDCompanhia(Int16 idCompanhia)
        {
            List<clsSuperhero> listado = new List<clsSuperhero>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsSuperhero oSuperhero;
            //Byte[] bytes = new Byte[20];
            try
            {

                miComando.CommandText = "SELECT * FROM dbo.Superheros WHERE idCompanhia = " + idCompanhia;
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oSuperhero = new clsSuperhero();
                        oSuperhero.ID = (Int16)miLector["ID"];
                        oSuperhero.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oSuperhero.Apellidos = (miLector["Apellidos"] is DBNull) ? "NULL" : (string)miLector["Apellidos"];
                        oSuperhero.Apodo = (miLector["Apodo"] is DBNull) ? "NULL" : (string)miLector["Apodo"];
                        oSuperhero.Sexo = (miLector["Sexo"] is DBNull) ? "NULL" : (string)miLector["Sexo"];
                        oSuperhero.IDCompanhia = (Int16)miLector["IDCompanhia"];
                        oSuperhero.Foto = (miLector["Foto"] is DBNull) ? new byte[1] : (Byte[])miLector["Foto"];
                        listado.Add(oSuperhero);
                    }
                }

                //miLector.Close();
                //connection.closeConnection(ref conn);  
            }
            catch (Exception exSql)
            {
                throw exSql;
            }

            finally
            {
                if (miLector != null)
                {
                    miLector.Close();
                }

                if (conn != null)
                {
                    connection.closeConnection(ref conn);
                }
            }

            return listado;

        }

    }
}
