using System;

namespace Conos
{
    //Entidades
    public struct Cono
    {
        public double Radio { get; set; }
        public double Altura { get; set; }

        public double Volumen
        {
            get { return (1.0 / 3) * Math.PI * Radio * Radio * Altura; }
        }
    }

    class Program
    {
        private const int MAX_CONOS = 10;
        private Cono[] conos = new Cono[MAX_CONOS];
        private int cantidadConos = 0;

        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.Menu();
        }

        private void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Ingresar conos");
                Console.WriteLine("2. Mostrar conos");
                Console.WriteLine("3. Modificar cono");
                Console.WriteLine("4. Estadísticas");
                Console.WriteLine("5. Conos inferiores al promedio");
                Console.WriteLine("6. Cerrar.");
                Console.Write("¿Qué va a elegir?: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarConos();
                        break;
                    case 2:
                        MostrarConos();
                        break;
                    case 3:
                        ModificarCono();
                        break;
                    case 4:
                        Estadisticas();
                        break;
                    case 5:
                        ConosInferioresAlPromedio();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Eso no existe...");
                        break;
                }
            }
        }

        private void IngresarConos()
        {
            if (cantidadConos < MAX_CONOS)
            {
                Console.Write("El Radio será de : ");
                double radio = Convert.ToDouble(Console.ReadLine());
                Console.Write("La Altura será de: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Cono cono = new Cono { Radio = radio, Altura = altura };
                conos[cantidadConos] = cono;
                cantidadConos++;

                Console.WriteLine("Se ha ingresado correctamente el Cono");
            }
            else
            {
                Console.WriteLine("¡El Array está lleno");
            }
        }

        private bool EstaLleno()
        {
            return cantidadConos == MAX_CONOS;
        }

        private void MostrarConos()
        {
            for (int i = 0; i < cantidadConos; i++)
            {
                Console.WriteLine($"Cono {i + 1}: Radio = {conos[i].Radio}, Altura = {conos[i].Altura}, Volumen = {conos[i].Volumen}");
            }
        }

        private void ModificarCono()
        {
            Console.Write("¿Qué Cono va a modificar?: ");
            int numCono = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numCono >= 0 && numCono < cantidadConos)
            {
                Console.Write("Nuevo radio: ");
                double radio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nueva altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                conos[numCono] = new Cono { Radio = radio, Altura = altura };
                Console.WriteLine("El se ha Cono modificado correctamente");
            }
            else
            {
                Console.WriteLine("¡Eso no existe!");
            }
        }

        private void Estadisticas()
        {
            double maxVolumen = 0;
            double minVolumen = double.MaxValue;
            double sumVolumen = 0;

            for (int i = 0; i < cantidadConos; i++)
            {
                double volumen = conos[i].Volumen;
                sumVolumen += volumen;

                if (volumen > maxVolumen)
                {
                    maxVolumen = volumen;
                }

                if (volumen < minVolumen)
                {
                    minVolumen = volumen;
                }
            }

            double promedioVolumen = sumVolumen / cantidadConos;

            Console.WriteLine($"El Cono de mayor volumen es: {maxVolumen}");
            Console.WriteLine($"El Cono de menor volumen es: {minVolumen}");
            Console.WriteLine($"El Promedio de los volúmenes es: {promedioVolumen}");
        }
        //La verdad que los conos inferiores no me lo agarra bien la consola, y no me queda mucho tiempo tampoco... Así que va a estar faltante.
        private void ConosInferioresAlPromedio()
        {
            double promedioVolumen = 0;
            for (int i = 0; i < cantidadConos; i++)
            {
                promedioVolumen += conos[i].Volumen;
            }
            promedioVolumen /= cantidadConos;
        }
    }
}