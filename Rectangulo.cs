using System.Drawing;

namespace P2_2_Figuras
{
    internal class Rectangulo : Figura
    {
        private double _base;
        private double _altura;

        public Rectangulo(Color color, double ancho, double alto) : base(color)
        {
            _base = ancho;
            _altura = alto;
        }

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public override double GetArea()
        {
            return _base * _altura;
        }

        public override string ToString()
        {
            return $"FIGURA RECTANGULO\nAncho: {_base}\nAlto: {_altura}\n{base.ToString()}";
        }
    }
}
