namespace Area_y_volumen
{
    public partial class frmCalculoareavolumen : Form
    {
        public frmCalculoareavolumen()
        {
            InitializeComponent();
        }

        private void lblAlturaCal_Click(object sender, EventArgs e)
        {

        }

        private void lblCanculo_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Altura = double.Parse(txtCalaltura.Text);
            double Diametro = double.Parse(txtDaiametrocal.Text);



            double radio = Diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + Altura);
            double volumen = 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void txtCalaltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDaiametrocal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}