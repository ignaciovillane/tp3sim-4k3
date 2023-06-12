using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Montecarlo.Soporte
{
    class TablaDeFrecuencias
    {
        public int Numero_De_Obreros_Ausentes { get; set; }
        public int Frecuencia { get; set; }

        public double Probabilidad { get; set; }

        public double Probabilidad_Acumulada { get; set; }

        public TablaDeFrecuencias(int Numero_De_Obreros_Ausentes, int Frecuencia, double Probabilidad, double Probabilidad_Acumulada)
        {
            this.Numero_De_Obreros_Ausentes = Numero_De_Obreros_Ausentes;
            this.Frecuencia = Frecuencia;
            this.Probabilidad = Probabilidad;
            this.Probabilidad_Acumulada = Probabilidad_Acumulada;

        }

    }

}
