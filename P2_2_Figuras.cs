using System;
using System.Collections.Generic;
using System.Drawing;

namespace P2_2_Figuras
{
    public class P2_2_Figuras
    {
        static void Main(string[] args)
        {
            // Crear una lista de figuras
            List<Figura> lista_figuras = new List<Figura>();

            // Crear instancias de figuras y agregarlas a la lista
            Color colorRectangulo = Color.FromArgb(255, 50, 20, 34);
            Rectangulo rectangulo = new Rectangulo(colorRectangulo, 3.9, 3);
            lista_figuras.Add(rectangulo);

            Color colorCirculo = Color.FromArgb(255, 230, 20, 30);
            Circulo circulo = new Circulo(colorCirculo, 2);
            lista_figuras.Add(circulo);

            Color colorTriangulo = Color.FromArgb(255, 0, 20, 40);
            TrianguloEquilatero triangulo = new TrianguloEquilatero(colorTriangulo, 3);
            lista_figuras.Add(triangulo);

            // Mostrar las figuras y sus áreas
            Console.WriteLine("Lista de Figuras:");
            foreach (Figura figura in lista_figuras)
            {
                MostrarFigura(figura);
            }
        }

        // Método para mostrar la figura y su área
        static void MostrarFigura(Figura figura)
        {
            Console.WriteLine(figura.ToString());
            Console.WriteLine($"Área: {figura.GetArea():F2}\n");
        }
    }
}
