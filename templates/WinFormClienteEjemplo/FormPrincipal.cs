using WinFormClienteEjemplo.ClientService;
using WinFormClienteEjemplo.Models;

namespace WinFormClienteEjemplo
{
    public partial class FormPrincipal : Form
    {
        AlumnosClientService cliente = new AlumnosClientService();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        async private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                var alumnos = await cliente.GetAll();

                dgvAlumnos.Rows.Clear();
                foreach (var a in alumnos)
                {
                    dgvAlumnos.Rows.Add(new string[] { a.Id.ToString(), a.Nombre, a.Nota.ToString("0.00") });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la consulta");
            }
        }

        async private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var id = 0;//Convert.ToInt32(tbId.Text);
                var nombre = Convert.ToString(tbNombre.Text);
                var nota = Convert.ToDecimal(tbNota.Text);

                var nuevo = new Alumno() { Id = id, Nombre = nombre, Nota = nota };
                var creado=await cliente.Create(nuevo);

                if (creado != null)
                {
                    dgvAlumnos.Rows.Add(new string[] { creado.Id.ToString(), creado.Nombre, creado.Nota.ToString("0.00") });
                }
                else
                {
                    MessageBox.Show("El alumno no pudo ser dado de alta");
                }

                tbId.Clear();
                tbNombre.Clear();
                tbNota.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la consulta");
            }
        }
    }
}
