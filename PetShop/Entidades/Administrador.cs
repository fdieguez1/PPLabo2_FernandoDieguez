using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Administrador : Empleado
    {
        public static List<Empleado> ListaEmpleados { get; set; }
        public static int CantidadMaximaEmpleados { get; set; }

        bool superAdminPower;
        public bool SuperAdminPower
        {
            get
            {
                return this.superAdminPower;
            }
            set
            {
                this.superAdminPower = value;
            }
        }
        double bono;
        public double Bono
        {
            get { return this.bono; }
            set { this.bono = value; }
        }

        static Administrador()
        {
            ListaEmpleados = new List<Empleado>();
            CantidadMaximaEmpleados = 20;
        }
        /// <summary>
        /// Devuelve una lista de empleados, filtrando solo del tipo Empleado
        /// </summary>
        /// <returns></returns>
        public static List<Empleado> ListarEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            foreach(Persona emp in ListaEmpleados)
            {
                if(emp is Empleado && !(emp is Administrador))
                {
                    empleados.Add((Empleado)emp);
                }
            }
            return empleados;
        }
        /// <summary>
        /// Devuelve una lista de administradores, filtrando solo del tipo Administrador
        /// </summary>
        /// <returns></returns>
        public static List<Administrador> ListarAdministradores()
        {
            List<Administrador> admins = new List<Administrador>();
            foreach (Persona emp in ListaEmpleados)
            {
                if (emp is Administrador)
                {
                    admins.Add((Administrador)emp);
                }
            }
            return admins;
        }
        public Administrador(string nombre, string apellido, string usuario, string contrasenia, double cuil, double sueldo, bool superAdminPower, double bono) : base(nombre, apellido, usuario, contrasenia, cuil, sueldo)
        {
            this.SuperAdminPower = superAdminPower;
            this.Bono = bono;
        }

        public static bool CrearAdminPrueba()
        {
            Empleado auxAdmin = new Administrador("Elpe", "Rrito", "Admin", "utnfra2021", 20222222223, 1000000, true, 100000);
            bool altaOk = Administrador.ListaEmpleados + auxAdmin;
            return altaOk;
        }
        void ListarEmpleados()
        {
        }

        void VerFacturacion()
        {

        }

    }
}