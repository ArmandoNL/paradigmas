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
        public String largo;
        
        public Pregunta3()
        {
            InitializeComponent();
            proceso = new Proceso();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (radioCorta.Checked)
            {
                largo = "Corta";
            }
            else if (radioLargo.Checked)
            {
                largo = "Larga";
            }

            proceso.filtros(largo,2);
            if (proceso.respuesta() == 0)
            {
                MessageBox.Show("La especie no se encuentra");
                new FormInicio().Show();
                this.Hide();

            }
            else if(proceso.respuesta()==1)
            {
                MessageBox.Show("Su planta es: " + proceso.Especie());
                new FormInicio().Show();
                this.Hide();
            }
            else
            {
                new Pregunta4().Show();
                this.Hide();
            }
        }
    }
}
