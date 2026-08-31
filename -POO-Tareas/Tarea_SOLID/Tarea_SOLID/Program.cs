using Tarea_SOLID;

Console.WriteLine("=== LSP: Liskov Substitution ===");
List<Ave> aves = new List<Ave> { new Paloma(), new Pinguino() };
foreach (var ave in aves) ave.Mover();

Console.WriteLine();
Console.WriteLine("=== ISP: Interface Segregation ===");
TrabajadorHumano humano = new TrabajadorHumano();
humano.Trabajar();
humano.Comer();

Robot robot = new Robot();
robot.Trabajar();

Console.WriteLine();
Console.WriteLine("=== DIP: Dependency Inversion ===");
ServicioAlertas alertaEmail = new ServicioAlertas(new NotificadorEmail());
alertaEmail.AlertarUsuario("Tu tarea vence hoy");

ServicioAlertas alertaSMS = new ServicioAlertas(new NotificadorSMS());
alertaSMS.AlertarUsuario("Recordatorio de entrega");