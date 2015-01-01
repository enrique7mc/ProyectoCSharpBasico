using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCSharpBasico
{
    public class Agenda
    {
        private const int TAM = 10;
        private Contacto[] _contactos;
        private int _index;
        public int NumContactos 
        { 
            get { return _index; }
            private set {  }
        }

        public Agenda()
        {
            _index = 0;
            _contactos = new Contacto[TAM];
        }

        public void AgregarContacto(Contacto contacto)
        {
            if(_index < TAM)
            {
                _contactos[_index] = contacto;
                _index++;
            }
            else
            {
                Console.WriteLine("Agenda llena");
            }
        }

        public void BorrarUltimoContacto()
        {
            if(_index > 0)
            {
                _contactos[_index] = null;
                _index--;
            }
            else
            {
                Console.WriteLine("La agenda ya está vacía");
            }
        }

        public void MostrarOrdenados()
        {
            Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos, ordenados, _index);
            Array.Sort(ordenados);            

            Console.WriteLine(CadenaContactos(ordenados));
        }

        public void MostrarOrdenadosDesc()
        {
            Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos, ordenados, _index);            
            Array.Sort(ordenados);
            Array.Reverse(ordenados);

            Console.WriteLine(CadenaContactos(ordenados));
        }

        public void MostrarContactos()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return CadenaContactos(_contactos);
        }

        private string CadenaContactos(Contacto[] contactos)
        {
            var sb = new StringBuilder();
            for(int i = 0; i < _index; i++)
            {
                if (_contactos[i] == null) { continue; }

                string dato = string.Format("{0}. {1}", i + 1, contactos[i]);
                sb.AppendLine(dato);
            }

            return sb.ToString();
        }
    }
}
