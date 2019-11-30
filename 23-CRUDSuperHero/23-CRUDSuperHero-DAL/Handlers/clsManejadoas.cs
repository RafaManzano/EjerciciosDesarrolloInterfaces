using _23_CRUDSuperHero_DAL.Connection;
using _23_CRUDSuperHero_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_DAL.Handlers
{
    public class clsManejadoas
    {
        /// <summary>
        /// Metodo que borra un superheroe por su ID de la BBDD
        /// </summary>
        /// <param name="id">El ID del superheroe a eliminar</param>
        public void borrarPersona(Int16 id)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.SmallInt).Value = id;

            try
            {
                miComando.CommandText = "DELETE FROM dbo.Superheros WHERE ID = @id";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Con este metodo comprobamos si el superheroe introducido esta en la BBDD
        /// </summary>
        /// <param name="superhero">El superheroe introducido</param>
        /// <returns>Si es true, el superhero es una actualizacion, si es false el superhero es una creacion</returns>
        public bool estoyEnBBDD(clsSuperhero superhero)
        {
            bool estoy = false;
            clsSuperhero oPersona = new clsSuperhero();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            try
            {
                miComando.CommandText = "SELECT * FROM dbo.Superheros WHERE ID = " + superhero.ID;
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    estoy = true;

                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch
            {
                throw;
            }
            return estoy;
        }

        /// <summary>
        /// Creamos el superhero y la introducimos en la BBDD
        /// </summary>
        /// <param name="superhero">Este es el objeto que tiene que introducir en la BBDD</param>
        public void crearSuperhero(clsSuperhero superhero)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = superhero.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = superhero.Apellidos;
            miComando.Parameters.Add("@apodo", System.Data.SqlDbType.VarChar).Value = superhero.Apodo;
            miComando.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar).Value = superhero.Sexo;
            miComando.Parameters.Add("@idCompanhia", System.Data.SqlDbType.SmallInt).Value = superhero.IDCompanhia;
            miComando.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = superhero.Foto;

            try
            {
                miComando.CommandText = "INSERT INTO dbo.Superheros VALUES (@nombre, @apellidos, @apodo, @sexo, @idCompanhia, @foto)";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Actualizamos el superhero de la BBDD
        /// </summary>
        /// <param name="superhero">Este es el objeto que tiene que actualizar en la BBDD</param>
        public void actualizarSuperhero(clsSuperhero superhero)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.SmallInt).Value = superhero.ID;
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = superhero.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = superhero.Apellidos;
            miComando.Parameters.Add("@apodo", System.Data.SqlDbType.VarChar).Value = superhero.Apodo;
            miComando.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar).Value = superhero.Sexo;
            miComando.Parameters.Add("@idCompanhia", System.Data.SqlDbType.SmallInt).Value = superhero.IDCompanhia;
            miComando.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = superhero.Foto;

            try
            {
                miComando.CommandText = "UPDATE dbo.Superheros SET Nombre = @nombre, Apellidos = @apellidos, Apodo = @apodo, Sexo =  @sexo, IDCompanhia = @idCompanhia, Foto = @foto WHERE ID = @id";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
