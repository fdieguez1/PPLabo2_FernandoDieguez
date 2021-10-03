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
        public Administrador(string nombre, string apellido, string usuario, string contrasenia, double cuil, bool superAdminPower) : base(nombre, apellido, usuario, contrasenia, cuil)
        {
            this.SuperAdminPower = superAdminPower;
        }

        public static bool CrearAdminPrueba()
        {
            Empleado auxAdmin = new Administrador("Christian", "Baus", "Admin", "utnfra2021", 20222222223, true);
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