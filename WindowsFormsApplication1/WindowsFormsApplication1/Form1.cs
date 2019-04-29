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
            calcularpico_placa.Visible = false;
            {
                try
                {
            
                    if (!Ingrese_Placa.Text.Equals("") && !ampm.Text.Equals(""))
                    {
                        string placa_auto, horas, fechas;
                        placa_auto = Ingrese_Placa.Text;
                        var regexItem = new Regex("^[a-zA-Z0-9]*$");
                        if (regexItem.IsMatch(placa_auto))
                        {
                            var separar_letras = new Regex("^[a-zA-Z]*$");
                            string letras = placa_auto.Substring(0, 3);
                            if (separar_letras.IsMatch(placa_auto.Substring(3, 1)))
                                mensaje.Text = "PLACA INCORRECTA";
                            else
                            {
                                if (letras.Length == 3)
                                {
                                    var separar_numeros = new Regex("^[0-9]*$");
                                    string numeros = placa_auto.Substring(3, (placa_auto.Length - 3));
                                    if (numeros.Length == 4 && separar_numeros.IsMatch(numeros))
                                    {
                                        Class1 dia = new Class1();
                                        fechas = (calendario.Value.ToString("dddd", new CultureInfo("es-ES"))).ToString();
                                        if ((Numero_Horas.Value == 7 || Numero_Horas.Value == 8) && ampm.Text.Equals("A.M.") && (dia.Equals(fechas)))
                                        {
                                            
                                            mensaje.Text = "NO PUEDE CIRCULAR";
                                        }
                                        else if ((Numero_Horas.Value == 9 && Numero_Minutos.Value < 30) && ampm.Text.Equals("A.M.") && (dia.Equals(fechas)))
                                        {
                                            mensaje.Text = "NO PUEDE CIRCULAR";
                                        }
                                        else if ((Numero_Horas.Value == 4 || Numero_Horas.Value == 5 || Numero_Horas.Value == 6) && ampm.Text.Equals("P.M.") && (dia.Equals(fechas)))
                                        {
                                            mensaje.Text = "NO PUEDE CIRCULAR";
                                        }
                                        else if ((Numero_Horas.Value == 7 && Numero_Minutos.Value < 30) && ampm.Text.Equals("P.M.") && (dia.Equals(fechas)))
                                        {
                                            mensaje.Text = "NO PUEDE CIRCULAR";
                                        }
                                        else
                                        {
                                            mensaje.Text = "SI PUEDE CIRCULAR";
                                        }

                                    }
                                    else
                                    {
                                        mensaje.Text = "INGRESE COMO EL EJEMPLO: XXX0000";
                                    }
                                }
                            }
                        }
                        else
                        {
                            mensaje.Text = "INGRESE COMO EL EJEMPLO: XXX0000";
                        }
                    }
                    else
                    {
                        mensaje.Text = "DATOS INVALIDOS";
                    }
                }
                catch (Exception retorno)
                {
                    throw retorno;
                }
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Ingrese_Placa.Text = "";
            Numero_Horas.Value = 0;
            Numero_Minutos.Value = 0;
            mensaje.Text = "";
            calcularpico_placa.Visible = true;

        }
   
  
        
            
        

        
     

        


    }

}
