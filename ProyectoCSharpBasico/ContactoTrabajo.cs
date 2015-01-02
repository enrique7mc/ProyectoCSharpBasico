using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCSharpBasico
{
    public class ContactoTrabajo : Contacto
    {
        public string TelOficina { get; set; }

        public ContactoTrabajo(string nombre, string telefono, string email, string telOficina) 
            : base(nombre, telefono, email)
        {
            TelOficina = telOficina;
        }        

        public ContactoTrabajo(string telOficina)
        {
            TelOficina = telOficina;
        }

        public override string ToString()
        {
            return base.ToString() + "Tel. Oficina: " + TelOficina;
        }
    }
}
