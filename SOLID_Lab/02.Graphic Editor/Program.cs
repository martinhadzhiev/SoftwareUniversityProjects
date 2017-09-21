namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            GraphicEditor editor = new GraphicEditor();
            IShape rectangle = new Rectangle();

            editor.DrawShape(rectangle);
        }
    }
}
