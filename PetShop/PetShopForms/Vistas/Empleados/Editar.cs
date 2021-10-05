﻿using Entidades;
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

namespace PetShopForms.Vistas.Empleados
{
    public partial class Editar : Form
    {
        public PersonaData PersonaDataForm;
        public EmpleadoData EmpleadoDataForm;
        public Empleado selectedEmpleado;
        public Editar(int empleadoId)
        {
            InitializeComponent();
            foreach (Empleado emp in Administrador.ListaEmpleados)
            {
                if (emp.Id == empleadoId)
                {
                    selectedEmpleado = emp;
                }
            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            EmpleadoDataForm = (EmpleadoData)Inicio.AddFormToControl(pFullContainer.Controls, new EmpleadoData());
            PersonaDataForm = (PersonaData)Inicio.AddFormToControl(pFullContainer.Controls, new Persona.PersonaData());
            EmpleadoDataForm.Sueldo = selectedEmpleado.Sueldo;
            PersonaDataForm.Nombre = selectedEmpleado.Nombre;
            PersonaDataForm.Apellido = selectedEmpleado.Apellido;
            PersonaDataForm.Cuil = selectedEmpleado.Cuil;
            PersonaDataForm.Usuario= selectedEmpleado.Usuario;
            PersonaDataForm.Contrasenia= selectedEmpleado.Contrasenia;
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
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Empleados/Editar.cs
                Empleado auxEmpleado = new Empleado(nombre, apellido, usuario, contrasenia, cuil, sueldo);
                auxEmpleado.Id = selectedEmpleado.Id;
                for (int i = 0; i < Administrador.ListaEmpleados.Count; i++)
=======
                Entidades.Empleado auxEmpleado = new Entidades.Empleado(nombre, apellido, usuario, contrasenia, cuil, sueldo);
                bool altaOk = Administrador.ListaEmpleados + auxEmpleado;
                if (altaOk)
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Empleado/Editar.cs
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
