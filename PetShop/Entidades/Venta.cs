using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase venta, que establece la relacion entre un cliente y un producto cada vez que el primero realiza una compra del segundo
    /// Su carga esta a cargo del empleado o administrador
    /// </summary>
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
        static Venta()
        {
            ListaVentas = new List<Venta>();
        }
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
    }
}
