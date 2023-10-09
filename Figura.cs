
using System.Dynamic;
using System.Drawing;

namespace P2_2_Figuras
{
    internal abstract class Figura
    {
        protected Color _color;

        public Figura(Color color)
        {
            _color = color;
        }

        public abstract double GetArea();

        public void CambiarColor(Color nuevoColor)
        {
            _color = nuevoColor;
        }

        public override string ToString()
        {
            return $"Color: {_color}";
        }
    }
}
