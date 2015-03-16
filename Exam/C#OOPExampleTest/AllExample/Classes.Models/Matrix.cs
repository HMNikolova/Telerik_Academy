using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    class Matrix<T>
    {
        private T[,] matrix;
        
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }
        
        public T this[int row, int col]
        {
            get {return this.matrix[row, col];}
            set { this.matrix[row, col] = value; }
        }
        
        //ще умножаваме матрица по число и да ни връща друга матрица, задължително трябва да имаме static
        //на оператора му казваме дай ми матрица от Т и int num
        public static Matrix<T> operator * (Matrix<T> m1, Matrix<T> m2)
        {
            return m1;
        }
        
         public static Matrix<T> operator * (Matrix<T> matrix, int num)
        {
            return matrix;
        }
        //и си override стринга
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    sb.Append(this.matrix[i, j]);
                }
                sb.AppnedLine();
            }
            return sb.ToString();
        }
    }
}
