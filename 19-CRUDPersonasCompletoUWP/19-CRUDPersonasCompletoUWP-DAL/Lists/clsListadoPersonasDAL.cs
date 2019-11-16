using _19_CRUDPersonasCompletoUWP_DAL.Connection;
using _19_CRUDPersonasCompletoUWP_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_CRUDPersonasCompletoUWP_DAL.Handlers
{
    public class clsListadoPersonasDAL
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de las personas
        /// </summary>
        /// <returns>Listado de personas List<clsPersona></returns>
        public List<clsPersona> listadoPersona()
        {
            List<clsPersona> listado = new List<clsPersona>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPersona oPersona;
            //Byte[] bytes = new Byte[20];
            try
            {
                miComando.CommandText = "SELECT * FROM dbo.PD_Personas";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.IDPersona = (int)miLector["IdPersona"];
                        oPersona.Nombre = ((string)miLector["NombrePersona"] != null) ? (string)miLector["NombrePersona"] : null;
                        oPersona.Apellidos = ((string)miLector["ApellidosPersona"] != null) ? (string)miLector["ApellidosPersona"] : null;
                        oPersona.FechaNacimiento = DateTime.Parse(miLector["FechaNacimientoPersona"].ToString());
                        oPersona.Direccion = ((string)miLector["direccion"] != null) ? (string)miLector["direccion"] : null;
                        oPersona.Telefono = ((string)miLector["TelefonoPersona"] != null) ? (string)miLector["TelefonoPersona"] : null;
                        oPersona.Foto = ((byte[])miLector["FotoPersona"] != null) ? (byte[])miLector["FotoPersona"] : null;
                        oPersona.IDDepartamento = (int)miLector["IDDepartamento"];
                        listado.Add(oPersona);
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listado;

        }

        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de los departamentos
        /// </summary>
        /// <returns>Listado de departamentos List<clsDepartamento></returns>
        public List<clsDepartamento> listadoDpto()
        {
            List<clsDepartamento> listado = new List<clsDepartamento>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsDepartamento oDpto;
            try
            {
                miComando.CommandText = "SELECT * FROM dbo.PD_Departamentos";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oDpto = new clsDepartamento();
                        oDpto.ID = (int)miLector["IDDepartamento"];
                        oDpto.Nombre = (string)miLector["NombreDepartamento"];
                        listado.Add(oDpto);
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listado;
        }

        /// <summary>
        /// Se conecta a la BBDD y devuelve la persona que tiene esa ID
        /// </summary>
        /// <param name="id">El id que tenemos que buscar</param>
        /// <returns>Devolvemos la persona que tiene esa ID</returns>
        public clsPersona personaporID(int id)
        {
            Byte[] bytes = new Byte[20];
            clsPersona oPersona = new clsPersona();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            try
            {
                miComando.CommandText = "SELECT * FROM dbo.PD_Personas WHERE idPersona = " + id;
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona.IDPersona = (int)miLector["IdPersona"];
                        oPersona.Nombre = (oPersona.Nombre != null) ? (string)miLector["NombrePersona"] : null;
                        oPersona.Apellidos = (oPersona.Apellidos != null) ? (string)miLector["ApellidosPersona"] : null;
                        oPersona.FechaNacimiento = DateTime.Parse(miLector["FechaNacimientoPersona"].ToString());
                        oPersona.Direccion = (oPersona.Direccion != null) ? (string)miLector["direccion"] : null;
                        oPersona.Telefono = (oPersona.Telefono != null) ? (string)miLector["TelefonoPersona"] : null;
                        oPersona.Foto = (oPersona.Foto != null) ? (byte[])miLector["FotoPersona"] : null;
                        oPersona.IDDepartamento = (int)miLector["IDDepartamento"];
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return oPersona;
        }

        /// <summary>
        /// Se conecta a la BBDD y devuelve el departamento por ID
        /// </summary>
        /// <param name="id">El id que tenemos que buscar</param>
        /// <returns>Devolvemos el departamento que tiene esa ID</returns>
        public clsDepartamento departamentoPorID(int id)
        {
            clsDepartamento oDpto = new clsDepartamento();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            try
            {
                miComando.CommandText = "SELECT * FROM dbo.PD_Departamentos WHERE IDDepartamento  = " + id;
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oDpto = new clsDepartamento();
                        oDpto.ID = (int)miLector["IDDepartamento"];
                        oDpto.Nombre = (string)miLector["NombreDepartamento"];
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return oDpto;
        }
    }
}
