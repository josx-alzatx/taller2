// Implementación para un círculo
public class Circulo : Forma
{
    public double Radio { get; private set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

// Implementación para un rectángulo
public class Rectangulo : Forma
{
    public double Ancho { get; private set; }
    public double Alto { get; private set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public double CalcularArea()
    {
        return Ancho * Alto;
    }
}
