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
        public String largo;

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
                largo = "Angosta";
            }
            else if (radioAncha.Checked)
            {
                largo = "Ancha";
            }

            proceso.decidir(largo, 3);//invoca el método para decidir
            this.Hide();//cierra la interfaz
        }
    }
}
