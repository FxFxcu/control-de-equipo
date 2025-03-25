using System;

namespace ControlEquipoInf
{
    //declaramos las propiedades de cada componente de la computadora.
    public class RAM
    {
        public int Memoria { get; set; }
        public float Frecuencia { get; set; }
        public int Generacion { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Memoria RAM: {Memoria}GB, {Frecuencia}GHz, Gen {Generacion}, Marca: {Marca}, Tipo: {Tipo}");
        }
    }

    public class CPU
    {
        public int Nucleos { get; set; }
        public float Frecuencia { get; set; }
        public int Cache { get; set; }
        public string Marca { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public int Generacion { get; set; }
        public int Consumo { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Procesador: Gen {Generacion}, {Frecuencia}GHz, {Nucleos} núcleos, {Cache}MB Cache, Fabricación: {FechaFabricacion.ToShortDateString()}, Consumo: {Consumo}W, Marca: {Marca}");
        }
    }

    public class PlacaMadre
    {
        public string Marca { get; set; }
        public int Generacion { get; set; }
        public int Consumo { get; set; }
        public int Puertos { get; set; }
        public int RamCant { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Placa Madre: Marca {Marca}, Gen {Generacion}, Consumo: {Consumo}W, RAM: {RamCant} slots, Puertos: {Puertos}");
        }
    }

    public class PlacaDeVideo
    {
        public int MemoriaRam { get; set; }
        public int Consumo { get; set; }
        public string Marca { get; set; }
        public int Coolers { get; set; }
        public float Frecuencia { get; set; }
        public int Generacion { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Placa de Video: Gen {Generacion}, Consumo: {Consumo}W, Coolers: {Coolers}, Frecuencia: {Frecuencia}GHz, Marca: {Marca}, RAM: {MemoriaRam}GB");
        }
    }

    public class Teclado
    {
        public string Tipo { get; set; }
        public string Conexion { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Teclado: Tipo {Tipo}, Conexión: {Conexion}");
        }
    }

    public class Mouse
    {
        public string Tipo { get; set; }
        public string Conexion { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Mouse: Tipo {Tipo}, Conexión: {Conexion}");
        }
    }

    public class Monitor
    {
        public string Resolucion { get; set; }
        public double Tamaño { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Monitor: {Tamaño} pulgadas, Resolución: {Resolucion}");
        }
    }

    public class EquipoInformatico
    {
        public RAM Memoria { get; set; }
        public CPU Procesador { get; set; }
        public PlacaMadre PlacaMadre { get; set; }
        public PlacaDeVideo PlacaDeVideo { get; set; }
        public Teclado Teclado { get; set; }
        public Mouse Mouse { get; set; }
        public Monitor Monitor { get; set; }

    //creamos las funciones de encender, apagar y reiniciar.
        public void Encender()
        {
            Console.WriteLine("Hola :).");
        }

        public void Apagar()
        {
            Console.WriteLine("Adiós.");
        }

        public void Reiniciar()
        {
            Console.WriteLine("Reiniciando...");
        }

    //creamos una funcion para que muestre la informacion por pantalla.

        public void MostrarInfo()
        {
            Console.WriteLine("Información del equipo:");
            Memoria?.MostrarInfo();
            Procesador?.MostrarInfo();
            PlacaMadre?.MostrarInfo();
            PlacaDeVideo?.MostrarInfo();
            Teclado?.MostrarInfo();
            Mouse?.MostrarInfo();
            Monitor?.MostrarInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de inicialización
            EquipoInformatico equipo = new EquipoInformatico
            {
                Memoria = new RAM { Memoria = 16, Frecuencia = 3.2f, Generacion = 4, Marca = "Corsair", Tipo = "DDR4" },
                Procesador = new CPU { Nucleos = 8, Frecuencia = 3.6f, Cache = 16, Marca = "Intel", FechaFabricacion = DateTime.Now, Generacion = 10, Consumo = 95 },
                PlacaMadre = new PlacaMadre { Marca = "ASUS", Generacion = 3, Consumo = 50, Puertos = 6, RamCant = 4 },
                PlacaDeVideo = new PlacaDeVideo { MemoriaRam = 8, Consumo = 120, Marca = "NVIDIA", Coolers = 2, Frecuencia = 1.5f, Generacion = 2 },
                Teclado = new Teclado { Tipo = "Mecánico", Conexion = "USB" },
                Mouse = new Mouse { Tipo = "Óptico", Conexion = "Bluetooth" },
                Monitor = new Monitor { Resolucion = "1920x1080", Tamaño = 24.5 }
            };

            equipo.Encender();
            equipo.MostrarInfo();
            equipo.Apagar();
        }
    }
}
