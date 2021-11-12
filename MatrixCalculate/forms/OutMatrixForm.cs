using System;
using System.Windows.Forms;

namespace MatrixCalculate.forms
{
    public partial class OutMatrixForm : Form
    {
        public Matrix Matrix { get; set; }

        public OutMatrixForm()
        {
            InitializeComponent();
        }

        public OutMatrixForm(Matrix matrix)
        {
            InitializeComponent();
            this.Matrix = matrix;
            this.dataGridView1.RowCount = matrix.N;
            this.dataGridView1.ColumnCount = matrix.N;
        }

        private void OutMatrixForm_Load(object sender, EventArgs e)
        {
            var matrixValues = Matrix.Values;
            for (var i = 0; i < Matrix.N; i++)
            for (var j = 0; j < Matrix.N; j++)
                dataGridView1.Rows[i].Cells[j].Value = matrixValues[i, j].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Matrix.N; i++)
            for (int j = 0; j < Matrix.N; j++)
            {
                var textBox = dataGridView1.Rows[i].Cells[j].Value.ToString();

                if (textBox == "") textBox = @"0";
                Matrix.Values[i, j] = int.Parse(textBox);
            }
        }
    }
}