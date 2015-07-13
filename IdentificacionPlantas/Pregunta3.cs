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
    public partial class Pregunta3 : Form
    {
        Proceso proceso;
        public String caracteristica;//almacenar la característica a almacenar

        public Pregunta3()
        {
            InitializeComponent();
            proceso = new Proceso();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
         *Efecto: invoca el método para procesar la información del filtro seleccionado y el método para decidir que acción tomar.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (radioCorta.Checked)//verifica la opción seleccionada
            {
                caracteristica = "Corta";
            }
            else if (radioLargo.Checked)
            {
                caracteristica = "Larga";
            }

            proceso.decidir(caracteristica, 2);//invoca el método para decidir
            this.Hide();//cierra la interfaz
        }
    }
}
