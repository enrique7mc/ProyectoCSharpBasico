using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCSharpBasico
{
    public class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        public Contacto()
        {
        }

        protected bool Equals(Contacto other)
        {
            return string.Equals(Nombre, other.Nombre) && string.Equals(Telefono, other.Telefono);
        }

        public int CompareTo(Contacto other)
        {
            return this.Nombre.CompareTo(other.Nombre);
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj))
            {
                return false;
            }
            if(ReferenceEquals(this, obj))
            {
                return true;
            }
            if(obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Contacto) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Nombre != null ? Nombre.GetHashCode() : 0) * 397) ^ (Telefono != null ? Telefono.GetHashCode() : 0);
            }
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}\nTeléfono: {1}\nEmail: {2}\n",
                Nombre, Telefono, Email);
        }
    }
}
