using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCSharpBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Pepe", "343213", "asd@asdsa.com");
            Contacto c2 = new Contacto("Carlos", "45356", "asd@asdsa.com");
            Contacto c3 = new Contacto("Tania", "54645", "asd@asdsa.com");

            Agenda agenda = new Agenda();
            agenda.AgregarContacto(c1);
            agenda.AgregarContacto(c2);
            agenda.AgregarContacto(c3);

            //agenda.MostrarContactos();
            //agenda.MostrarOrdenados();
            agenda.MostrarOrdenadosDesc();
        }
    }
}
