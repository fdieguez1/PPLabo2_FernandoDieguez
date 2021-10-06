using Entidades.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Productos
{
    public partial class ProductData : Form
    {
        ETipoProducto tipoProd;
        public ETipoProducto TipoProd
        {
            get { return this.tipoProd; }
            set
            {
                this.cmbTipo.SelectedIndex = (int)value;
                this.tipoProd = value;
            }
        }
        int cantidad;
        public int Cantidad
        {
            get { return this.cantidad; }
            set
            {
                this.txtCantidad.Text = value.ToString();
                this.cantidad = value;
            }
        }
        double precio;
        public double Precio
        {
            get { return this.precio; }
            set
            {
                this.txtPrecio.Text = value.ToString();
                this.precio = value;
            }
        }

        private void ProductData_Load(object sender, EventArgs e)
        {
            Array enums = Enum.GetValues(typeof(ETipoProducto));
            foreach (var item in enums)
            {
                this.cmbTipo.Items.Add(item);
            }
        }

        public ProductData()
        {
            InitializeComponent();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            this.Precio = double.Parse(this.txtPrecio.Text);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            this.Cantidad = int.Parse(this.txtCantidad.Text);
        }
    }
}
