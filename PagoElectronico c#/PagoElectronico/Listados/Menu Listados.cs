using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class Menu_Listados : Form
    {
        int trimestre;
        string anio;

        public Menu_Listados()
        {
            InitializeComponent();
        }

        private void boton_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar_Parametros_Elegidos()
        {
            if ((combo_anio.Text == "") || (combo_trimestre.Text == ""))
            {
                DialogResult alerta = MessageBox.Show("Debe elegir un año y cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {   
                asignar_Numero_De_Trimestre_Y_Anio();
                return true; 
            }
        }

        private void asignar_Numero_De_Trimestre_Y_Anio()
        {
            if(combo_trimestre.Text == "Ene - Mar")
            { trimestre = 1; }
            if(combo_trimestre.Text == "Abr - Jun")
            { trimestre = 2; }
            if(combo_trimestre.Text == "Jul - Sep")
            { trimestre = 3; }
            if (combo_trimestre.Text == "Oct - Dic")
            { trimestre = 4; }
            anio = combo_anio.Text;
        }

        private void boton_Inhabilitadas_Click(object sender, EventArgs e)
        {
            if (validar_Parametros_Elegidos())
            {
                Estadistico_Cliente_Inhab listado = new Estadistico_Cliente_Inhab(anio, trimestre);
                listado.ShowDialog();
            }
        }

        private void boton_Paises_Mayor_Mov_Click(object sender, EventArgs e)
        {
            if (validar_Parametros_Elegidos())
            {
                Estadistico_Pais listado = new Estadistico_Pais(anio, trimestre);
                listado.ShowDialog();
            }
        }

        private void boton_mayor_Comisiones_Click(object sender, EventArgs e)
        {
            if (validar_Parametros_Elegidos())
            {
                Estadistico_Cliente_Facturación listado = new Estadistico_Cliente_Facturación(anio, trimestre);
                listado.ShowDialog();
            }
        }

        private void boton_Mayor_transacciones_Click(object sender, EventArgs e)
        {
            if (validar_Parametros_Elegidos())
            {
                Estadistico_Cliente_Mayor_Trans listado = new Estadistico_Cliente_Mayor_Trans(anio, trimestre);
                listado.ShowDialog();
            }
        }

        private void boton_totales_fact_Click(object sender, EventArgs e)
        {
            if (validar_Parametros_Elegidos())
            {
                Total_Facturado_por_Cuenta listado = new Total_Facturado_por_Cuenta(anio, trimestre);
                listado.ShowDialog();
            }
        }
    }
}
