using System;

class Program
{
    static void Main(string[] args)
    {
        Square squ = new Square("", 3);
        squ.SetColor("Yellow");
        // Console.WriteLine(sq.GetColor());----> create a DisplayShape function below for all the shapes
        // Console.WriteLine(sq.GetArea());-----> instead of repeating these 2 lines

        Rectangle rec = new Rectangle("", 3, 2);
        rec.SetColor("Green");

        Circle cir = new Circle("", 2);
        cir.SetColor("Purple");

        // DisplayShape(squ);
        // DisplayShape(rec);
        // DisplayShape(cir);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(squ);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            // Console.WriteLine(s.GetColor());
            // Console.WriteLine(s.GetArea());
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
    // public static void DisplayShape(Shape shape)
    // {
    //     Console.WriteLine(shape.GetColor());
    //     Console.WriteLine(shape.GetArea());
    // }

}