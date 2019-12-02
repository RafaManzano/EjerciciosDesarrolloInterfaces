using _25_ExamenAvengers_DAL.Connection;
using _25_ExamenAvengers_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_DAL.Lists
{
    public class clsListadosMisionesDAL
    {
        /// <summary>
        /// Con este metodo cogemos de la BBDD aquellas misiones que esten libres
        /// </summary>
        /// <returns>La lista de Misiones libres para poder reservarse</returns>
        public List<clsMisiones> listadoMisionesDisponibles()
        {
            List<clsMisiones> listado = new List<clsMisiones>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsMisiones oMision;
            try
            {

                miComando.CommandText = "SELECT * FROM misiones WHERE reservada is NULL";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oMision = new clsMisiones();
                        oMision.IDMision = (int)miLector["IDMision"];
                        oMision.TituloMision = (miLector["tituloMision"] is DBNull) ? "NULL" : (string)miLector["tituloMision"];
                        oMision.DescripcionMision = (miLector["descripcionMision"] is DBNull) ? "NULL" : (string)miLector["descripcionMision"];
                        oMision.Reservada = (miLector["reservada"] is DBNull) ? 0 : (int)miLector["reservada"];
                        oMision.IDSuperheroe = (miLector["idSuperheroe"] is DBNull) ? 0 : (int)miLector["idSuperheroe"];
                        oMision.Observaciones = (miLector["observaciones"] is DBNull) ? "NULL" : (string)miLector["observaciones"];
                        listado.Add(oMision);
                    }
                }
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
