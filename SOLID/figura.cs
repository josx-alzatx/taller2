// Interfaz para las formas geométricas
public interface Forma
{
    double CalcularArea();
}

// Clase responsable de imprimir el área de una forma
public class CalculadoraArea
{
    public void ImprimirArea(IForma forma)
    {
        double area = forma.CalcularArea();
        Console.WriteLine($"El área de la forma es: {area}");
    }
}

