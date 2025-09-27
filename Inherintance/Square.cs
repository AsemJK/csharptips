namespace csharptips.Inherintance
{
    internal class Square : DrawingShape
    {
        //You must implement the inherited abstract member 'DrawingShape.Area()' for non-abstract class 'Square'

        public Square(int size) : base(size) { }
        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
