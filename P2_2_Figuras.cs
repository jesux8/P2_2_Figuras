using System;
using System.Drawing;

namespace P2_2_Figuras
{
    public class P2_2_Figuras
    {
        static void Main(string[] args)
        {
            Color color = Color.FromArgb(255, 50, 20, 34);

            Rectangulo rectangulo = new Rectangulo(color, 3.9, 3);
            Circulo circulo = new Circulo(color, 5);
            TrianguloEquilatero triangulo = new TrianguloEquilatero(color, 4);

            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine($"Área: {rectangulo.GetArea()}\n");

            Console.WriteLine(circulo.ToString());
            Console.WriteLine($"Área: {circulo.GetArea()}\n");

            Console.WriteLine(triangulo.ToString());
            Console.WriteLine($"Área: {triangulo.GetArea()}");
        }
    }
}
