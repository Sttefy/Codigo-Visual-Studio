namespace Clinica
{
    //Clase paciente
    public class Paciente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }

        public Paciente (string nombre, int edad, string identificacion)
        {
            Nombre = nombre;
            Edad = edad;
            Identificacion = identificacion;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Identificacion: {Identificacion}";
        }
    }
    //Clase turno
    public class Turno
    {
        public DateTime FechaHora { get; set; }
        public Paciente Paciente {get; set; }

        public Turno(DateTime fechaHora, Paciente paciente)
        {
            FechaHora = fechaHora;
            Paciente = paciente;
        }
        public override string ToString()
        {
            return $"FechaHora: {FechaHora}, Paciente: {Paciente}";
        }
    }

     //Clase Agenda
    public class Agenda
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Turno> turnos = new List<Turno>();
        
        //Registro Paciente
        public void RegistrarPaciente(string nombre, int edad, string identificacion)
        {
            pacientes.Add(new Paciente(nombre, edad, identificacion));
            Console WriteLine("El paciente ha sido registrado exitosamente.");
        }
        
        //Asigna turno
        public void AsignarTurno(string identificacion, DateTime fechahora)
        {
            var paciente = pacientes.Find(paciente => paciente.Identificacion == identificacion);
            if (paciente == null)
            {
                Console.WriteLine("No se encontro al paciente.");
                return;
            }
        
            turnos.Add(new Turno(fechahora, paciente));
            Console.WriteLine("El turno ha sido asignado correctamente.");
        }
        
        //Consulta turno fecha
        public void ConsultarTurnosPorFecha(DateTime fecha)
        {
            var turnosEnFecha = turnos.FindAll(t => t.FechaHora.Date == fecha.Date);

            if (turnosEnFecha.Count == 0)
            {
                Console.WriteLine("No hay disponobilidad de turnos para la fecha elegida.");
                return;
            }

            Console.WriteLine("Disponibilidad de turnos en la fecha seleccionada:");
            foreach (var turno in turnosEnFecha)
            {
                Console.WriteLine(turno);
            }
        }
        
        //Consulta turno paciente
        public void ConsultarTurnosPorPaciente(string identificacion)
        {
            var turnosDelPaciente = turnos.FindAll(t => t.Paciente.Identificacion == identificacion);
        
            if (turnosDelPaciente.Count == 0)
            {
                Console.WriteLine("No hay turnos agendados para el paciente seleccionado.");
                return;
            }

            Console.WriteLine("Turnos del paciente seleccionado:");
            foreach (var turno in turnosDelPaciente)
            {
                Console.WriteLine(turno);
            }
        }
        
        //Elimina turno
        public void EliminarTurno(DateTime fechaHora, string identificacion)
        {
            var turno = turnos.Find(t => t.FechaHora == fechaHora == && t.Paciente.Identificacion == identificacion);
            if (turno == null)
            {
                Cosole.WriteLine("Turno no encontrado.");
                return;
            }

            turnos.Remove(turno);
            Console.WriteLine("Turno eliminado exitosamente.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            
            //Menú
            while (true)
            {
                Console.WriteLine("\n--- Sistema de Gestion de Turnos ---");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Asignar turno");
                Console.WriteLine("3. Consultar turnos por fecha");
                Console.WriteLine("4. Consultar turnos por paciente");
                Console.WriteLine("5. Eliminar turno");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                int opción;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del paciente: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Edad del paciente: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Write("Identificación del paciente: ");
                        string identificacion = Console.ReadLine();
                        agenda.RegistrarPaciente(nombre, edad, identificacion);
                        break;
                    case 2:
                        Console.Write("Identificación del paciente: ");
                        identificacion = Console.ReadLine();
                        Console.Write("Fecha y hora del turno (YYYY-MM-DD HH:MM): ");
                        DateTime fechaHora = DateTime.Parse(Console.ReadLine());
                        agenda.AsignarTurno(identificacion, fechaHora);
                        break;
                    case 3:
                        Console.Write("Fecha para consultar turnos (YYYY-MM-DD): ");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());
                        agenda.ConsultarTurnosPorFecha(fecha);
                        break;
                    case 4:
                        Console.Write("Identificación del paciente ");
                        identificacion = Console.ReadLine();
                        agenda.ConsultarTurnosPorPaciente(identificacion);
                        break;
                    case 5:
                        Console.Write("Identificación del paciente: ");
                        identificacion = Console.ReadLine();
                        Console.Write("Fecha y hora del turno a eliminar (YYYY-MM-DD HH:MM): ");
                        fechaHora = DateTime.Parse(Console.ReadLine());
                        agenda.EliminarTurno(fechaHora, identificacion);
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        return;
                    default:
                        Console.WriteLine("Opcion no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }

}
