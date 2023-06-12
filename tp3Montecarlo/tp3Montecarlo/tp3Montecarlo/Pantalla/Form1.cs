using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp3Montecarlo.Soporte;
using TP3Montecarlo.Soporte;

namespace tp3Montecarlo
{
    public partial class Form1 : Form
    {
        private List<TablaDeFrecuencias> tablaFrecuencias;
        private List<TablaAusentismo> ausentismo;
        private List<TablaSimulacion> simulacion;
        private Generador generador;
        public Form1()
        {
            InitializeComponent();
            generador = new Generador();
            primerasTablas();
            cargarComboBox();
        }
        private void primerasTablas()
        {
           dgvAusentismo.Refresh();
            ausentismo = generador.tabla1();
            dgvAusentismo.DataSource = ausentismo;
            txtTotal.Text = ausentismo.Sum(x => x.Frecuencia).ToString();
            dgvFrecuencias.Refresh();    
            tablaFrecuencias=generador.tablaFrecuencias(ausentismo,ausentismo.Sum(x=>x.Frecuencia)); 
            dgvFrecuencias.DataSource= tablaFrecuencias;
          }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvAusentismo.Refresh();
            ausentismo = generador.cambiarFrecuencia(ausentismo);
            dgvAusentismo.DataSource= ausentismo;   
             txtTotal.Text = ausentismo.Sum(x => x.Frecuencia).ToString();
            tablaFrecuencias = generador.tablaFrecuencias(ausentismo, ausentismo.Sum(x => x.Frecuencia));
            dgvFrecuencias.DataSource = tablaFrecuencias;


        }
        private void cargarComboBox()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(21);
            myArrayList.Add(22);
            myArrayList.Add(23);
            myArrayList.Add(24);
             cbxNomina.DataSource = myArrayList;
        }
        private void simular()
        {
            simulacion = generador.generarSimulacion(int.Parse(cbxNomina.Text), (int)numericUpDownDiasASimular.Value,
                (double)numericUpDownVentas.Value, (double)numericUpDownProduccion.Value
                , (double)numericUpDownRemuneracion.Value, tablaFrecuencias);
            dgvSimulacion.DataSource = simulacion;   
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            simular();  
        }
    }
}
