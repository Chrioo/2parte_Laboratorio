using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaParte.Negocio
{
    class ClsPersona

        {Persona per = new Persona(0, 0);
        public String calcularIMC()
        {

            double pro = per.Peso / Math.Pow(per.Altura, 2);

            if (pro < 20)
            {
                return "Su peso es ideal";
            }
            if (pro > 25)
            {
                return "Tiene sobre peso";
            }
            return "";
        }
        public String esMayorDeEdad()
        {
            if (per.Edad >= 18)
            {
                return "Es Mayor de edad";
            }
            else
                return "No es mayor de edad";

        }
}
}
