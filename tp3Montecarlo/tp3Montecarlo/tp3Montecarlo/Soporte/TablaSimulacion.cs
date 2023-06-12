using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Montecarlo.Soporte
{
    class TablaSimulacion
    {
        public int Reloj { get; set; }
        public double RND_Ausentismo { get; set; }

        public int Ausentismo { get; set; }

        public int Nomina { get; set; }

        public string Planta_Operativa { get; set; }

        public double Ventas { get; set; }

        public double Produccion { get; set; }

        public double Remuneracion { get; set; }

        public double Total_Costos { get; set; }
        public double Beneficio { get; set; }


        public TablaSimulacion(int Reloj, double RND_Ausentismo,int Ausentismo, int Nomina,
            string Planta_Operativa, double Ventas, double Produccion, double Remuneracion,
            double Total_Costos, double Beneficio)
        {
            this.Reloj = Reloj;
            this.RND_Ausentismo = RND_Ausentismo;
            this.Ausentismo= Ausentismo;    
            this.Nomina = Nomina;
            this.Planta_Operativa = Planta_Operativa;
            this.Ventas = Ventas;
            this.Produccion = Produccion;
            this.Remuneracion = Remuneracion;
            this.Total_Costos = Total_Costos;
            this.Beneficio = Beneficio;
        }


    }
}
