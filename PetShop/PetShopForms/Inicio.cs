using Entidades;
using PetShopForms.Vistas.Menu;
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
    public partial class Inicio : Form
    {
        Form login;

        Form menu;

        public Form Login
        {
            get { return this.login; }
            set { this.login = value; }
        }
        public Form Menu
        {
            get { return this.menu; }
            set { this.menu = value; }
        }


        public Inicio(Form loginForm)
        {
            InitializeComponent();
            Login = loginForm;
        }

        public static Form AddFormToControl(Control.ControlCollection controlCollection, Form sourceForm)
        {
            controlCollection.Remove(sourceForm);
            sourceForm.Dock = DockStyle.Top;
            sourceForm.TopLevel = false;
            sourceForm.TopMost = true;
            sourceForm.FormBorderStyle = FormBorderStyle.None;
            controlCollection.Add(sourceForm);
            sourceForm.Show();
            return sourceForm;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            if (Persona.UsuarioLogueado is Administrador)
            {
                Menu = new MenuAdministrador(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            }
            else
            {
                Menu = new MenuEmpleado() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            }
            this.pMenu.Controls.Add(Menu);
            menu.Show();
            lblWelcome.Text = $"Bienvenido, {Persona.UsuarioLogueado.NombreCompleto}";
            lblUserType.Text = Persona.UsuarioLogueado is Administrador ? "Administrador" : "Empleado";
        }
        public void ChangeBody(Form formToUse)
        {
            pRenderBody.Controls.Clear();
            AddFormToControl(pRenderBody.Controls, formToUse);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar su sesion?",
                                    "Confirmacion",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Persona.UsuarioLogueado = null;
                this.Login.Show();
                this.Close();
            }
        }
       
    }
}
