using WinFormClienteEjemplo.ClientService;
using WinFormClienteEjemplo.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
                tbId.Clear();
                tbNombre.Clear();
                tbNota.Clear();

                tbId.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la consulta");
            }
        }

        DataGridViewRow selected;
        private async void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                selected = dgvAlumnos.SelectedRows[0];

                if (selected != null)
                {
                    int id = Convert.ToInt32(selected.Cells[0].Value);

                    //vuelvo a buscarlo por si cambio, pero podría tomar el registro desde el datagrid
                    Alumno seleccionado = await cliente.GetById(id);

                    if (seleccionado != null)
                    {
                        tbId.Text = $"{seleccionado.Id}";
                        tbNombre.Text = seleccionado.Nombre;
                        tbNota.Text = $"{seleccionado.Nota:0.00}";
                    }
                    else
                    {
                        MessageBox.Show("El alumno no se encuentra actualmente en el sistema, actualice el listado");
                    }
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la consulta");
            }
        }

        async private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvAlumnos.SelectedRows[0];

                if (selected != null)
                {
                    int id = Convert.ToInt32(selected.Cells[0].Value);
                    await cliente.Eliminar(id);

                    dgvAlumnos.Rows.Remove(selected);

                    tbId.Clear();
                    tbNombre.Clear();
                    tbNota.Clear();

                    tbId.Text = "0";
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la consulta");
            }
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(tbId.Text);
                var nombre = Convert.ToString(tbNombre.Text);
                var nota = Convert.ToDecimal(tbNota.Text);


                var nuevo = new Alumno() { Id = id, Nombre = nombre, Nota = nota };

                //detecta si es actualización o un registro nuevo

                Alumno alumno = null;
                if (nuevo.Id > 0)
                {
                    alumno = await cliente.Actualizar(nuevo);

                    if (alumno != null)
                    {
                        selected.Cells[0].Value = alumno.Id;
                        selected.Cells[1].Value = alumno.Nombre;
                        selected.Cells[2].Value = alumno.Nota;
                    }
                    else
                    {
                        MessageBox.Show("El alumno no pudo ser actualizado");
                    }
                }
                else
                {
                    alumno = await cliente.Create(nuevo);

                    if (alumno != null)
                    {
                        dgvAlumnos.Rows.Add(new string[] { alumno.Id.ToString(), alumno.Nombre, alumno.Nota.ToString("0.00") });
                    }
                    else
                    {
                        MessageBox.Show("El alumno no pudo ser dado de alta");
                    }
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
