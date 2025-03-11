using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.NET
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

        public string CalculateVolume(string inputs, string figure)
        {
            switch (figure)
            {
                case "Ball":
                    float radius = float.Parse(inputs);
                    return (4.0 / 3.0 * Math.PI * radius * radius * radius).ToString("F2");
                case "Pyramid":
                    string[] pyramidParams = inputs.Split(',');
                    float side = float.Parse(pyramidParams[0]), hPyramid = float.Parse(pyramidParams[1]);
                    return (side * side * hPyramid / 3.0).ToString("F2");
                case "Cube":
                    float cubeSide = float.Parse(inputs);
                    return (cubeSide * cubeSide * cubeSide).ToString("F2");
                case "Parallelepiped":
                    string[] parallelepipedParams = inputs.Split(',');
                    float w = float.Parse(parallelepipedParams[0]), hParallelepiped = float.Parse(parallelepipedParams[1]), d = float.Parse(parallelepipedParams[2]);
                    return (w * hParallelepiped * d).ToString("F2");
                case "Prism":
                    string[] prismParams = inputs.Split(',');
                    float prismSide = float.Parse(prismParams[0]), prismHeight = float.Parse(prismParams[1]);
                    return (prismSide * prismSide * prismHeight).ToString("F2");
                default:
                    return "0";
            }
        }
    }
}
