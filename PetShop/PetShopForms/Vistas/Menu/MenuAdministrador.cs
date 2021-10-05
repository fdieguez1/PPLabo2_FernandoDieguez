using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Menu
{
    public partial class MenuAdministrador : Form
    {
        Inicio inicioForm;
        Inicio InicioForm
        {
            get { return this.inicioForm; }
            set { this.inicioForm = value; }
        }
        public MenuAdministrador(Inicio inicioForm)
        {
            InitializeComponent();
            this.InicioForm = inicioForm;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            InicioForm.ChangeBody(new Empleados.Listado());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            InicioForm.ChangeBody(new Cliente.Listado());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            InicioForm.ChangeBody(new Productos.Listado());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            InicioForm.ChangeBody(new Venta.Listado());
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            InicioForm.ChangeBody(new Administradores.Listado());
=======
            InicioForm.ChangeBody(new Producto.Listado());
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
        }
    }
}
