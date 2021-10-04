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
            CargarEmpleados();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new Agregar();
            DialogResult dialogRes = form.ShowDialog();
            if (dialogRes != DialogResult.None)
            {
                CargarEmpleados();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = this.dgvEmpleados.SelectedCells[0].RowIndex;
            int selectedId = (int)dgvEmpleados.Rows[selectedRowIndex].Cells["Id"].Value;
            Form form = new Editar(selectedId);
            DialogResult dialogRes = form.ShowDialog();
            if (dialogRes != DialogResult.None)
            {
                CargarEmpleados();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form form = new Delete();
            DialogResult dialogRes = form.ShowDialog();
            if (dialogRes != DialogResult.None)
            {
                CargarEmpleados();
            }
        }

        void CargarEmpleados()
        {
            dgvEmpleados.DataSource = Entidades.Administrador.ListaEmpleados.GetRange(0, Entidades.Administrador.ListaEmpleados.Count);
        }
    }
}
