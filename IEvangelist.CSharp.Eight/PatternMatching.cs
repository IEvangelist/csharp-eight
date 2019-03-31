using System;

namespace IEvangelist.CSharp.Eight
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    class RGBColor
    {
        internal byte Red { get; }

        internal byte Green { get; }

        internal byte Blue { get; }

        internal RGBColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString() => $"rgb({Red}, {Green}, {Blue})";
    }

    /// <summary>
    /// Example 1, Switch Expressions
    /// </summary>
    static class SwitchExpressions
    {
        internal static RGBColor FromRainbow(this Rainbow rainbowBolor)
        {
            switch (rainbowBolor)
            {
                case Rainbow.Red:
                    return new RGBColor(0xFF, 0x00, 0x00);
                case Rainbow.Orange:
                    return new RGBColor(0xFF, 0x7F, 0x00);
                case Rainbow.Yellow:
                    return new RGBColor(0xFF, 0xFF, 0x00);
                case Rainbow.Green:
                    return new RGBColor(0x00, 0xFF, 0x00);
                case Rainbow.Blue:
                    return new RGBColor(0x00, 0x00, 0xFF);
                case Rainbow.Indigo:
                    return new RGBColor(0x4B, 0x00, 0x82);
                case Rainbow.Violet:
                    return new RGBColor(0x94, 0x00, 0xD3);
                default:
                    throw new ArgumentException(message: "invalid enum value", paramName: nameof(rainbowBolor));
            };
        }

        internal static RGBColor TasteTheRainbow(Rainbow rainbowColor) =>
            rainbowColor switch
        {
            Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
            Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
            Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
            Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
            Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
            Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
            Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
            _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(rainbowColor)),
        };
    }

    class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegion { get; set; }
    }

    /// <summary>
    /// Example 2, Property Patterns
    /// </summary>
    static class PropertyPatterns
    {
        internal static decimal ComputeSalesTax(
            Address location,
            decimal salePrice) =>
            location switch
        {
            { State: "WA" } => salePrice * 0.06m,
            { State: "WI", City: "Milwaukee" } => salePrice * 0.056m,
            { State: "WI" } => salePrice * 0.05m,

            // Other cases removed for brevity...
            _ => 0M
        };
    }

    /// <summary>
    /// Example 3, Tuple Patterns
    /// </summary>
    static class TuplePatterns
    {
        internal static string RockPaperScissors(
            string first,
            string second)
            => (first, second) switch
        {
            ("rock", "paper") => "Rock is covered by Paper. Paper wins!",
            ("rock", "scissors") => "Rock breaks Scissors. Rock wins!",
            ("paper", "rock") => "Paper covers Rock. Paper wins!",
            ("paper", "scissors") => "Paper is cut by Scissors. Scissors wins!",
            ("scissors", "rock") => "Scissors is broken by Rock. Rock wins!",
            ("scissors", "paper") => "Scissors cuts Paper. Scissors wins!",
            (_, _) => "tie"
        };
    }

    class Shape
    {
        protected internal double Height { get; }

        protected internal double Length { get; }

        protected Shape(double height = 0, double length = 0)
        {
            Height = height;
            Length = length;
        }
    }

    class Circle : Shape
    {
        internal double Radius => Height / 2;

        internal double Diameter => Radius * 2;

        internal double Circumference => 2 * Math.PI * Radius;

        internal Circle(double height = 10, double length = 10)
            : base(height, length) { }
    }

    class Rectangle : Shape
    {
        internal bool IsSquare => Height == Length;

        internal Rectangle(double height = 10, double length = 10)
            : base(height, length) { }
    }

    /// <summary>
    /// Example 4, Pattern Matching on Objects with Switch Expressions
    /// </summary>
    static class ObjectPatterns
    {
        internal static string ShapeDetails(this Shape shape)
            => shape switch
        {
            Circle c => $"circle with (C): {c.Circumference}",
            Rectangle s when s.IsSquare => $"L:{s.Length} H:{s.Height}, square",
            Rectangle r => $"L:{r.Length} H:{r.Height}, rectangle",
            _ => "Unknown shape!" // Discard
        };
    }

    class Point
    {
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y) 
            => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) 
            => (x, y) = (X, Y);

        public static implicit operator Point(
            (int X, int Y) tuple)
            => new Point(tuple.X, tuple.Y);
    }

    enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }

    /// <summary>
    /// Example 5, Positional Patterns
    /// </summary>
    static class PositionalPatterns
    {
        internal static Quadrant AsQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            (_, _) => Quadrant.OnBorder, // Either are 0, but not both
            _ => Quadrant.Unknown
        };
    }
}