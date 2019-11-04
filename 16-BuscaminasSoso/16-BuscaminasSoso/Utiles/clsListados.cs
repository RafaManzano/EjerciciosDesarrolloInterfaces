using _16_BuscaminasSoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace _16_BuscaminasSoso.Utiles
{
    class clsListados
    {
        public static int intercambiarLetraPorNumero(object sender)
        {
            int numero = 0;
            Button b = (Button) sender;

            switch(b.Name)
            {
                case "uno":
                    numero = 0;
                    break;

                case "dos":
                    numero = 1;
                    break;

                case "tres":
                    numero = 2;
                    break;

                case "cuatro":
                    numero = 3;
                    break;

                case "cinco":
                    numero = 4;
                    break;

                case "seis":
                    numero = 5;
                    break;

                case "siete":
                    numero = 6;
                    break;

                case "ocho":
                    numero = 7;
                    break;

                case "nueve":
                    numero = 8;
                    break;

                case "diez":
                    numero = 9;
                    break;

                case "once":
                    numero = 10;
                    break;

                case "doce":
                    numero = 11;
                    break;

                case "trece":
                    numero = 12;
                    break;

                case "catorce":
                    numero = 13;
                    break;

                case "quince":
                    numero = 14;
                    break;

                case "dieciseis":
                    numero = 15;
                    break;
            }
            return numero;
        }

        public static List<clsCasilla> listadoCasillas()
        {
            Random rnd = new Random();
            int numero = 0;
            List<clsCasilla> list = new List<clsCasilla>();
            for(int i = 0; i < 16; i++)
            {
                list.Add(new clsCasilla());
            }
            for(int i = 0; i < 5; i++)
            {
                numero = rnd.Next(16);
                list.FindIndex(numero, a => a.IsBomba = true);
            }
            return list;
        }
    }
}
