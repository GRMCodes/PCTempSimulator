using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTempSimulator
{
    public static class Controlador
    {
        public static Resultado Evaluar(decimal temperatura)
        {
            Resultado r = new Resultado { Temperatura = temperatura };

            if (temperatura < 40)
            {
                r.Estado = "Normal";
                r.Velocidad = 0;
                r.Mensaje = "Sistema Normal";
            }
            else if (temperatura < 60)
            {
                r.Estado = "Moderada";
                r.Velocidad = 40;
                r.Mensaje = "Temperatura Moderada";
            }
            else if (temperatura < 75)
            {
                r.Estado = "Alta";
                r.Velocidad = 70;
                r.Mensaje = "Temperatura Alta";
            }
            else if (temperatura < 90)
            {
                r.Estado = "Muy Alta";
                r.Velocidad = 100;
                r.Mensaje = "Temperatura Muy Alta";
            }
            else
            {
                r.Estado = "Critica";
                r.Velocidad = 100;
                r.Alerta = true;
                r.Mensaje = "ALERTA: Temperatura Critica";
            }
            return r;
        }

        public class Resultado
        {
            public decimal Temperatura { get; set; }
            public int Velocidad { get; set; }
            public string Estado { get; set; } = "";
            public bool Alerta { get; set; }
            public string Mensaje { get; set; } = "";
        }
    }
}
