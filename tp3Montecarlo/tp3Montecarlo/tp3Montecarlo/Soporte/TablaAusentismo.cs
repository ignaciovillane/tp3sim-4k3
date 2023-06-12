using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3Montecarlo.Soporte
{
     class TablaAusentismo
    {
        public int Numero_De_Obreros_Ausentes { get; set; }
        public int Frecuencia { get; set; }

        public TablaAusentismo(int Numero_De_Obreros_Ausentes, int Frecuencia)
        {
            this.Numero_De_Obreros_Ausentes = Numero_De_Obreros_Ausentes;
            this.Frecuencia = Frecuencia;
        }
    }
}
