using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using tp3Montecarlo.Soporte;

namespace TP3Montecarlo.Soporte
{
    class Generador
    {
        private static Random random = new Random();
        public List<TablaAusentismo> tabla1()
        {
            List<TablaAusentismo> ausentismo= new List<TablaAusentismo>();
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(36.0);
            myArrayList.Add(38.0);
            myArrayList.Add(19.0);
            myArrayList.Add(6.0);
            myArrayList.Add(1.0);
            myArrayList.Add(0.0);
            double sum = myArrayList.Cast<double>().Sum();
            int c = 0;
            foreach (double item in myArrayList)
            {
                int Numero_De_Obreros_Ausentes = c;
                c++ ;
                
                double Frecuencia = item;
                ausentismo.Add(new TablaAusentismo(Numero_De_Obreros_Ausentes, (int)Frecuencia));
            }
            return ausentismo;
        }
           
        public List<TablaDeFrecuencias> tablaFrecuencias(List<TablaAusentismo> tabla,double n)
        {
            List<TablaDeFrecuencias> tablaFrecuencia = new List<TablaDeFrecuencias>();
            int c = 0;
            foreach (var item in tabla)
            {

                int Numero_De_Obreros_Ausentes = c; 
                c++;
                double Frecuencia = item.Frecuencia;
                double Probalilidad = Math.Round(item.Frecuencia / n, 4);
                double Probabilidad_Acumulada = 0;
                Probabilidad_Acumulada = Probalilidad;
                Probabilidad_Acumulada = (c > 1 ? Math.Round(tablaFrecuencia.Last().Probabilidad_Acumulada + Probalilidad, 4) : Probabilidad_Acumulada);
                tablaFrecuencia.Add(new TablaDeFrecuencias(Numero_De_Obreros_Ausentes, (int)Frecuencia, Probalilidad, Probabilidad_Acumulada));

            }

            return tablaFrecuencia;
        }

        public List<TablaAusentismo> cambiarFrecuencia(List<TablaAusentismo> tablaAusentismos )
        {

            List <TablaAusentismo> ausentismo = new List<TablaAusentismo> ();
            int sum = 0;
            for (int i = 0; i < tablaAusentismos.Count(); i++)
            
            {
             string inputString = Interaction.InputBox("Ingrese la nueva frecuencia para: " + i + " ausentes (La frecuencia Total debe ser 100)", "Frecuenia");
           
                if (!string.IsNullOrEmpty(inputString))
                {
                    if (sum + int.Parse(inputString) <=100)
                    {
                        sum += int.Parse(inputString);
                        ausentismo.Add(new TablaAusentismo(i, int.Parse(inputString)));
                    }
                    else 
                    {
                        MessageBox.Show("La suma de los números ingresados excede 100. Ingrese nuevamente.");
                        i--;
                    }

                }
                else
                {
                    return tablaAusentismos;
                }
            }
           if(sum<100)
            {
                MessageBox.Show("La suma de los números ingresados es menor 100.Haga el proceso nuevamente.");
                return tablaAusentismos;
            }
           
            return ausentismo;
        }

        public List<TablaSimulacion> generarSimulacion(int nomina,int dias,double ventas,double produccion,double remuneracion,List<TablaDeFrecuencias>tablaDeFrecuencias)
        {
            List<TablaSimulacion> tablaSimulacion = new List<TablaSimulacion> ();
            for (int i = 0;i<dias;i++)
            {
                int Reloj = i;
                double RND_Ausentismo= Math.Round(random.NextDouble(), 4);
                int Ausentismo = getCantidadAusentes(tablaDeFrecuencias,RND_Ausentismo);
                int Nomina = nomina - Ausentismo;
                string PlantaOperativa = "";
                PlantaOperativa = (Nomina < 20 ? "NO" : "SI");
                double Ventas = (PlantaOperativa.Equals("NO") ? 0 : ventas);
                double Produccion = (PlantaOperativa.Equals("NO") ? 0:produccion);
                double Remuneracion = remuneracion*nomina;
                double TotalCostos = Produccion + Remuneracion;
                double Beneficio = Ventas - TotalCostos;
                tablaSimulacion.Add(new TablaSimulacion(Reloj, RND_Ausentismo, Ausentismo, Nomina, PlantaOperativa, Ventas, Produccion, Remuneracion, TotalCostos, Beneficio));
            }
            return tablaSimulacion;
        }

        public int getCantidadAusentes(List<TablaDeFrecuencias> tablaDeFrecuencias, double RND_Ausentismo)
        {
            int ausentes=0;
            foreach (var item in tablaDeFrecuencias)
            {
                if(RND_Ausentismo < item.Probabilidad_Acumulada)
                {
                    ausentes = item.Numero_De_Obreros_Ausentes;
                    break;
                }
            }
            return ausentes;
        }
    }
    
}
