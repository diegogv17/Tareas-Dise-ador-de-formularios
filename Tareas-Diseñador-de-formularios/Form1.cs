namespace Tareas_Diseñador_de_formularios
{
    public partial class fmRegistros : Form
    {
        private List<Registro> registros = new List<Registro>();


        public fmRegistros()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCarnet.Clear();
            cmbCarrera.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (txtNombre.Text == null || txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese su nombre antes de continuar.");
                return;
            }
            else if (txtCarnet.Text.Length != 7)
            {
                MessageBox.Show("Ingrese el numero de carnet correctamente.");
                return;
            }
            else if (cmbCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione algunas de las opciones disponibles.");
                return;
            }
            Registro nuevoRegistro = new Registro()
            {
                Nombre = txtNombre.Text,
                Carnet = txtCarnet.Text,
                Carrera = cmbCarrera.Text
            };
            registros.Add(nuevoRegistro);
            lblLista.Text = ""; 
            foreach (var r in registros)
            {
                lblLista.Text += r.ToString + Environment.NewLine;
            }

            txtNombre.Clear();
            txtCarnet.Clear();
            cmbCarrera.SelectedIndex = -1;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void fmRegistros_Load(object sender, EventArgs e)
        {

        }
        public class Registro
        {
            public string Nombre { get; set; }
            public string Carnet { get; set; }
            public string Carrera { get; set; }

            public string ToString => $"Nombre: {Nombre}, Carnet: {Carnet}, Carrera: {Carrera}";
        }

    }
}
