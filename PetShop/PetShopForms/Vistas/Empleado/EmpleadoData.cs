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
    public partial class EmpleadoData : Form
    {
        double sueldo;
        public double Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }
        public EmpleadoData()
        {
            InitializeComponent();
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            double auxDouble;
            if (double.TryParse(txtSueldo.Text, out auxDouble))
            {
                this.Sueldo = auxDouble;
            }
            else
            {
                txtSueldo.Text.Remove(txtSueldo.Text.Length - 1);
            }
        }

        private void chkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsAdmin.Checked)
            {
                pIsAdmin.Enabled = true;
                pIsAdmin.Visible = true;
            }
            else
            {
                pIsAdmin.Enabled = false;
                pIsAdmin.Visible = false;
            }
        }
    }
}
