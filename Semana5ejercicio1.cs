using System;

namespace RelojDigital
{
    public class Reloj
    {
        public int Hora { get; private set; }
        public int Minuto { get; private set; }

        public Reloj(int hora, int minuto)
        {
            Hora = hora % 24;
            Minuto = minuto % 60;
        }

        public void MostrarHora()
        {
            console.WriteLine($"Hora actual: {Hora:D2}:{Minuto:D2}");
        }

        public void AvanzarMinuto()
        {
            Minuto++;
            if (Minuto == 60)
            {
                Minuto = 0;
                Hora = (Hora + 1) % 24;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new Reloj(12, 15);
            reloj.MostrarHora();
            reloj.AvanzarMinuto();
            reloj.MostrarHora();
        }
    }
}