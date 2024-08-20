using System;

class Cono
{
    static void Main(string[] args)
    {
        const int NUM_CONOS = 5;
        double[] radios = new double[NUM_CONOS];
        double[] alturas = new double[NUM_CONOS];
        double[] areas = new double[NUM_CONOS];
        double[] volumenes = new double[NUM_CONOS];

        for (int i = 0; i < NUM_CONOS; i++)
        {
            Console.Write($"Profesor, por favor ingrese el radio del cono {i + 1}: ");
            radios[i] = GetDoubleValue();

            Console.Write($"Ahora ingrese la altura del cono {i + 1}: ");
            alturas[i] = GetDoubleValue();

            double ab = Math.PI * Math.Pow(radios[i], 2);
            double generatriz = Math.Sqrt(Math.Pow(radios[i], 2) + Math.Pow(alturas[i], 2));
            double al = Math.PI * radios[i] * generatriz;
            areas[i] = ab + al;
            volumenes[i] = (1.0 / 3) * Math.PI * Math.Pow(radios[i], 2) * alturas[i];

            Console.WriteLine($"Radio del cono {i + 1}: {radios[i]}");
            Console.WriteLine($"Altura del cono {i + 1}: {alturas[i]}");
            Console.WriteLine($"Área de la base: {ab}");
            Console.WriteLine($"Área lateral: {al}");
            Console.WriteLine($"Generatriz: {generatriz}");
            Console.WriteLine($"Área del cono {i + 1}: {areas[i]}");
            Console.WriteLine($"Volumen del cono {i + 1}: {volumenes[i]}");
            Console.WriteLine();
        }

        int maxVolumenIndex = GetMaxVolumenIndex(volumenes);
        Console.WriteLine($"El cono de mayor volumen es el {maxVolumenIndex + 1} con un volumen de {volumenes[maxVolumenIndex]}");

        double promedioVolumenes = GetPromedio(volumenes);
        Console.WriteLine($"El promedio de los volúmenes de los conos es {promedioVolumenes}");
    }

    static double GetDoubleValue()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                if (value > 0)
                {
                    return value;
                }
                else
                {
                    Console.Write("¡Ingrese un número mayor a 0, por favor! siga intentando: ");
                }
            }
            else
            {
                Console.Write("¡No válido! Siga intentando: ");
            }
        }
    }

    static int GetMaxVolumenIndex(double[] volumenes)
    {
        int maxIndex = 0;
        double maxVolumen = volumenes[0];
        for (int i = 1; i < volumenes.Length; i++)
        {
            if (volumenes[i] > maxVolumen)
            {
                maxIndex = i;
                maxVolumen = volumenes[i];
            }
        }
        return maxIndex;
    }

    static double GetPromedio(double[] valores)
    {
        double sum = 0;
        foreach (double valor in valores)
        {
            sum += valor;
        }
        return sum / valores.Length;
    }
}
