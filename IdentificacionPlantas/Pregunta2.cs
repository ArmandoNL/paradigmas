using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentificacionPlantas
{
    public partial class Pregunta2 : Form
    {
        Proceso proceso;
        public static String caracteristica;//almacenar la característica a almacenar
        public Pregunta2()
        {
            InitializeComponent();
            proceso = new Proceso(); //se inicializa la clase proceso donde se maneja la matriz de caracteristicas
        }

        /*
         *Efecto: invoca el método para procesar la información del filtro seleccionado y el método para decidir que acción tomar.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (radioAserrado.Checked)//verifica la opción seleccionada
            {
                caracteristica = "Aserrado";
            }
            else if (radioEntero.Checked)
            {
                caracteristica = "Entero";
            }

            proceso.decidir(caracteristica, 0);//invoca el método para decidir
            this.Hide();//cierra la interfaz
        }
    }
}
