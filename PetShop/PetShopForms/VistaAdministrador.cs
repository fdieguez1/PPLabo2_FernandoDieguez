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
    public partial class VistaAdministrador : Form
    {
        public VistaAdministrador()
        {
            InitializeComponent();
        }

        private void VistaAdministrador_Load(object sender, EventArgs e)
        {
            List<Persona> sourceListEmpleados = new List<Persona>(Administrador.ListaEmpleados);
            foreach (Persona item in sourceListEmpleados)
            {
                item.Contrasenia = "-";
            }
            List<Venta> sourceListVentas = new List<Venta>();

        }
    }
}
