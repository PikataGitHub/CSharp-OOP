namespace GenericMatrix
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct, IComparable<T>
    {
        //Fields
        private T[,] matrix;

        //Constructors
        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        //Indexers
        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        //Implement operations
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
            firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Two matrices don't have same dimensions!");
            }

            dynamic result = new Matrix<T>(firstMatrix.matrix.GetLength(0), firstMatrix.matrix.GetLength(1));

            for (int i = 0; i < firstMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
            firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Two matrices don't have same dimensions!");
            }

            var result = new Matrix<T>(secondMatrix.matrix.GetLength(0), secondMatrix.matrix.GetLength(1));

            for (int i = 0; i < secondMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(0))
            {
                throw new ArgumentException("Two matrices don't have appropriate dimensions!");
            }

            var result = new Matrix<T>(firstMatrix.matrix.GetLength(0), secondMatrix.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    for (int i = 0; i < firstMatrix.matrix.GetLength(1); i++)
                    {
                        result[row, col] += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                    }
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> inputMatrix)
        {
            bool isTrue = true;

            for (int i = 0; i < inputMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.matrix.GetLength(1); j++)
                {
                    if ((dynamic)inputMatrix[i, j] == 0)
                    {
                        isTrue = false;
                        return isTrue;
                    }
                }
            }
            return isTrue;
        }

        public static bool operator false(Matrix<T> inputMatrix)
        {
            bool isFalse = false;

            for (int i = 0; i < inputMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.matrix.GetLength(1); j++)
                {
                    if ((dynamic)inputMatrix[i, j] == 0)
                    {
                        isFalse = true;
                        return isFalse;
                    }
                }
            }
            return isFalse;
        }

        public static bool operator !(Matrix<T> inputMatrix)
        {
            if (inputMatrix)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder matrixBuilder = new StringBuilder();

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    matrixBuilder.AppendFormat("{0} ", this.matrix[i, j]);
                }
                matrixBuilder.Append("\n");
            }

            return matrixBuilder.ToString();
        }
    }
}
