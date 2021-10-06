using Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public static int PrevId;
        int id;
<<<<<<< HEAD
<<<<<<< HEAD
        double precio;
        int cantidad;

        static List<Producto> listaProductos;
        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }

        ETipoProducto tipoProducto;
        public ETipoProducto TipoProducto
        {
            get { return this.tipoProducto; }
            set { this.tipoProducto = value; }
        }

        public Producto this[int id]
        {
            get
            {
                foreach(Producto prod in ListaProductos)
                {
                    if(prod.id == id)
                    {
                        return prod;
                    }
                }
                return null;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
=======
        public double precio;
        public int cantidad;
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        static Producto()
        {
            PrevId = 0;
        }

        static List<Producto> listaProductos;
        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }

        ETipoProducto tipoProducto;
        public ETipoProducto TipoProducto
        {
            get { return this.tipoProducto; }
            set { this.tipoProducto = value; }
        }

<<<<<<< HEAD
        /// <summary>
        /// Constructor de la clase producto, asigna sus valores de tipo, precio y cantidad, no se puede inicializar un producto sin estos datos
        /// </summary>
        /// <param name="tipo">ETipoProducto Enumerado, de valores predefinidos, con el valor a ser asignado</param>
        /// <param name="precio">Precio del producto por unidad</param>
        /// <param name="cantidad">Cantidad de productos en existencia</param>
        public Producto(ETipoProducto tipo, double precio, int cantidad)
        {
            this.Id = ++PrevId;
            PrevId = this.Id;
            this.TipoProducto = tipo;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        /// <summary>
        /// Sobrecarga del metodo + para agregar una carga de producto al listado de productos
        /// </summary>
        /// <param name="listaProductos">listado de productos</param>
        /// <param name="Producto">producto a ser cargado</param>
        /// <returns>devuelve true si fue exitoso, false si no lo fue</returns>
        public static bool operator +(List<Producto> listaProductos, Producto Producto)
=======
        public Producto(ETipoProducto tipo)
        {
            this.Id = ++PrevId;
            PrevId = this.Id;
            this.tipoProducto = tipo;
        }

        public static List<Producto> operator +(List<Producto> productos, Producto producto)
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
        {
            if (!(productos is null) && !(producto is null))
            {
                foreach (Producto p in productos)
                {
                    if (p == producto)
                        return productos;
                }
                productos.Add(producto);
            }

            return productos;
        }
        public static List<Producto> operator -(List<Producto> productos, Producto producto)
        {
            if (!(productos is null) && !(producto is null))
            {
                foreach (Producto p in productos)
                {
                    if (p == producto)
                    {
                        productos.Remove(p);
                        break;
                    }
                }
            }
            return productos;
        }
    }
}
