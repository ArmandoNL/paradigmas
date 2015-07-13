using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IdentificacionPlantas
{
    public partial class FormInicio : Form
    {
        Proceso proceso;
        
        public FormInicio()
        {
            InitializeComponent();
            proceso = new Proceso(); //se inicializa la clase proceso donde se maneja la matriz de caracteristicas
        }


        private void btnEliptica_Click(object sender, EventArgs e)
        {
            procesarInfo("Elíptica");
        }


        private void label2_Click(object sender, EventArgs e) //no borrar
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }


        private void btnRomboidal_Click(object sender, EventArgs e)
        {
            procesarInfo("Romboidal");
        }

        private void btnObovada_Click(object sender, EventArgs e)
        {
            procesarInfo("Obovada");
        }

        private void btnOblonga_Click(object sender, EventArgs e)
        {
            procesarInfo("Oblonga");
        }

        private void btnLanceolada_Click(object sender, EventArgs e)
        {
            procesarInfo("Lanceolada");
        }

        private void btnOvada_Click(object sender, EventArgs e)
        {
            procesarInfo("Ovada");
        }

        protected void procesarInfo(String forma)
        {
            proceso.formaHoja(forma);
            if (proceso.respuesta() == 1)
            {
                MessageBox.Show("Su planta es: " + proceso.Especie());
                new FormInicio().Show();
                this.Hide();
            }
            else
            {
                proceso.proximaPregunta();
                this.Hide();
            }
        }
    }
}
