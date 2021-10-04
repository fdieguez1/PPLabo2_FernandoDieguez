using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopForms.Vistas.Persona
{
    public partial class PersonaData : Form
    {
        string usuario, contrasenia, nombre, apellido;
        double cuil;
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public string Contrasenia
        {
            get { return this.contrasenia; }
            set { this.contrasenia = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public double Cuil
        {
            get { return this.cuil; }
            set { this.cuil = value; }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.Nombre = txtNombre.Text;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            this.Apellido = txtApellido.Text;
        }

        private void txtCuil_TextChanged(object sender, EventArgs e)
        {
            double auxDouble;
            if (double.TryParse(txtCuil.Text, out auxDouble))
            {
                this.Cuil = auxDouble;
            }
            else
            {
                txtCuil.Text.Remove(txtCuil.Text.Length - 1);
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            this.Usuario = txtUsuario.Text;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            this.Contrasenia = txtContrasenia.Text;
        }

        public PersonaData()
        {
            InitializeComponent();
        }
    }
}
