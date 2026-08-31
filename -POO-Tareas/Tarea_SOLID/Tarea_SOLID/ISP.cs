using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_SOLID
{
    // MAL: una interfaz gigante obliga a implementar métodos que no aplican
    // BIEN: interfaces separadas

    public interface ITrabajador
    {
        void Trabajar();
    }

    public interface IComible
    {
        void Comer();
    }

    public class TrabajadorHumano : ITrabajador, IComible
    {
        public void Trabajar() => Console.WriteLine("Trabajando");
        public void Comer() => Console.WriteLine("Comiendo");
    }

    public class Robot : ITrabajador 
    {
        public void Trabajar() => Console.WriteLine("Trabajando 24/7");
    }
}
