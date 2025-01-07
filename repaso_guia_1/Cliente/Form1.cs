using Cliente.ClientServices;
using Cliente.Models;

namespace Cliente
{
    public partial class Form1 : Form
    {
        PersonaClientService cliente = new PersonaClientService();

        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Clear();
            foreach (var p in await cliente.GetAll())
            {
                dataGridView1.Rows.Add(new object[] { p.DNI, p.Nombre } );
            }
        }
    }
}
