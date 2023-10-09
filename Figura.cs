
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

        public override string ToString()
        {
            return $"Color: {_color}";
        }
    }
}

