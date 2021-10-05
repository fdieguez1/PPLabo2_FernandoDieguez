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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Editar.cs
            foreach (Producto prd in Producto.ListaProductos)
            {
                if (prd.Id == productId)
                {
                    selectedProduct = prd;
                }
            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            ProductDataForm = (ProductData)Inicio.AddFormToControl(pFullContainer.Controls, new ProductData());
            ProductDataForm.Precio = selectedProduct.Precio;
            ProductDataForm.Cantidad = selectedProduct.Cantidad;
            ProductDataForm.TipoProd = selectedProduct.TipoProducto;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ETipoProducto tipoProd;
            double precio;
            int cantidad;
            string descripcion;
            cantidad = ProductDataForm.Cantidad;
            tipoProd = ProductDataForm.TipoProd;
            precio = ProductDataForm.Precio;
            descripcion = ProductDataForm.Descripcion;

            if (precio < 1 || cantidad < 1)
            {
                MessageBox.Show("Todos los campos son requeridos",
                                      "Error",
                                      MessageBoxButtons.OK);
            }
            else
            {
                Producto auxProducto = new Producto(descripcion, tipoProd, precio, cantidad);
                auxProducto.Id = selectedProduct.Id;
                for (int i = 0; i < Producto.ListaProductos.Count; i++)
                {
                    if (Producto.ListaProductos[i] == selectedProduct)
                    {
                        Producto.ListaProductos[i] = auxProducto;
                        MessageBox.Show("Empleado editado con exito",
                                    "Operacion exitosa",
                                    MessageBoxButtons.OK);
                        break;
                    }
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Editar.cs
        }
    }
}
