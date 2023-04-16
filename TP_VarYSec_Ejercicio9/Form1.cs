using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio9
{
    public partial class fTiempos : Form
    {
        public fTiempos()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            double sumaHoras = Convert.ToDouble(tHoras1.Text) + Convert.ToDouble(tHoras2.Text);
            double sumaMin = Convert.ToDouble(tMinutos1.Text) + Convert.ToDouble(tMinutos2.Text);
            double sumaSeg = Convert.ToDouble(tSegundos1.Text) + Convert.ToDouble(tSegundos2.Text);
            MessageBox.Show("La suma de los tiempos es:\n" + sumaHoras + " hs " + sumaMin + " min " + sumaSeg + " seg");
        }
    }
}
