using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Ingrese_Placa.Text.Equals("") && !ampm.Text.Equals(""))
                {
                    string placa, hora, fecha;
                    placa = Ingrese_Placa.Text;
                    var regexItem = new Regex("^[a-zA-Z0-9]*$");
                    if (regexItem.IsMatch(placa))
                    {
                        var regexItem2 = new Regex("^[a-zA-Z]*$");
                        string letras = placa.Substring(0, 3);
                        if (regexItem2.IsMatch(placa.Substring(3, 1)))
                            mensaje.Text = ("PLACA INVALIDA");
                        else
                        {
                            if (letras.Length == 3)
                            {
                                var regexItem3 = new Regex("^[0-9]*$");
                                string numeros = placa.Substring(3, (placa.Length - 3));
                                if (numeros.Length == 4 && regexItem3.IsMatch(numeros))
                                {

                                    string dia = Pico_Placa(int.Parse(numeros.Substring(3, 1)));
                                    fecha = (calendario.Value.ToString("dddd", new CultureInfo("es-ES"))).ToString();
                                    if ((Numero_Horas.Value == 7 || Numero_Horas.Value == 8) && ampm.Text.Equals("A.M.") && (dia.Equals(fecha)))
                                    {
                                        mensaje.Text= ("NO PUEDE CIRCULAR");
                                    }
                                    else if ((Numero_Horas.Value == 9 && Numero_Minutos.Value < 30) && ampm.Text.Equals("A.M.") && (dia.Equals(fecha)))
                                    {
                                        mensaje.Text = ("NO PUEDE CIRCULAR");
                                    }
                                    else if ((Numero_Horas.Value == 4 || Numero_Horas.Value == 5 || Numero_Horas.Value == 6) && ampm.Text.Equals("P.M.") && (dia.Equals(fecha)))
                                    {
                                        mensaje.Text = ("NO PUEDE CIRCULAR");
                                    }
                                    else if ((Numero_Horas.Value == 7 && Numero_Minutos.Value < 30) && ampm.Text.Equals("P.M.") && (dia.Equals(fecha)))
                                    {
                                        mensaje.Text = ("NO PUEDE CIRCULAR");
                                    }
                                    else
                                    {
                                        mensaje.Text = ("SI PUEDE CIRCULAR");
                                    }

                                }
                                else
                                {
                                    mensaje.Text = ("PLACA INCORRECTA: EJEMPLO-- XXX1111");
                                }
                            }
                        }
                    }
                    else
                    {
                        mensaje.Text = ("PLACA INCORRECTA: EJEMPLO-- XXX1111");
                    }
                }
                else
                {
                    mensaje.Text = ("PLACA INVALIDA");
                }
            }
            catch (Exception ex)
            {
                throw ex;
          
            
            }
        
      
        }


        private string Pico_Placa(int Digito_Final)
        {
            try
            {
                int operador = 0;
                string temporal = "";

                if (Digito_Final % 2 == 0)
                    operador = Digito_Final;
                else
                {
                    operador = (Digito_Final + 1);
                    if (operador == 10)
                        operador = 0;
                }

                switch (operador)
                {
                    case 0:
                        temporal = "viernes";
                        break;
                    case 2:
                        temporal = "lunes";
                        break;
                    case 4:
                        temporal = "martes";
                        break;
                    case 6:
                        temporal = "miércoles";
                        break;
                    case 8:
                        temporal = "jueves";
                        break;
                }
                return temporal;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            mensaje.Text = "";
            Ingrese_Placa.Text = "";
        }
 

    }

}
