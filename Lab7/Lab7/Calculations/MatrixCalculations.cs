using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Calculations
{
    internal class MatrixCalculations
    {
        public MatrixCalculations() { }

        public float MultiplyElements(float[,] elements)
        {
            float result = 1;
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    result *= elements[i, j];
                }
            }

            return result;
        }

        public string FindMaxInRows(float[,] elements)
        {
            int rows = elements.GetLength(0);
            int cols = elements.GetLength(1);
            float[] maxInRows = new float[rows];

            string result;

            for (int i = 0; i < rows; i++)
            {
                float max = elements[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (elements[i, j] > max)
                    {
                        max = elements[i, j];
                    }
                }
                maxInRows[i] = max;
            }

            result = string.Join(", ", maxInRows);

            return result;
        }

        public string CountOddsInColumns(float[,] elements)
        {
            int rows = elements.GetLength(0);
            int cols = elements.GetLength(1);
            float[] countOdds = new float[cols];

            string result;

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (elements[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
                countOdds[j] = count;
            }

            result = string.Join(", ", countOdds);

            return result;
        }

        public string CountEvens(float[,] elements)
        {
            int rows = elements.GetLength(0);
            int cols = elements.GetLength(1);
            float[] countEvens = new float[cols];

            string result;

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (elements[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
                countEvens[j] = count;
            }

            result = string.Join(", ", countEvens);

            return result;
        }

        public float[,] DeleteRow(float[,] elements, int row)
        {
            int rows = elements.GetLength(0);
            int cols = elements.GetLength(1);

            if (row < 0 || row >= rows)
                throw new ArgumentException("Incorrect index!");

            float[,] newElements = new float[rows - 1, cols];
            int newRow = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i == row) continue;
                for (int j = 0; j < cols; j++)
                {
                    newElements[newRow, j] = elements[i, j];
                }
                newRow++;
            }

            return newElements;
        }

        public float[,] AddColumn(float[,] elements, float[] column)
        {
            int rows = elements.GetLength(0);
            int cols = elements.GetLength(1);

            if (column.Length != rows)
                throw new ArgumentException("Column lenght must match the number of rows in the matrix!");

            float[,] newElements = new float[rows, cols + 1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newElements[i, j] = elements[i, j];
                }
                newElements[i, cols] = column[i];
            }

            return newElements;
        }

        public float[,] SortMatrixRow(float[,] matrix, bool ascending)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            float[,] sortedMatrix = (float[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                float[] row = new float[cols];

                for (int j = 0; j < cols; j++)
                {
                    row[j] = sortedMatrix[i, j];
                }

                Array.Sort(row);

                if (!ascending)
                {
                    Array.Reverse(row);
                }

                for (int j = 0; j < cols; j++)
                {
                    sortedMatrix[i, j] = row[j];
                }
            }

            return sortedMatrix;
        }
        public float[,] FillMatrixRandom(int n, int m)
        {
            Random rand = new Random();
            float[,] matrix = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                }
            }
            return matrix;
        }
    }
}
