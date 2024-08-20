using System;

class Cono
{
    static void Main(string[] args)
    {
        Console.Write("Por favor profesor, ingrese el radio del cono: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ahora ingrese la altura del cono: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double ab = Math.PI * Math.Pow(radio, 2);
        double generatriz = Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
        double al = Math.PI * radio * generatriz;
        double area = ab + al;
        double volumen = (1.0 / 3) * Math.PI * Math.Pow(radio, 2) * altura;

        Console.WriteLine("Radio del cono: " + radio);
        Console.WriteLine("Altura del cono: " + altura);
        Console.WriteLine("Área de la base: " + ab);
        Console.WriteLine("Área lateral: " + al);
        Console.WriteLine("Generatriz: " + generatriz);
        Console.WriteLine("Área del cono: " + area);
        Console.WriteLine("Volumen del cono: " + volumen);
    }
}
