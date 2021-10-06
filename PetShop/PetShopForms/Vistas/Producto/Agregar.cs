using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Producto
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Agregar.cs

        private void Agregar_Load(object sender, EventArgs e)
        {
            ProductDataForm = (ProductData)Inicio.AddFormToControl(pFullContainer.Controls, new ProductData());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ETipoProducto tipoProd;
            double precio;
            int cantidad;
            cantidad = ProductDataForm.Cantidad;
            tipoProd = ProductDataForm.TipoProd;
            precio = ProductDataForm.Precio;

            if (precio < 1 || cantidad < 1)
            {
                MessageBox.Show("Todos los campos son requeridos",
                                      "Error",
                                      MessageBoxButtons.OK);
            }
            else
            {
                Producto auxProducto = new Producto(tipoProd, precio, cantidad);
                bool altaOk = Producto.ListaProductos + auxProducto;
                if (altaOk)
                {
                    MessageBox.Show("Alta de producto exitosa",
                                              "Carga exitosa",
                                              MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error en la carga del producto",
                                              "Error",
                                              MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pFullContainer_Paint(object sender, PaintEventArgs e)
        {

        }
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Agregar.cs
    }
}
