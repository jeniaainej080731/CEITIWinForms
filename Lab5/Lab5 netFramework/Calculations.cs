using System;

namespace Lab5_netFramework
{
    internal class Calculations
    {

        public Calculations() { }

        public string CalculatePerimeter(string inputs, string figure)
        {
            if (inputs == null || figure == null)
            {
                return "Invalid input";
            }

            string[] sizes = inputs.Split(',');
            
            switch (figure.ToLower())
            {
                case "square":
                    int aSquare = Convert.ToInt32(sizes[0]);
                    return (4 * aSquare).ToString();
                case "triangle":
                    int aTriangle = Convert.ToInt32(sizes[0]),
                        bTriangle = Convert.ToInt32(sizes[1]),
                        cTriangle = Convert.ToInt32(sizes[2]);
                    return (aTriangle + bTriangle + cTriangle).ToString();
                case "rectangle":
                    int aRectangle = Convert.ToInt32(sizes[0]),
                        bRectangle = Convert.ToInt32(sizes[1]);
                    return (2 * (aRectangle + bRectangle)).ToString();
                case "circle":
                    int rCircle = Convert.ToInt32(sizes[0]);
                    return (2 * Math.PI * rCircle).ToString("F2");
                default:
                    return "Invalid figure";
            }
        }

        public string CalculateArea(string inputs, string figure)
        {
            string[] sizes = inputs.Split(',');

            switch (figure.ToLower())
            {
                case "square":
                    int aSquare = Convert.ToInt32(sizes[0]);
                    return (aSquare * aSquare).ToString();
                case "triangle":
                    int aTriangle = Convert.ToInt32(sizes[0]),
                        bTriangle = Convert.ToInt32(sizes[1]),
                        cTriangle = Convert.ToInt32(sizes[2]);
                    double p = (aTriangle + bTriangle + cTriangle) / 2;
                    return Math.Sqrt(p * (p - aTriangle) * (p - bTriangle) * (p - cTriangle)).ToString("F2");
                case "rectangle":
                    int aRectangle = Convert.ToInt32(sizes[0]),
                        bRectangle = Convert.ToInt32(sizes[1]);
                    return (aRectangle * bRectangle).ToString();
                case "circle":
                    int rCircle = Convert.ToInt32(sizes[0]);
                    return (Math.PI * rCircle * rCircle).ToString("F2");
                default:
                    return "Invalid figure";
            }
        }
    }
}
