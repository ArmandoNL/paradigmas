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
    public partial class Pregunta7 : Form
    {
        Proceso proceso;
        public string caracteristica;

        public Pregunta7()
        {
            InitializeComponent();
            proceso = new Proceso();
        }

        /*
         *Efecto: invoca el método para procesar la información del filtro seleccionado y el método para decidir que acción tomar.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (radioPubescente.Checked)
            {
                caracteristica = "Pubescente";
            }
            else if (radioGlabro.Checked)
            {
                caracteristica = "Glabro";
            }

            proceso.decidir(caracteristica, 6);//invoca el método para decidir
            this.Hide();//cierra la interfaz
        }
    }
}
