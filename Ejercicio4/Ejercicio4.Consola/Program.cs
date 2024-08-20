using System;

// Entidades
public struct Cono
{
    private double radio;
    private double altura;

    public Cono(double radio, double altura)
    {
        this.radio = radio;
        this.altura = altura;
    }

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public double Area
    {
        get { return Math.PI * Math.Pow(radio, 2) + Math.PI * radio * GetGeneratriz(); }
    }

    public double Volumen
    {
        get { return (1.0 / 3) * Math.PI * Math.Pow(radio, 2) * altura; }
    }

    public double Diagonal
    {
        get { return GetGeneratriz(); }
    }

    private double GetGeneratriz()
    {
        return Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
    }

    public bool IsValid()
    {
        return radio > 0 && altura > 0;
    }
}

class Conteiner
{
    private void Main2 (string[] args)
    {
        Cono cono = new Cono();

        Console.Write("Ingrese el radio del cono: ");
        cono.Radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ngrese la altura del cono: ");
        cono.Altura = Convert.ToDouble(Console.ReadLine());

        if (cono.IsValid())
        {
            Console.WriteLine("Radio del cono: " + cono.Radio);
            Console.WriteLine("Altura del cono: " + cono.Altura);
            Console.WriteLine("Área del cono: " + cono.Area);
            Console.WriteLine("Volumen del cono: " + cono.Volumen);
            Console.WriteLine("Diagonal del cono: " + cono.Diagonal);
        }
        else
        {
            Console.WriteLine("¡Los valores están mal!");
        }
    }

}
