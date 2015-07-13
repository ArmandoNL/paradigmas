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

        /*
         *Efecto: maneja el evento del botón, al seleccionar la forma de la hoja. Invoca el método para procesar la infoemación con la forma seleccionada.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnEliptica_Click(object sender, EventArgs e)//maneja el evento 
        {
            procesarInfo("Elíptica");
        }


        private void label2_Click(object sender, EventArgs e) //no borrar
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        /*
         *Efecto: maneja el evento del botón, al seleccionar la forma de la hoja. Invoca el método para procesar la infoemación con la forma seleccionada.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnRomboidal_Click(object sender, EventArgs e)
        {
            procesarInfo("Romboidal");
        }

        /*
         *Efecto: maneja el evento del botón, al seleccionar la forma de la hoja. Invoca el método para procesar la infoemación con la forma seleccionada.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnObovada_Click(object sender, EventArgs e)
        {
            procesarInfo("Obovada");
        }

        /*
         *Efecto: maneja el evento del botón, al seleccionar la forma de la hoja. Invoca el método para procesar la infoemación con la forma seleccionada.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnOblonga_Click(object sender, EventArgs e)
        {
            procesarInfo("Oblonga");
        }

        /*
         *Efecto: maneja el evento del botón, al seleccionar la forma de la hoja. Invoca el método para procesar la infoemación con la forma seleccionada.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnLanceolada_Click(object sender, EventArgs e)
        {
            procesarInfo("Lanceolada");
        }

        /*
         *Efecto: maneja el evento del botón, al seleccionar la forma de la hoja. Invoca el método para procesar la infoemación con la forma seleccionada.
         *Requiere: que se presione el botón.
         *Modifica: N/A
         */
        private void btnOvada_Click(object sender, EventArgs e)
        {
            procesarInfo("Ovada");
        }

        /*
         *Efecto: invoca el método para procesar la información del filtro seleccionado y decide que acción tomar..
         *Requiere: el parámetro con la forma de la hoja.
         *Modifica: N/A
         */
        protected void procesarInfo(String forma)
        {
            proceso.formaHoja(forma);//invocamos el método
            if (proceso.respuesta() == 1)//procesamos la información para verificar que acción tomar
            {//se encontró la respuesta
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
