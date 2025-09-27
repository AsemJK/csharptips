namespace csharptips.Inherintance
{
    abstract class DrawingShape
    {
        private readonly int _size;

        public DrawingShape(int size)
        {
            _size = size;
        }
        public abstract double Area();
    }
}
