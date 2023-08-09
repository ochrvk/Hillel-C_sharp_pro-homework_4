namespace Task_2
{
    public class Matrix
    {
        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _array = new int[rows, columns];
        }

        private int _rows;
        private int _columns;
        private int[,] _array;

        public int Rows
        {
            get { return _rows; }
        }

        public int Columns
        {
            get { return _columns; }
        }

        public int this[int row, int column]
        {
            get
            {
                if (row >= 0 && row < _array.GetLength(0) && column >= 0 && column < _array.GetLength(1))
                    return _array[row, column];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (row >= 0 && row < _array.GetLength(0) && column >= 0 && column < _array.GetLength(1))
                    _array[row, column] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1._rows != m2._columns || m1._columns != m2._columns)
                throw new ArgumentException("The matrixes have different sizes");

            Matrix result = new Matrix(m1._rows, m1._columns);
            for (int i = 0; i < m1._rows; i++)
            {
                for (int j = 0; j < m1._columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1._rows != m2._rows || m1._columns != m2._columns)
                throw new ArgumentException("The matrixes have different sizes");

            Matrix result = new Matrix(m1._rows, m1._columns);
            for (int i = 0; i < m1._rows; i++)
            {
                for (int j = 0; j < m1._columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix, int scalar)
        {
            Matrix result = new Matrix(matrix._rows, matrix._columns);
            for (int i = 0; i < matrix._rows; i++)
            {
                for (int j = 0; j < matrix._columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Rows)
                throw new ArgumentException("The number of columns of the first matrix must be equal to the number of rows of the second matrix");

            Matrix result = new Matrix(m1.Rows, m2.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null))
                return false;
            if (m1._rows != m2._rows || m1._columns != m2._columns)
                return false;

            for (int i = 0; i < m1._rows; i++)
            {
                for (int j = 0; j < m1._columns; j++)
                {
                    if (m1[i, j] != m2[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Matrix other = (Matrix)obj;

            return _rows == other.Rows || _columns == other.Columns;
        }

    }
}
