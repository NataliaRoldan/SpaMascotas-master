using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaMascotas
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult mensajeOk = MessageBox.Show("Quieres salir?");
            if (mensajeOk == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
