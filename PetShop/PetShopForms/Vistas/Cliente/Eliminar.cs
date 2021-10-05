<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Cliente/Eliminar.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Ventas/VentaDataForm.cs
﻿using Entidades;
using Entidades.Enums;
=======
﻿using Entidades.Enums;
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Ventas/VentaDataForm.cs
using System;
=======
﻿using System;
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Clientes/Eliminar.cs
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
    public partial class Eliminar : Form
    {
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Cliente/Eliminar.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Ventas/VentaDataForm.cs
        double cantidad;
        public double Cantidad
=======
        private void lblNombre_Click(object sender, EventArgs e)
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Ventas/VentaDataForm.cs
        {

<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Cliente/Eliminar.cs
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text.Length > 0)
            {
                if (Validaciones.ValidarDouble(this.txtCantidad.Text))
                    this.Cantidad = int.Parse(this.txtCantidad.Text);
                else
                {
                    this.txtCantidad.Text = string.Empty;
                    MessageBox.Show("Solo estan permitidos numeros",
                                         "Error",
                                         MessageBoxButtons.OK);
                }
            }
=======
        public Eliminar()
        {
            InitializeComponent();
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Clientes/Eliminar.cs
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Ventas/VentaDataForm.cs
        }
    }
}
