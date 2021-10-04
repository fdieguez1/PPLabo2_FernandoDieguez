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

        static Administrador()
        {
            ListaEmpleados = new List<Empleado>();
            CantidadMaximaEmpleados = 10;
        }
        public Administrador(string nombre, string apellido, string usuario, string contrasenia, double cuil, double sueldo, bool superAdminPower, double bono) : base(nombre, apellido, usuario, contrasenia, cuil, sueldo)
        {
            this.SuperAdminPower = superAdminPower;
        }

        public static bool CrearAdminPrueba()
        {
            Empleado auxAdmin = new Administrador("Elpe", "Rrito", "Admin", "utnfra2021", 20222222223, 1000000, true, 10000);
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