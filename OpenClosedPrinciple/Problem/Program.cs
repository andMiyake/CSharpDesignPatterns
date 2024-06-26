﻿namespace Problem
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var apple = new Product("Apple", Color.Green, Size.Small);
    //        var tree = new Product("Tree", Color.Green, Size.Large);
    //        var house = new Product("House", Color.Blue, Size.Large);

    //        Product[] products = { apple, tree, house };

    //        var pf = new ProductFilter();
    //        Console.WriteLine("Green products:");
    //        foreach (var p in pf.FilterByColor(products, Color.Green)) 
    //        {
    //            Console.WriteLine($" - {p.Name} is green");
    //        }
    //    }
    //}

    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }

    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (Product p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (Product p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }
    }
}
