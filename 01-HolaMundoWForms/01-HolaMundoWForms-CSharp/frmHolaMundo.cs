using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace _01_HolaMundoWForms_CSharp
{
    public partial class frmHolaMundo : Form
    {
        public frmHolaMundo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al click del boton saludar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaludo_Click(object sender, EventArgs e)
        {
            clsPersona objPersona = new clsPersona();
            //Dependiendo de donde este el tbNombre.Text usara get o set
            objPersona.Nombre = tbNombre.Text;
            objPersona.PrimerApellido = tbPrimerApellido.Text;
            objPersona.SegundoApellido = tbSegundoApellido.Text;
            objPersona.FechaNacimiento = datFechaNacimiento.Value;

            //Mostrar mensaje
            //MessageBox.Show("Hola " + nombre);

            //Otra variante
            //MessageBox.Show($"Hola { nombre }");

            /*
            if(string.IsNullOrEmpty(objPersona.Nombre))
            {
                lbErrorN.Text = "Escriba algun caracter, por favor";
                lbErrorN.ForeColor = Color.Red;
                if (String.IsNullOrEmpty(objPersona.PrimerApellido))
                {
                    lbErrorPA.Text = "Escriba algun caracter, por favor";
                    lbErrorPA.ForeColor = Color.Red;
                    if (String.IsNullOrEmpty(objPersona.SegundoApellido))
                    {
                        lbErrorSA.Text = "Escriba algun caracter, por favor";
                        lbErrorSA.ForeColor = Color.Red;
                    }
                    
                }
            */
            //MessageBox.Show("Por favor, introduzca algun nombre");
            //lbErrorN.Visible = true;
            //}
            /*
            else
            {
                MessageBox.Show($"Lo que has introducido es, Nombre: { objPersona.Nombre } , Primer Apellido " +
                    $"{objPersona.PrimerApellido}, Segundo Apellido  {objPersona.SegundoApellido} y su fecha de nacimiento " +
                    $"es {objPersona.FechaNacimiento.ToShortDateString()}");
            }
            */

            if (!string.IsNullOrEmpty(objPersona.Nombre))
            {
                if (!String.IsNullOrEmpty(objPersona.PrimerApellido))
                {
                    if (!String.IsNullOrEmpty(objPersona.SegundoApellido))
                    {
                        MessageBox.Show($"Lo que has introducido es, Nombre: { objPersona.Nombre } , Primer Apellido " +
                        $"{objPersona.PrimerApellido}, Segundo Apellido {objPersona.SegundoApellido} y su fecha de nacimiento " +
                        $"es {objPersona.FechaNacimiento.ToShortDateString()}");
                    }
                    else
                    {
                        lbErrorSA.Text = "Escriba algun caracter, por favor";
                        lbErrorSA.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbErrorPA.Text = "Escriba algun caracter, por favor";
                    lbErrorPA.ForeColor = Color.Red;
                }
            }
            else
            {
                lbErrorN.Text = "Escriba algun caracter, por favor";
                lbErrorN.ForeColor = Color.Red;
            }
        }

    }
}
