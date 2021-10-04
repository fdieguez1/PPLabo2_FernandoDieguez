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
        public static int CantidadMaximaClientes { get; set; }
        static Empleado()
        {
            ListaClientes = new List<Cliente>();
            CantidadMaximaClientes = 10;
        }

        double sueldo;
        public double Sueldo
        {
            get { return this.sueldo; }
            set
            {
                this.sueldo = value;
            }
        }

        public Empleado(string nombre, string apellido, string usuario, string contrasenia, double cuil, double sueldo) : base(nombre, apellido, usuario, contrasenia, cuil)
        {
            this.sueldo = sueldo;
        }

        protected void Vender(Cliente cliente, Producto producto, int cantidad)
        {

        }

        public static bool CrearEmpleadoPrueba()
        {
            Empleado auxEmpleado = new Empleado("Fernando", "Dieguez", "ferdieguez", "utnfra2021", 20111111112, 50000);
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
                foreach (Empleado empl in listaEmpleados)
                {
                    if (empl == empleado)
                    {
                        return false;
                    }
                }
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
