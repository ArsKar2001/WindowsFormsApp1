namespace MatrixCalculate
{
    public class Matrix
    {
        public int[,] Values { get; }
        public int N { get; }

        public Matrix(int[,] values, int n)
        {
            this.Values = values;
            this.N = n;
        }

        public Matrix(int n)
        {
            this.N = n;
            this.Values = new int[N, N];
        }

        public Matrix Add(Matrix matrix)
        {
            if (this.N != matrix.N) return null;
            
            var newMatrix = new Matrix(this.N);
            
            for (var i = 0; i < this.N; i++)
            for (var j = 0; j < this.N; j++)
                newMatrix.Values[i, j] = matrix.Values[i, j] + this.Values[i, j];

            return newMatrix;
        }
        
        public Matrix Subtract(Matrix matrix)
        {
            if (this.N != matrix.N) return null;
            
            var newMatrix = new Matrix(this.N);
            
            for (var i = 0; i < this.N; i++)
            for (var j = 0; j < this.N; j++)
                newMatrix.Values[i, j] = matrix.Values[i, j] - this.Values[i, j];

            return newMatrix;
        }
        
        public Matrix Multiply(Matrix matrix)
        {
            if (this.N != matrix.N) return null;
            
            var newMatrix = new Matrix(this.N);
            
            for (var i = 0; i < this.N; i++)
            for (var j = 0; j < this.N; j++)
            {
                newMatrix.Values[i, j] = 0;
                for (int k = 0; k < this.N; k++) 
                    newMatrix.Values[i, j] += this.Values[k, j] * matrix.Values[i, k];
            }
            
            return newMatrix;
        }
    }
}