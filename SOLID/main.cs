class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Circulo y Rectangulo
        Forma circulo = new Circulo(5.0);
        Forma rectangulo = new Rectangulo(4.0, 6.0);

        // Crear una instancia de CalculadoraArea
        CalculadoraArea calculadora = new CalculadoraArea();
        
        // Imprimir las áreas
        calculadora.ImprimirArea(circulo);
        calculadora.ImprimirArea(rectangulo);
    }
}
