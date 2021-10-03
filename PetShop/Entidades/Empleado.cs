using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0661
    public class Empleado : Persona
#pragma warning restore CS0661
    {
        static List<Cliente> listaClientes;
        public static List<Cliente> ListaClientes
        {
            get { return listaClientes; }
            set { listaClientes = value; }
        }
        static Empleado()
        {
            ListaClientes = new List<Cliente>();
        }

        
        public Empleado(string nombre, string apellido, string usuario, string contrasenia, double cuil) : base(nombre, apellido, cuil)
        {
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }
        protected bool AltaCliente()
        {
            return true;//Terminar
        }
        protected void ListarClientes()
        {
            if (ListaClientes != null)
            {
                foreach (Cliente cliente in ListaClientes)
                {

                }
            }
        }
        protected void Vender(Cliente cliente, Producto producto, int cantidad)
        {
        }
       

        public static bool CrearEmpleadoPrueba()
        {
            Empleado auxEmpleado = new Empleado("Fernando", "Dieguez", "ferdieguez", "utnfra2021", 20111111112);
            bool altaOk = Administrador.ListaEmpleados + auxEmpleado;
            return altaOk;
        }

        public override string Mostrar()
        {
            return this.ToString();
        }

        public static bool operator +(List<Empleado> listaEmpleados, Empleado empleado)
        {
            bool altaOk = false;
            if (Administrador.CantidadMaximaEmpleados > listaEmpleados.Count)
            {
                listaEmpleados.Add(empleado);
                altaOk = true;
            }
            return altaOk;
        }
        public static bool operator ==(Empleado empleado1, Empleado empleado2)
        {
            if (empleado1.Usuario == empleado2.Usuario)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Empleado empleado1, Empleado empleado2)
        {
            return !(empleado1 == empleado2);
        }
    }
}
