using Entidades;
using PetShopForms.Vistas.Persona;
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
    public partial class Delete : Form
    {
        public PersonaData PersonaDataForm;
        public EmpleadoData EmpleadoDataForm;
        public Delete()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            EmpleadoDataForm = (EmpleadoData)Inicio.AddFormToControl(pFullContainer.Controls, new Empleado.EmpleadoData());
            PersonaDataForm = (PersonaData)Inicio.AddFormToControl(pFullContainer.Controls, new Persona.PersonaData());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string usuario, contrasenia, nombre, apellido;
            double sueldo, cuil;

            usuario = PersonaDataForm.Usuario;
            contrasenia = PersonaDataForm.Contrasenia;
            cuil = PersonaDataForm.Cuil;
            nombre = PersonaDataForm.Nombre;
            apellido = PersonaDataForm.Apellido;
            sueldo = EmpleadoDataForm.Sueldo;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia) || cuil < 1
                || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || sueldo < 1)
            {
                MessageBox.Show("Todos los campos son requeridos",
                                      "Error",
                                      MessageBoxButtons.OK);
            }
            else
            {
                Entidades.Empleado auxEmpleado = new Entidades.Empleado(nombre, apellido, usuario, contrasenia, cuil, sueldo);
                bool altaOk = Administrador.ListaEmpleados + auxEmpleado;
                if (altaOk)
                {
                    MessageBox.Show("Alta de empleado exitosa",
                                              "Carga exitosa",
                                              MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error en la carga del empleado",
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
    }
}
