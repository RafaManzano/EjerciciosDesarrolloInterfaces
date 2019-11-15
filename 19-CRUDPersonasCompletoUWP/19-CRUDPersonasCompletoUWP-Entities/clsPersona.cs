using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsPersona
{
    //Fernando usa para la propiedad privada asi _nombre, pero yo usare minusculas y para los metodos
    //Mayusculas
    private string nombre;
    //private string primerApellido;
    //private string segundoApellido;
    //private DateTime fechaNacimiento;

    public clsPersona()
    {
        IDPersona = 0;
        nombre = "VACIO";
        Apellidos = "VACIO";
        FechaNacimiento = DateTime.Now;
        IDDepartamento = 0;
        Foto = new Byte[20];
        Telefono = "";
        Direccion = "";
    }

    public clsPersona(int id, string nombre, string apellidos, DateTime fecha, int idDepartamento, Byte[] foto, string telefono, string direccion)
    {
        IDPersona = id;
        this.nombre = nombre;
        Apellidos = apellidos;
        FechaNacimiento = fecha;
        IDDepartamento = idDepartamento;
        Foto = foto;
        Telefono = telefono;
        Direccion = direccion;
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string Apellidos { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int IDDepartamento { get; set; }
    public Byte[] Foto { get; set; }
    public string Telefono { get; set; }
    public int IDPersona { get; set; }
    public string Direccion { get; set; }
}

