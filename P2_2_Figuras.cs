
using System;
using System.Drawing;

namespace P2_2_Figuras
{
    public class P2_2_Figuras
    {
        static void Main(string[] args)
        {
            // Crear instancias de las figuras
            Color color = Color.FromArgb(255, 50, 20, 34);
            Rectangulo rectangulo = new Rectangulo(color, 3.9, 3);
            Circulo circulo = new Circulo(color, 5);
            TrianguloEquilatero triangulo = new TrianguloEquilatero(color, 4);

            // Mostrar las figuras y sus áreas
            Console.WriteLine("Figuras Originales:");
            MostrarFigura(rectangulo);
            MostrarFigura(circulo);
            MostrarFigura(triangulo);

            // Modificar algunos parámetros y mostrar las figuras nuevamente
            rectangulo.Base = 5;
            circulo.Radio = 7;
            triangulo.Lado = 6;

            Console.WriteLine("\nFiguras Modificadas:");
            MostrarFigura(rectangulo);
            MostrarFigura(circulo);
            MostrarFigura(triangulo);
        }

        // Método para mostrar la figura y su área
        static void MostrarFigura(Figura figura)
        {
            Console.WriteLine(figura.ToString());
            Console.WriteLine($"Área: {figura.GetArea()}\n");
        }
    }
}