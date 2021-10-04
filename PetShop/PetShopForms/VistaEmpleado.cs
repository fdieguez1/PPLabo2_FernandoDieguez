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

namespace PetShopForms
{
    public partial class VistaEmpleado : Form
    {
        public VistaEmpleado()
        {
            InitializeComponent();
        }

        private void VistaEmpleado_Load(object sender, EventArgs e)
        {
            List<Cliente> sourceListClientes = new List<Cliente>(Empleado.ListaClientes);
            foreach (Persona item in sourceListClientes)
            {
                item.Contrasenia = "-";
            }
            List<Venta> sourceListVentas = new List<Venta>();
        }
    }
}
