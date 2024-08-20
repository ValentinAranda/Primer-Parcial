using System;

//Entidades del proyecto
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
    //si lees esto; ¡tené un buen día (o noche)!
    public bool IsValid()
    {
        return radio > 0 && altura > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cono cono = new Cono();

        Console.Write("Carlos, ingrese el radio del cono por favor: ");
        cono.Radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ahora la altura del cono por favor: ");
        cono.Altura = Convert.ToDouble(Console.ReadLine());

        if (cono.IsValid())
        {
            Console.WriteLine("Radio del cono es: " + cono.Radio);
            Console.WriteLine("Altura del cono es: " + cono.Altura);
            Console.WriteLine("Área del cono es: " + cono.Area);
            Console.WriteLine("Volumen del cono es: " + cono.Volumen);
            Console.WriteLine("Diagonal del cono es: " + cono.Diagonal);
        }
        else
        {
            Console.WriteLine("¡No, no! Siga intentando...");
        }
    }
}
