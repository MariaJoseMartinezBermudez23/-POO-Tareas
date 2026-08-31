using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_SOLID
{
    public interface INotificador
    {
        void Enviar(string mensaje);
    }

    public class NotificadorEmail : INotificador
    {
        public void Enviar(string mensaje) => Console.WriteLine($"Email: {mensaje}");
    }

    public class NotificadorSMS : INotificador
    {
        public void Enviar(string mensaje) => Console.WriteLine($"SMS: {mensaje}");
    }

    public class ServicioAlertas
    {
        private readonly INotificador _notificador;

        // Depende de la interfaz (abstracción), no de una clase concreta
        public ServicioAlertas(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void AlertarUsuario(string mensaje)
        {
            _notificador.Enviar(mensaje);
        }
    }
}
