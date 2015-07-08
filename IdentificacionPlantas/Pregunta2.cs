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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(radioAserrado.Checked){
                borde = "Aserrado";
            }else if(radioEntero.Checked){
                borde = "Entero";
            }

            proceso.bordeHoja(borde);
        }
    }
}
