namespace SpaMascotas
{
    public partial class SpaForm : Form
    {
        Spa spa = new Spa();

        public SpaForm()
        {
            InitializeComponent();
        }  

        private bool validarTextos()
        {
            if (textNameOwner.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del propietario");
                return false;
            }
            if (textNameMascot.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la mascota");
                return false;
            }
            if (!Service1.Checked && !Service2.Checked && !Service3.Checked)
            {
                MessageBox.Show("Debe seleccionar algun servicio");
                return false;
            }
            return true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mensajeOk = MessageBox.Show("Quieres salir?");
            if (mensajeOk == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validarTextos())
            {
                spa.Propietario = textNameOwner.Text;
                spa.identificacion = double.Parse(textIdentificacion.Text);
                spa.mascota = textNameMascot.Text;
                MessageBox.Show("COMBI ES"+cmbEstrato.Text);
                spa.estrato = cmbEstrato.Text;
                StateShow.Enabled = true;

                //precio = precio - (precio * descuento / 100);
                //panel1.Visible = true;
                //nameofowner.Text = name;
                //nameofpet.Text = mascota;
                //estratofield.Text = estrato;
                //preciofield.Text = precio.ToString() + ".000";

            }
        }

        private void StateShow_Click(object sender, EventArgs e)
        {
            if (Service1.Checked)
            {
                FormReporte reporte = new FormReporte();
                reporte.Show();
                spa.setpagoservicio1();
                reporte.txtpropietario.Text = spa.Propietario;
                reporte.txtIdentificacion.Text = Convert.ToString(spa.identificacion);
                reporte.txtMascota.Text = spa.mascota;
                reporte.txtEstrato.Text = spa.estrato;
                reporte.txtServicio.Text += "Baño y corte";
                reporte.txtTotal.Text = Convert.ToString(spa.gettotalvalor());
                reporte.txtDescuento.Text = Convert.ToString(spa.DescuentoEstrato12);
                this.Hide();
            }
            if (Service2.Checked)
            {
                FormReporte reporte = new FormReporte();
                reporte.Show();
                spa.setpagoservicio2();
                reporte.txtpropietario.Text = spa.Propietario;
                reporte.txtIdentificacion.Text = Convert.ToString(spa.identificacion);
                reporte.txtMascota.Text = spa.mascota;
                reporte.txtEstrato.Text = spa.estrato;
                reporte.txtServicio.Text += "Baño, corte y vacuna garrapatas";
                reporte.txtTotal.Text = Convert.ToString(spa.gettotalvalor());
                reporte.txtDescuento.Text = Convert.ToString(spa.DescuentoEstrato34); 
                this.Hide();
            }
            if (Service3.Checked)
            {
                FormReporte reporte = new FormReporte();
                reporte.Show();
                spa.setpagoservicio3();
                reporte.txtpropietario.Text = spa.Propietario;
                reporte.txtIdentificacion.Text = Convert.ToString(spa.identificacion);
                reporte.txtMascota.Text = spa.mascota;
                reporte.txtEstrato.Text = spa.estrato;
                reporte.txtServicio.Text += "Baño, corte,vacuna garrapatas y antigarrapatas";
                reporte.txtTotal.Text = Convert.ToString(spa.gettotalvalor());
                reporte.txtDescuento.Text = Convert.ToString(spa.DescuentoEstrato5);
                this.Hide();
            }

        }
    }
}
