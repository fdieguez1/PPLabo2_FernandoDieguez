using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
<<<<<<< HEAD
    /// <summary>
    /// Clase venta, que establece la relacion entre un cliente y un producto cada vez que el primero realiza una compra del segundo
    /// Su carga esta a cargo del empleado o administrador
    /// </summary>
<<<<<<< HEAD
#pragma warning disable CS0661
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
    public class Venta
    {
        Producto producto;
        Cliente cliente;

        static List<Venta> listaVentas;
        public static List<Venta> ListaVentas
        {
            get { return listaVentas; }
            set { listaVentas = value; }
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public Venta this[int id]
=======
        static Venta()
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
        {
            ListaVentas = new List<Venta>();
        }
=======

>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
        public Producto Producto
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public int Unidades
        {
            get
            {
                return this.unidades;
            }
            set
            {
                this.unidades = value;
            }
        }
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)

      

        public Venta(Producto producto, Cliente cliente)
        {
            this.Producto = producto;
            this.Cliente = cliente;

        }

        public bool Vender(Producto producto, Cliente cliente)
        {
            if (cliente.Saldo >= producto.precio && producto.cantidad > 0)
            {
                cliente.Saldo -= producto.precio;
                producto.cantidad--;
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Venta vnt)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{vnt.Cliente}\r");
            sb.AppendLine($"{vnt.Producto}\r");
            sb.AppendLine($"Total a pagar: {vnt.Producto.cantidad * vnt.Producto.precio}\r");

            return sb.ToString();
        }
<<<<<<< HEAD
        
        


        /// <summary>
        /// Sobrecarga del metodo + para cargar un venta a la lista de ventas
        /// </summary>
        /// <param name="listaVentas">lista objetivo</param>
        /// <param name="venta">venta a cargar</param>
        /// <returns>Devuelve true si logro cargar la venta, false si no lo logro</returns>
        public static bool operator +(List<Venta> listaVentas, Venta venta)
        {
            bool altaOk = false;
            foreach (Venta vnt in listaVentas)
            {
                if (vnt == venta)
                {
                    return false;
                }
            }
            listaVentas.Add(venta);
            altaOk = true;
            return altaOk;
        }
        /// <summary>
        /// Sobrecarga del metodo - para eliminar un venta de la lista de ventas
        /// </summary>
        /// <param name="listaVentas">lista objetivo</param>
        /// <param name="venta">venta a eliminar</param>
        /// <returns>devuelve true si logro eliminarlo, false si no lo logro</returns>
        public static bool operator -(List<Venta> listaVentas, Venta venta)
        {
            bool removeOk = false;
            foreach (Venta emp in listaVentas)
            {
                if (emp == venta)
                {
                    listaVentas.Remove(emp);
                    return true;
                }
            }
            removeOk = false;
            return removeOk;
        }
        /// <summary>
        /// Sobrecarga del metodo == para comparar si dos ventas son iguales en sus usuarios
        /// </summary>
        /// <param name="venta1">primer venta a evaluar</param>
        /// <param name="venta2">segundo venta a evaluar</param>
        /// <returns>devuelve true si son iguales sus usuarios, false si no lo son</returns>
        public static bool operator ==(Venta venta1, Venta venta2)
        {
            if (venta1.Id == venta2.Id)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecar del metodo != para evaluar si dos ventas son distintos en sus usuarios
        /// </summary>
        /// <param name="venta1">primer venta a evaluar</param>
        /// <param name="venta2">segundo venta a evaluar</param>
        /// <returns>devuelve true si son distintos sus usuarios, false si no lo son</returns>
        public static bool operator !=(Venta venta1, Venta venta2)
        {
            return !(venta1 == venta2);
        }
        #endregion
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
    }
}
