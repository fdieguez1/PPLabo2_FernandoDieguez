using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0661 
    public class Cliente : Persona
#pragma warning restore CS0661 
    {
        double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                this.saldo = value;
            }
        }


        public Cliente(string nombre, string apellido, string usuario, string contrasenia, double saldo, double cuil) : base(nombre, apellido, usuario, contrasenia, cuil)
        {
            this.Saldo = saldo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Saldo: {this.Saldo.ToString()}");
            return sb.ToString();
        }
<<<<<<< HEAD
<<<<<<< HEAD

        #region sobrecargas
        
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
        /// <summary>
        /// Sobrecarga del operador + para agregar clientes a la lista de clientes
        /// </summary>
        /// <param name="listaClientes">lista objetivo</param>
        /// <param name="cliente">cliente a agregar</param>
        /// <returns>true si logro agregarlo, false si no lo logro</returns>
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
        public static bool operator +(List<Cliente> listaClientes, Cliente cliente)
        {
            bool altaOk = false;
            if (Empleado.CantidadMaximaClientes > listaClientes.Count)
            {
                foreach (Cliente clt in listaClientes)
                {
                    if (clt == cliente)
                    {
                        return false;
                    }
                }
                listaClientes.Add(cliente);
                altaOk = true;
            }
            return altaOk;
        }
<<<<<<< HEAD
        /// <summary>
        /// Sobrecarga del operador - para eliminar clientes a la lista de clientes
        /// </summary>
        /// <param name="listaClientes">lista objetivo</param>
        /// <param name="cliente">cliente a agregar</param>
        /// <returns>true si logro agregarlo, false si no lo logro</returns>
        public static bool operator -(List<Cliente> listaClientes, Cliente Cliente)
        {
            bool removeOk = false;
            if (Entidades.Empleado.CantidadMaximaClientes > listaClientes.Count)
            {
                foreach (Cliente clt in listaClientes)
                {
                    if (clt == Cliente)
                    {
                        listaClientes.Remove(clt);
                        return true;
                    }
                }
                removeOk = false;
            }
            return removeOk;
        }
        /// <summary>
        /// Sobrecarga del operador == para comparar dos clientes por su nombre de usuario
        /// </summary>
        /// <param name="cliente1">primer cliente a evaluar</param>
        /// <param name="cliente2">segundo cliente a evaluar</param>
        /// <returns>true si son usuarios iguales, false si son usuarios diferentes</returns>
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.Usuario == cliente2.Usuario)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
    }
}
