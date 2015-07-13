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
        public static String borde;
        public Pregunta2()
        {
            InitializeComponent();
            proceso = new Proceso(); //se inicializa la clase proceso donde se maneja la matriz de caracteristicas
        }

        /*
         *Efecto: invoca el método para procesar la información del filtro seleccionado y decide que acción tomar.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(radioAserrado.Checked){//verifica la opción seleccionada
                borde = "Aserrado";
            }else if(radioEntero.Checked){
                borde = "Entero";
            }

            proceso.filtros(borde, 0);//invoca el método para procesar la información
            if (proceso.respuesta() == 0)//decide cuál acción tomar
            {//si no se encuentra la respuesta
                MessageBox.Show("La especie no se encuentra");
                new FormInicio().Show();
                this.Hide();
            }
            else if (proceso.respuesta() == 1)//se encontró la respuesta
            {
                MessageBox.Show("Su planta es: " + proceso.Especie());
                new FormInicio().Show();
                this.Hide();
            }
            else//o hay que hacer otra pregunta.
            {
                proceso.proximaPregunta();
                this.Hide();
            }
        }
    }
}
