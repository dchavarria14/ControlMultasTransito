namespace ControlAreaVolumen
{
    public partial class frmControlAreaVolumen : Form
    {
        private object txtAltura;
        private object txtDiametro;

        public object txtR { get; private set; }
        public object Radio { get; private set; }
        public object Area { get; private set; }
        public object Volumen { get; private set; }

        public frmControlAreaVolumen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Capturando los valores
            double Altura = double.Parse(txtAltura.Text);
            double Diametro = double.Parse(txtDiametro.Text);

            // Realizando los calculos
            double radio = Diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + Altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * Altura;

            // Mostrando los resultados en el cuadro de texto
            txtR.Text = "** Resumen de volumen y áreas **";
            txtR.Text += "\r\nValor Altura:" + Altura.ToString("0.00");
            txtR.Text += "\r\nValor Diametro:" + Diametro.ToString("0.00");
            txtR.Text += "\r\n---------------------------------------------";
            txtR.Text += "\r\nValor Radio:" + Radio.ToString("0.00");
            txtR.Text += "\r\nValor Area:" + Area.ToString("0.00");
            txtR.Text += "\r\nValor Volumen:" + Volumen.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDiametro.Clear();
            txtR.Clear();
            txtAltura.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estás seguro de salir?",
                                              "Medidas",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}