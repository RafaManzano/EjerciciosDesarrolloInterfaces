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
    public class clsListadoCompanhiaDAL
    {
        /// Se conecta a la BBDD y devuelve el listado de los companhias
        /// </summary>
        /// <returns>Listado de Companhia List<clsCompanhia></returns>
        public List<clsCompanhia> listadoCompanhia()
        {
            List<clsCompanhia> listado = new List<clsCompanhia>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsCompanhia oCompanhia;
            //Byte[] bytes = new Byte[20];
            try
            {
                //TODO Cambiar a mi tabla 
                miComando.CommandText = "SELECT * FROM dbo.Companhias";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oCompanhia = new clsCompanhia();
                        oCompanhia.ID = (Int16)miLector["ID"];
                        oCompanhia.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        listado.Add(oCompanhia);
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
