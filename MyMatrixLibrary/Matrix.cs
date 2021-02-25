using System;

namespace MyMatrixLibrary
{
    public class Matrix
    {
        private int[][] _matrix;

        public Matrix(int row, int col)
        {
            _matrix = new int[row][];
            for (int i = 0; i < row; i++)
            {
                _matrix[i] = new int[col];
            }
        }

        public Matrix(int n)
        {
            _matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                _matrix[i] = new int[n];
            }
        }

        public void ReadMatrix()
        {
            if (_matrix.Length != 0)
            {
                Console.WriteLine("Input matrix " + _matrix.Length + "x" + (_matrix[0].Length));
                for (var i = 0; i < _matrix.Length; i++)
                {
                    Console.WriteLine("Input " + i + " row in one line:");
                    var strings = Console.ReadLine()?.Split(' ');
                    var col = 0;

                    if (strings == null) continue;
                    foreach (var d in strings)
                    {
                        int res;
                        if (int.TryParse(d, out res))
                        {
                            _matrix[i][col++] = res;
                        }
                    }
                }
            }
        }

        public void WriteMatrix()
        {
            foreach (var t in _matrix)
            {
                for (var j = 0; j < t.Length; j++)
                {
                    Console.Write(t[j] + " ");
                }

                Console.WriteLine();
            }
        }

        public int NumberOfRowsIncreased()
        {
            int number = 0;

            foreach (var t in _matrix)
            {
                if (IsIncreases(t)) number++;
            }

            return number;
        }

        public bool IsIncreases(int[] row)
        {
            bool isIncreases = true;

            for (int i = 1; i < _matrix.Length - 1; i++)
            {
                if (row[i + 1] <= row[i])
                {
                    isIncreases = false;
                    break;
                }
            }

            return isIncreases;
        }

        public int NumberOfRowsDecreased()
        {
            int number = 0;

            foreach (var t in _matrix)
            {
                if (IsDecreases(t)) number++;
            }

            return number;
        }

        public bool IsDecreases(int[] row)
        {
            bool isDecreases = true;

            for (int i = 1; i < _matrix.Length - 1; i++)
            {
                if (row[i + 1] >= row[i])
                {
                    isDecreases = false;
                    break;
                }
            }

            return isDecreases;
        }

        public int NumberOfRowsWithEqualElements ()
        {
            int number = 0;

            foreach (var t in _matrix)
            {
                if (IsEqual(t)) number++;
            }

            return number;
        }

        public bool IsEqual (int[] row)
        {
            bool isEqual = true;

            for (int i = 1; i < _matrix.Length - 1; i++)
            {
                if (row[i + 1] != row[i])
                {
                    isEqual = false;
                    break;
                }
            }

            return isEqual;
        }

        public int NumberOfRowsDisordered()
        {
            int number = 0;

            foreach (var t in _matrix)
            {
                if (!IsIncreases(t) && !IsDecreases(t) && !IsEqual(t)) number++;
            }

            return number;
        }
    }
}