using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Cliente
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Clientes/Listado.cs
            CargarClientes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new Agregar();
            DialogResult dialogRes = form.ShowDialog();
            if (dialogRes != DialogResult.None)
            {
                CargarClientes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedCells.Count > 0)
            {
                int selectedRowIndex = this.dgvClientes.SelectedCells[0].RowIndex;
                int selectedId = (int)dgvClientes.Rows[selectedRowIndex].Cells["Id"].Value;
                Form form = new Editar(selectedId);
                DialogResult dialogRes = form.ShowDialog();
                if (dialogRes != DialogResult.None)
                {
                    CargarClientes();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedCells.Count > 0)
            {
                int selectedRowIndex = this.dgvClientes.SelectedCells[0].RowIndex;
                int selectedId = (int)dgvClientes.Rows[selectedRowIndex].Cells["Id"].Value;
                if (MessageBox.Show($"Seguro que desea eliminar el cliente de id: {selectedId}?",
                                         "Confirmacion",
                                         MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    foreach (Cliente clt in Entidades.Empleado.ListaClientes)
                    {
                        if (clt.Id == selectedId)
                        {
                            if (Entidades.Empleado.ListaClientes - clt)
                            {
                                MessageBox.Show("Empleado eliminado",
                                         "Operacion exitosa",
                                         MessageBoxButtons.OK);

                                break;
                            }
                            else
                            {
                                MessageBox.Show("Empleado no eliminado",
                                           "Error",
                                           MessageBoxButtons.OK);
                                break;
                            }
                        }
                    }
                    CargarClientes();
                }
            }
        }

        void CargarClientes()
        {
            if (Entidades.Empleado.ListaClientes.Count > 0)
            {
                dgvClientes.DataSource = new List<Entidades.Cliente>(Entidades.Empleado.ListaClientes);
            }
=======

>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Cliente/Listado.cs
        }
    }
}
