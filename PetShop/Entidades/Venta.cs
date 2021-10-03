using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
    }
}
