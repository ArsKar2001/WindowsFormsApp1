using System;
using System.Windows.Forms;

namespace MatrixCalculate.forms
{
    public partial class OperationForm : Form
    {
        private Operation Operation { get; }

        private static Matrix _matrix1 = null;
        private static Matrix _matrix2 = null;
        private static Matrix _matrix3 = null;

        private static OutMatrixForm _matrixForm = null;

        private static bool _f1 = false;
        private static bool _f2 = false;
        
        public OperationForm()
        {
            InitializeComponent();
        }

        public OperationForm(Operation o)
        {
            Operation = o;
            InitializeComponent();
        }

        public OperationForm(Operation o, int width, int height)
        {
            Operation = o;
            Width = width;
            Height = height;
            InitializeComponent();
        }

        private void OperationForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitleForm();
        }

        private void SetTitleForm()
        {
            switch (Operation)
            {
                case Operation.SUM:
                    Text = @"Сложение матриц";
                    break;
                case Operation.SUB:
                    Text = @"Вычитание матриц";
                    break;
                case Operation.MUL:
                    Text = @"Умножение матриц";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            
            var n = int.Parse(textBox1.Text);
            _matrix1 = new Matrix(n);

            _matrixForm = new OutMatrixForm(_matrix1);

            if (_matrixForm.ShowDialog() == DialogResult.OK)
            {
                var matrix = _matrixForm.Matrix;
                for (int i = 0; i < matrix.N; i++)
                for (int j = 0; j < matrix.N; j++)
                    _matrix1.Values[i, j] = matrix.Values[i, j];
                _f1 = true;
                label2.Text = _f1.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!_f1)
            {
                MessageBox.Show(@"Сперва заполните матрицу 1");
                return;
            }
            
            if (textBox1.Text == "") return;
            
            var n = int.Parse(textBox1.Text);
            _matrix2 = new Matrix(n);

            _matrixForm = new OutMatrixForm(_matrix2);

            if (_matrixForm.ShowDialog() == DialogResult.OK)
            {
                var matrix = _matrixForm.Matrix;
                for (int i = 0; i < matrix.N; i++)
                for (int j = 0; j < matrix.N; j++)
                    _matrix2.Values[i, j] = matrix.Values[i, j];
                _f2 = true;
                label3.Text = _f2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!_f1 || !_f2) return;

            switch (Operation)
            {
                case Operation.SUM:
                    _matrix3 = _matrix1.Add(_matrix2);
                    break;
                case Operation.SUB:
                    _matrix3 = _matrix1.Subtract(_matrix2);
                    break;
                case Operation.MUL:
                    _matrix3 = _matrix1.Multiply(_matrix2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            new OutMatrixForm(_matrix3).Show();
        }
    }
}