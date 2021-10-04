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
    public partial class Agregar : Form
    {
        public PersonaData PersonaDataForm;
        public EmpleadoData EmpleadoDataForm;
        public Agregar()
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
            }
            Entidades.Empleado auxEmpleado = new Entidades.Empleado(nombre, apellido, usuario, contrasenia, sueldo, cuil)
            {

            };
        }
    }
}
