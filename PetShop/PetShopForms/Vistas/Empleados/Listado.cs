﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Empleados
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
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Empleados/Listado.cs
                int selectedRowIndex = this.dgvEmpleados.SelectedCells[0].RowIndex;
                int selectedId = (int)dgvEmpleados.Rows[selectedRowIndex].Cells["Id"].Value;
                if (MessageBox.Show($"Seguro que desea eliminar el empleado de id: {selectedId}?",
                                         "Confirmacion",
                                         MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    foreach (Empleado emp in Administrador.ListaEmpleados)
                    {
                        if (emp.Id == selectedId)
                        {
                            if (Administrador.ListaEmpleados - emp)
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
                    CargarEmpleados();
                }
=======
                CargarEmpleados();
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Empleado/Listado.cs
            }
        }

        void CargarEmpleados()
        {
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Empleados/Listado.cs
            if (Entidades.Administrador.ListaEmpleados.Count > 0)
            {
                dgvEmpleados.DataSource = Administrador.ListarEmpleados();
            }
=======
            dgvEmpleados.DataSource = Entidades.Administrador.ListaEmpleados.GetRange(0, Entidades.Administrador.ListaEmpleados.Count);
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Empleado/Listado.cs
        }
    }
}
