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
    public partial class Pregunta6 : Form
    {
        Proceso proceso;
        public String largo;

        public Pregunta6()
        {
            InitializeComponent();
            proceso = new Proceso();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (radioBrillante.Checked)
            {
                largo = "Corto";
            }
            else if (radioOpaco.Checked)
            {
                largo = "Opaco";
            }

            proceso.filtros(largo, 5);
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
                new Pregunta7().Show();
                this.Hide();
            }
        }
    }
}
