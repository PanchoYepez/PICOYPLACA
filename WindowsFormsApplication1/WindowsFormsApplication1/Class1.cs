using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1
    {
        private string Pico_Placa(int Digito_Final)
        {
            try
            {
                int probador = 0;
                string temporal = "";

                if (Digito_Final % 2 == 0)
                    probador = Digito_Final;
                else
                {
                    probador = (Digito_Final + 1);
                    if (probador == 10)
                        probador = 0;
                }

                switch (probador)
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
            catch (Exception numero)
            {
                return numero.ToString();
            }

        }
    }
}
