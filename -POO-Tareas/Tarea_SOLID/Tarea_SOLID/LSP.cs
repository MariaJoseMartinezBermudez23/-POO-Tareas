using System;
using System.Collections.Generic;
using System.Text;
using Tarea_SOLID;

namespace Tarea_SOLID
{
    public abstract class Ave
    {
        public abstract void Mover();
    }

    public class Paloma : Ave
    {
        public override void Mover() => Console.WriteLine("Vuelo");
    }

    public class Pinguino : Ave
    {
        public override void Mover() => Console.WriteLine("Nado");
    }
}
