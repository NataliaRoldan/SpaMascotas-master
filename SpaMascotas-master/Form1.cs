namespace SpaMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textPassword.Text == "123")
            {
                SpaForm servicio = new SpaForm();
                servicio.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}