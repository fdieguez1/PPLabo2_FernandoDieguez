using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Empleado
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            List<Entidades.Persona> listadoEmpleados = new List<Entidades.Persona>(Entidades.Empleado.ListaClientes);
            foreach (Entidades.Persona user in listadoEmpleados)
            {
                user.Contrasenia = "-";
            }
            dgvEmpleados.DataSource = listadoEmpleados;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addForm = new Agregar();
            addForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
