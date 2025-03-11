using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Calculations
{
    internal class ArrayCalculations
    {
        public ArrayCalculations() { }

        public float SumOfElements(float[] elements)
        {
            float sum = 0;
            foreach (float i in elements)
            {
                sum += i;
            }

            return sum;
        }

        public float MinElement(float[] elements)
        {
            float min = elements[0];
            foreach (float i in elements)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }

        public int CountOfZeros(float[] elements)
        {
            int count = 0;
            foreach (float i in elements)
            {
                if (i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int CountOfPositive(float[] elements)
        {
            int count = 0;
            foreach (float i in elements)
            {
                if (i > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int CountOfNegative(float[] elements)
        {
            int count = 0;
            foreach (float i in elements)
            {
                if (i < 0)
                {
                    count++;
                }
            }

            return count;
        }

        public float[] AddElement(float[] elements, float element)
        {
            List<float> list = elements.ToList();
            list.Add(element);
            elements = list.ToArray();

            return elements;
        }

        public int FindElement(float[] elements, float element)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (element == elements[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
