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
    public partial class Pregunta4 : Form
    {
        Proceso proceso;
        public String caracteristica;

        public Pregunta4()
        {
            InitializeComponent();
            proceso = new Proceso();//inicializa la instabcia de proceso
        }

        /*
         *Efecto: invoca el método para procesar la información del filtro seleccionado y el método para decidir que acción tomar.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (radioAngosta.Checked)
            {
                caracteristica = "Angosta";
            }
            else if (radioAncha.Checked)
            {
                caracteristica = "Ancha";
            }

            proceso.decidir(caracteristica, 3);//invoca el método para decidir
            this.Hide();//cierra la interfaz
        }
    }
}
