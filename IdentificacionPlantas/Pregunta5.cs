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
    public partial class Pregunta5 : Form
    {

        Proceso proceso;
        public String largo;

        public Pregunta5()
        {
            InitializeComponent();
            proceso = new Proceso();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (radioCorto.Checked)
            {
                largo = "Corto";
            }
            else if (radioLargo.Checked)
            {
                largo = "Largo";
            }

            proceso.filtros(largo, 4);
            if (proceso.respuesta() == 0)
            {
                MessageBox.Show("La especie no se encuentra");
                new FormInicio().Show();
                this.Hide();
            }
            else if (proceso.respuesta() == 1)
            {
                MessageBox.Show("Su planta es: " + proceso.Especie());
                new FormInicio().Show();
                this.Hide();
            }
            else
            {
                new Pregunta6().Show();
                this.Hide();
            }
        }

    }
}
