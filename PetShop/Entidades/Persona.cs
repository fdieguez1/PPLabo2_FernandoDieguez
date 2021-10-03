using System;

namespace Entidades
{
    public abstract class Persona
    {
        public static Persona UsuarioLogueado;

        string nombre;
        string apellido;
        double cuil;
        string usuario;
        string contrasenia;


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (Validaciones.ValidarNombreApellido(value))
                {
                    this.nombre = value;
                }
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (Validaciones.ValidarNombreApellido(value))
                {
                    this.apellido = value;
                }
            }
        }
        public double Cuil
        {
            get
            {
                return this.cuil;
            }
            set
            {
                if (Validaciones.ValidarCuil(value))
                {
                    this.cuil = value;
                }
            }
        }
        public string Usuario
        {
            get { return this.usuario; }
            set
            {
                this.usuario = value;
            }
        }

        public string Contrasenia
        {
            get { return this.contrasenia; }
            set
            {
                this.contrasenia = value;
            }
        }

        public virtual string NombreCompleto
        {
            get
            {
                return $"{this.Nombre} {this.Apellido}";
            }
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona(string nombre, string apellido, double cuil) : this(nombre, apellido)
        {
            this.Cuil = cuil;
        }

        public abstract string Mostrar();

        public static Persona Login(string usuario, string contrasenia)
        {
            foreach (Persona item in Administrador.ListaEmpleados)
            {
                if (item.usuario == usuario && item.contrasenia == contrasenia)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
